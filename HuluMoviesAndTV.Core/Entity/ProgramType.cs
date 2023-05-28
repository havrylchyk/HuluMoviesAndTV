using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluMoviesAndTV.Core.Entity
{
    public class ProgramType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<MovieAndShow>? MovieAndShows { get; set; }
    }
}
