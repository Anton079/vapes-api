using AutoMapper;
using vapes_api.Vapes.Dtos;
using vapes_api.Vapes.Models;

namespace vapes_api.Vapes.Mapper
{
    public class VapesMappingProfile:Profile
    {
        public VapesMappingProfile()
        {
            CreateMap<VapeRequest, Vape>();
            CreateMap<Vape, VapeResponse>();
        }
    }
}
