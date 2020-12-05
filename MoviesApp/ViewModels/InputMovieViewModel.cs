using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.ViewModels
{
    public class InputMovieViewModel
    {
        [Required]
        [StringLength(32, ErrorMessage = "Title length can't be more than 32.")]
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public string Genre { get; set; }

        [Required]
        [Range(0, 999.99)]
        public decimal Price { get; set; }

        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}