using System.ComponentModel.DataAnnotations;

namespace HuluMoviesAndTV.Core.Entity
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
