namespace HuluMoviesAndTV.Core.Entity
{
    public class Listened : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}