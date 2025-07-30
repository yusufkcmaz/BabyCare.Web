using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.LayoutInfoDtos;

namespace BabyCare.Web.Mappings
{
    public class LayoutInfoMappings : Profile   
    {
        public LayoutInfoMappings()
        {
            CreateMap<ResultLayoutInfoDto , LayoutInfo>().ReverseMap();
            CreateMap<CreateLayouInfoDto , LayoutInfo>().ReverseMap();
            CreateMap<UpdateLayoutInfoDto , LayoutInfo>().ReverseMap();

        }
    }
}
