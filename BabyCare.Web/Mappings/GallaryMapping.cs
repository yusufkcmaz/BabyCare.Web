using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.GallaryDtos;

namespace BabyCare.Web.Mappings
{
    public class GallaryMapping : Profile
    {
        public GallaryMapping()
        {
            CreateMap<ResultGallaryDto, Gallary>().ReverseMap();
            CreateMap<CreateGallaryDto ,  Gallary>().ReverseMap();
            CreateMap<UpdateGallaryDto, Gallary>().ReverseMap();

        }
    }
}
