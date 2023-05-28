using CsvHelper.Configuration.Attributes;
using System.Text.Json;

namespace HuluMoviesAndTVParse.Dtos
{
    public class MoviesAndTVShowsReadDto
    {
        //								
        [Name("type")]
        public string Type { get; set; }

        [Name("title")]
        public string Title { get; set; }

        [Name("director")]
        public string? Director { get; set; }

        [Name("country")]
        public string? Country { get; set; }

        [Name("release_year")]
        public string ReleaseYear { get; set; }

        [Name("rating")]
        public string? Rating { get; set; }

        [Name("duration")]
        public string? Duration { get; set; }

        [Name("listed_in")]
        public string ListedIn { get; set; }

        [Name("description")]
        public string Description { get; set; }


        public override string ToString()
        {
            return $"{Type} | {Title} | {Director} | {Country} | {ReleaseYear} | " +
                $"{Rating} | {Duration} | {ListedIn} | {Description}";
        }

        //public string[] CountryParsed
        //{return $"{Type} | {Title} | {Director} | {Country} | {ReleaseYear} | {Rating} | {Duration} | {ListedIn} | {Description}";
        //    get
        //    {
        //        return string.IsNullOrEmpty(Team)
        //            ? new string[0]
        //            : JsonSerializer.Deserialize<string[]>(Team.Replace("\'", "\""));
        //    }
        //}

        //public string Genres { get; set; }

        //public string[] GenresParsed
        //{
        //    get
        //    {
        //        return string.IsNullOrEmpty(Genres)
        //            ? new string[0]
        //            : JsonSerializer.Deserialize<string[]>(Genres.Replace("\'", "\""));
        //    }
        //}
    }
}
