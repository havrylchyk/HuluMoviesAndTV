using CsvHelper;
using HuluMoviesAndTV.Core.Context;
using HuluMoviesAndTV.Core.Entity;
using HuluMoviesAndTVParse.Dtos;

throw new ArgumentException("---- - - -");

Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- APP STARTED --");


using (var ctx = new MoviesAndShowsContext())
{
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();

    using (var reader = new StreamReader("HuluTitles.csv"))
    using (var csvReader = new CsvReader(reader, culture: System.Globalization.CultureInfo.CurrentCulture))
    {
        var records = csvReader.GetRecords<MoviesAndTVShowsReadDto>().ToList();

        List<string> country = new List<string>();

        foreach (var r in records)
        {
            if (r.CountryParsed.Length > 0)
                country.AddRange(r.CountryParsed);
        }

        ctx.Countries.AddRange(country.Distinct().Select(x => new Country
        {
            Name = x
        }));


        ctx.SaveChanges();
        List<string> listened = new List<string>();

        foreach (var r in records)
        {
            if (r.ListedInParsed.Length > 0)
                listened.AddRange(r.ListedInParsed);

        }

        ctx.Listeneds.AddRange(listened.Distinct().Select(x => new Listened
        {
            Name = x
        }));

        ctx.SaveChanges();
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- Countries ADDED --");

        var MovieAndShows = new List<MovieAndShow>();
        foreach (var x in records)
        {
            var movieAndShow = new MovieAndShow
            {
                Title = x.Title,
                Duration = x.Duration,
                Description = x.Description,
                Country = new List<Country>(),
                Listened = new List<Listened>()
            };


            movieAndShow.Type = ctx.ProgramTypes.FirstOrDefault(pt => pt.Name == x.Type);
            if (movieAndShow.Type == null)
            {
                movieAndShow.Type = new ProgramType { Name = x.Type };
                ctx.ProgramTypes.Add(movieAndShow.Type);
            }
            movieAndShow.Year = ctx.ReleaseYears.FirstOrDefault(ry => ry.Year == x.ReleaseYear);
            if (movieAndShow.Year == null)
            {
                movieAndShow.Year = new ReleaseYear { Year = x.ReleaseYear };
                ctx.ReleaseYears.Add(movieAndShow.Year);
            }

            if (!string.IsNullOrEmpty(x.Director))
            {
                movieAndShow.Director = ctx.Directors.FirstOrDefault(d => d.Name == x.Director);
                if (movieAndShow.Director == null)
                {
                    movieAndShow.Director = new Director { Name = x.Director };
                    ctx.Directors.Add(movieAndShow.Director);
                }
            }

            if (!string.IsNullOrEmpty(x.Rating))
            {
                movieAndShow.Rating = ctx.Ratings.FirstOrDefault(r => r.Name == x.Rating);
                if (movieAndShow.Rating == null)
                {
                    movieAndShow.Rating = new Rating { Name = x.Rating };
                    ctx.Ratings.Add(movieAndShow.Rating);
                }
            }

            if (x.CountryParsed.Length > 0)
                foreach (var t in x.CountryParsed)
                    movieAndShow.Country.Add(ctx.Countries.Distinct().First(x => x.Name == t));

            if (x.ListedInParsed.Length > 0)
                foreach (var t in x.ListedInParsed)
                    movieAndShow.Listened.Add(ctx.Listeneds.Distinct().First(x => x.Name == t));

            ctx.SaveChanges();

            MovieAndShows.Add(movieAndShow);
        }

        ctx.MovieAndShows.AddRange(MovieAndShows);
        ctx.SaveChanges();

        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- MovieAndShows ADDED --");
    }
}
