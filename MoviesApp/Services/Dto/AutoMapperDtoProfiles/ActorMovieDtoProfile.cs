using AutoMapper;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services.Dto.AutoMapperDtoProfiles
{
    public class ActorMovieDtoProfile: Profile
    {
        public ActorMovieDtoProfile()
        {
            CreateMap<ActorMovie, ActorMovieDto>().ReverseMap();
        }
    }
}
