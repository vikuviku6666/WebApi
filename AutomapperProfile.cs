using AutoMapper;
using WebApi.Dtos.Character;
using WebApi.Models;

namespace WebApi
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
        
    }
}