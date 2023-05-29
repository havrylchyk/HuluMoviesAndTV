
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
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- Countries ADDED --");

        //        ctx.Genres.AddRange(teams.Distinct().Select(x => new Genre
        //        {
        //            Title = x
        //        }));
        //        var games = new List<Game>();

        //        foreach (var x in records)
        //        {
        //            var game = new Game
        //            {
        //                NumberOfReviews = ParseNumbersWithLetters(x.NumberOfReviews),
        //                Plays = ParseNumbersWithLetters(x.Plays),
        //                Rating = x.Rating,
        //                ReleaseDate = x.RealeaseDate,
        //                Reviews = new List<Review>() { new Review { Text = x.Reviews } },
        //                Summary = x.Summary,
        //                TimesListed = ParseNumbersWithLetters(x.TimesListed),
        //                Wishlist = ParseNumbersWithLetters(x.Wishlist),
        //                Title = x.Title
        //            };

        //            if (x.TeamsParsed.Length > 0)
        //                foreach (var t in x.TeamsParsed)
        //                    game.Teams.Add(ctx.Teams.First(x => x.Title == t));

        //            if (x.GenresParsed.Length > 0)
        //                foreach (var t in x.GenresParsed)
        //                    game.Genre.Add(ctx.Genres.First(x => x.Title == t));

        //            games.Add(game);
        //        }
        //        ctx.Games.AddRange(games);
        //        ctx.SaveChanges();
        //        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- GAMES ADDED --");
        //    }
    }
}

//static int ParseNumbersWithLetters(string textNumber)
//{
//    if (string.IsNullOrEmpty(textNumber)) return 0;

//    double num; //5.5K // 985

//    if (!double.TryParse(textNumber, out num))
//    {
//        textNumber = textNumber.ToUpper().Trim().TrimEnd('K');
//        num = double.Parse(textNumber) * 1000;
//    }

//    return (int)num;
//}