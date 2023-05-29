using CsvHelper;
using HuluMoviesAndTV.Core.Context;
using HuluMoviesAndTV.Core.Entity;
using HuluMoviesAndTVParse.Dtos;

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
                Type = new ProgramType { Name = x.Type },
                Year = new ReleaseYear { Year = x.ReleaseYear },
                Country = new List<Country>(),
                Listened = new List<Listened>()
            };
            if (x.CountryParsed.Length > 0)
                foreach (var t in x.CountryParsed)
                    movieAndShow.Country.Add(ctx.Countries.Distinct().First(x => x.Name == t));

            if (x.ListedInParsed.Length > 0)
                foreach (var t in x.ListedInParsed)
                    movieAndShow.Listened.Add(ctx.Listeneds.Distinct().First(x => x.Name == t));

            if (!string.IsNullOrEmpty(x.Director))
            {
                var director = ctx.Directors.Distinct().FirstOrDefault(d => d.Name == x.Director.Trim());
                if (director == null)
                {
                    director = new Director { Name = x.Director };
                    ctx.Directors.Add(director);
                }
                movieAndShow.Director = director;
            }

            if (!string.IsNullOrEmpty(x.Rating))
            {
                var rating = ctx.Ratings.Distinct().FirstOrDefault(r => r.Name == x.Rating.Trim());
                if (rating == null)
                {
                    rating = new Rating { Name = x.Rating };
                    ctx.Ratings.Add(rating);
                }
                movieAndShow.Rating = rating;
            }

            ctx.SaveChanges();

            MovieAndShows.Add(movieAndShow);
        }

        ctx.MovieAndShows.AddRange(MovieAndShows);
        ctx.SaveChanges();

        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- MovieAndShows ADDED --");
    }
}
