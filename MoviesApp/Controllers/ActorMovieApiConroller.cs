using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Services;
using MoviesApp.Services.Dto;

namespace MoviesApp.Controllers
{
    [Route("api/actormovies")]
    [ApiController]
    public class ActorMovieApiController : ControllerBase
    {
        private readonly IActorMovieService _service;

        public ActorMovieApiController(IActorMovieService service)
        {
            _service = service;
        }

        [HttpGet] // GET: /api/actormovies
        [ProducesResponseType(200, Type = typeof(IEnumerable<ActorMovieDto>))]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<ActorMovieDto>> GetActorMovies()
        {
            return Ok(_service.GetAllActorMovies());
        }

        [HttpGet("{id}")] // GET: /api/actormovies/5
        [ProducesResponseType(200, Type = typeof(ActorMovieDto))]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var actor = _service.GetActorMovie(id);
            if (actor == null) return NotFound();
            return Ok(actor);
        }
    }
}