using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.EventDtos;

namespace BabyCare.Web.Mappings
{
    public class EventMappings: Profile
    {
        public EventMappings()
        {
            CreateMap<ResultEventDto , Event>().ReverseMap();
            CreateMap<CreateEventDto , Event>().ReverseMap();
            CreateMap<UpdateEventDto , Event>().ReverseMap();
        }
    }
}
