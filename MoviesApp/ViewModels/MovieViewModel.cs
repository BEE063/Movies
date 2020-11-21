using MoviesApp.Models;
using System;

namespace MoviesApp.ViewModels
{
    public class MovieViewModel:InputMovieViewModel
    {
        public int Id { get; set; }
        public Actor Actor { get; set; }
    }
}