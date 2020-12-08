using MoviesApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public interface IActorMovieService
    {
        ActorMovieDto GetActorMovie(int id);
        IEnumerable<ActorMovieDto> GetAllActorMovies();
    }
}
