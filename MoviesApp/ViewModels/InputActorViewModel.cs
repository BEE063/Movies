using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.ViewModels
{
    public class InputActorViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<ActorMovie> Movies { get; set; }
    }
}
