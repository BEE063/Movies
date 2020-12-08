using MoviesApp.Models;
using AutoMapper;
using MoviesApp.Services.Dto;

namespace MoviesApp.ViewModels.AutoMapperProfiles
{
    public class ActorProfile : Profile
    {
        public ActorProfile()
        {
            CreateMap<ActorDto, InputActorViewModel>().ReverseMap();
            CreateMap<ActorDto, DeleteActorViewModel>();
            CreateMap<ActorDto, EditActorViewModel>().ReverseMap();
            CreateMap<ActorDto, ActorViewModel>();
        }
    }
}
