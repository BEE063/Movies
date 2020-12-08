using AutoMapper;
using MoviesApp.Models;
using MoviesApp.Services.Dto;
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
            CreateMap<ActorMovieDto, ActorMovieViewModel>();
        }
    }
}
