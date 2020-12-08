using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services.Dto
{
    public class ActorDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "Name length can't be less than 4.", MinimumLength = 4)]
        public string Name { get; set; }
        [Required]
        [StringLength(32, ErrorMessage = "Surname length can't be less than 4.", MinimumLength = 4)]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}

