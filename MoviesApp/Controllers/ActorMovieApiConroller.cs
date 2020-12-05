using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;
using MoviesApp.ViewModels;

namespace MoviesApp.Controllers
{
    [Route("api/actormovies")]
    [ApiController]
    public class ActorMovieApiController : ControllerBase
    {
        private readonly MoviesContext _context;
        private readonly IMapper _mapper;

        public ActorMovieApiController(MoviesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet] // GET: /api/actormovies
        [ProducesResponseType(200, Type = typeof(IEnumerable<ActorMovieViewModel>))]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<ActorMovieViewModel>> GetActorMovies()
        {
            var actorMovies = _mapper.Map<IEnumerable<ActorMovie>, IEnumerable<ActorMovieViewModel>>(_context.ActorMovies.ToList());
            return Ok(actorMovies);
        }
        [HttpGet("{id}")] // GET: /api/actors/5
        [ProducesResponseType(200, Type = typeof(ActorMovieViewModel))]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var actorMovie = _mapper.Map<ActorMovieViewModel>(_context.ActorMovies.FirstOrDefault(am => am.ActorId == id));
            if (actorMovie == null) return NotFound();
            return Ok(actorMovie);
        }
    }
}
