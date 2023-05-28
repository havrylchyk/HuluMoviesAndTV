namespace HuluMoviesAndTV.Core.Entity
{
    public class MovieAndShow : BaseEntity
    {
        public Guid TypeId { get; set; }
        public ProgramType Type { get; set; }

        public Guid YearId { get; set; }
        public ReleaseYear Year { get; set; }

        public Guid? DirectorId { get; set; }
        public Director? Director { get; set; }

        public Guid? RatingId { get; set; }
        public Rating? Rating { get; set; }

        public ICollection<Country>? Country { get; set; }

        public ICollection<Listened> Listened { get; set; }

        public string Title { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }
    }
}
