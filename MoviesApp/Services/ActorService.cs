using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Filters;
using MoviesApp.Models;
using MoviesApp.Services.Dto;
using MoviesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public class ActorService : IActorService
    {
        private readonly MoviesContext _context;
        private readonly IMapper _mapper;

        public ActorService(MoviesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ActorDto AddActor(ActorDto actorDto)
        {
            var actor = _context.Add(_mapper.Map<Actor>(actorDto)).Entity;
            _context.SaveChanges();
            return _mapper.Map<ActorDto>(actor);
        }

        public ActorDto DeleteActor(int id)
        {
            var actor = _context.Actors.Find(id);
            if (actor == null)
            {
                return null;
            }

            _context.Actors.Remove(actor);
            _context.SaveChanges();

            return _mapper.Map<ActorDto>(actor);
        }

        public IEnumerable<ActorDto> GetAllActors()
        {
            return _mapper.Map<IEnumerable<Actor>, IEnumerable<ActorDto>>(_context.Actors.Include(a => a.ActorMovies).ThenInclude(am => am.Movie).ToList());
        }

        public ActorDto GetActor(int id)
        {
            return _mapper.Map<ActorDto>(_context.Actors.Include(a => a.ActorMovies).ThenInclude(am => am.Movie).FirstOrDefault(a => a.Id == id));
        }

        public ActorDto UpdateActor(ActorDto actorDto)
        {
            if (actorDto.Id == null)
            {
 
                return null;
            }

            try
            {
                var actor = _mapper.Map<Actor>(actorDto);

                _context.Update(actor);
                _context.SaveChanges();

                return _mapper.Map<ActorDto>(actor);
            }
            catch (DbUpdateException)
            {
                if (!ActorExists((int)actorDto.Id))
                {
                    return null;
                }
                else
                {
             
                    return null;
                }
            }
        }
        private bool ActorExists(int id)
        {
            return _context.Actors.Any(a => a.Id == id);
        }
    }
}
