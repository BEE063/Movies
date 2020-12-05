using AutoMapper;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.ViewModels.AutoMapperProfiles
{
    public class ActorMovieProfile: Profile
    {
        public ActorMovieProfile()
        {
            CreateMap<ActorMovie, ActorMovieViewModel>();
        }
    }
}
