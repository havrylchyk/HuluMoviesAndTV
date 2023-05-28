namespace HuluMoviesAndTV.Core.Entity
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}