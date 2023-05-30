namespace HuluMoviesAndTV.Core.Entity
{
    public class MovieAndShow : BaseEntity
    {
        public string Title { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        public Guid TypeId { get; set; }
        public virtual ProgramType Type { get; set; }

        public Guid YearId { get; set; }
        public virtual ReleaseYear Year { get; set; }

        public Guid? DirectorId { get; set; }
        public virtual Director? Director { get; set; }

        public Guid? RatingId { get; set; }
        public virtual Rating? Rating { get; set; }

        public virtual ICollection<Country>? Country { get; set; }

        public virtual ICollection<Listened>? Listened { get; set; }
    }
}
