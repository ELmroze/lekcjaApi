using AutoMapper;
using lekcjaApi.Dto;
using lekcjaApi.Entities;

namespace lekcjaApi.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Pet, PetDto>();
            CreateMap<Shelter,ShelterDto>();
        }
    }
}
