using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class ActorMovie
    {
        [ForeignKey("Actors")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        [ForeignKey("Movies")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
