using CsvHelper.Configuration.Attributes;

namespace HuluMoviesAndTVParse.Dtos
{
    public class MoviesAndTVShowsReadDto
    {							
        [Name("type")]
        public string Type { get; set; }

        [Name("title")]
        public string Title { get; set; }

        [Name("director")]
        public string? Director { get; set; }

        [Name("country")]
        public string? Country { get; set; }

        [Index(4)]
        [Name("release_year")]
        public int ReleaseYear { get; set; }

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
            return $"{Type} | {Title} | {Director} | {string.Join("--", CountryParsed)} | {ReleaseYear} | " +
                $"{Rating} | {Duration} | {string.Join("--", ListedInParsed)} | {Description}";
        }

        public string[] CountryParsed
        {
            get
            {
                if (!string.IsNullOrEmpty(Country))
                {
                    return Country.Trim().Split(',').Select(c => c.Trim()).ToArray();
                }
                else
                {
                    return new string[0]; 
                }
            }
        }

        public string[] ListedInParsed
        {
            get
            {
                if (!string.IsNullOrEmpty(ListedIn))
                {
                    return ListedIn.Split(',').Select(c => c.Trim()).ToArray();
                }
                else
                {
                    return new string[0];
                }
            }
        }
    }
}
