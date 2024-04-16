using AutoMapper;
using VWMS.SkyStatus.API.Entities;
using VWMS.SkyStatus.API.Models;

namespace VWMS.SkyStatus.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StatusMessageDto, StatusMessage>().ReverseMap();
            CreateMap<MessageDto, Message>().ReverseMap();
            CreateMap<ReferenceDto, Reference>().ReverseMap();
        }
    }
}
