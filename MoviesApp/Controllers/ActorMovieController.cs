using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using MoviesApp.Services;
using MoviesApp.Services.Dto;
using MoviesApp.ViewModels;

namespace MoviesApp.Controllers
{
    public class ActorMovieController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly IActorMovieService _service;

        public ActorMovieController(ILogger<HomeController> logger, IMapper mapper, IActorMovieService service)
        {
            _logger = logger;
            _mapper = mapper;
            _service = service;
        }

        // GET: Actors
        [HttpGet]
        public IActionResult Index()
        {
            var actorMovies = _mapper.Map<IEnumerable<ActorMovieDto>, IEnumerable<ActorMovieViewModel>>(_service.GetAllActorMovies());
            return View(actorMovies);
        }
    }
}