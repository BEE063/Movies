using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;
using MoviesApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public class ActorMovieService : IActorMovieService
    {
        private readonly MoviesContext _context;
        private readonly IMapper _mapper;
        public ActorMovieService(MoviesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ActorMovieDto GetActorMovie(int id)
        {
            return _mapper.Map<ActorMovieDto>(_context.ActorMovies.Include(am => am.Actor).Include(am => am.Movie).FirstOrDefault(a => a.ActorId == id));
        }

        public IEnumerable<ActorMovieDto> GetAllActorMovies()
        {
            return _mapper.Map<IEnumerable<ActorMovie>, IEnumerable<ActorMovieDto>>(_context.ActorMovies.Include(am => am.Actor).Include(am => am.Movie).ToList());
        }
    }
}
