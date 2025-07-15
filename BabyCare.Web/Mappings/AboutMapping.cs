using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.AboutDto;
using BabyCare.Web.Dtos.BannerDto;

namespace BabyCare.Web.Mappings
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateBannerDto , Banner>().ReverseMap();
        }
    }
}
