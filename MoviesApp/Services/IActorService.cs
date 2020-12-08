using MoviesApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public interface IActorService
    {
        ActorDto GetActor(int id);
        IEnumerable<ActorDto> GetAllActors();
        ActorDto UpdateActor(ActorDto actorDto);
        ActorDto AddActor(ActorDto actorDto);
        ActorDto DeleteActor(int id);
    }
}
