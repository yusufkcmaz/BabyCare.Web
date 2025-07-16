using AutoMapper;
using BabyCare.Web.Dtos.ServicesDtos;

namespace BabyCare.Web.Mappings
{
    public class ServicesMapping : Profile
    {
        public ServicesMapping()
        {
           CreateMap<ResultServicesDto , BabyCare.Web.DataAccess.Entities.Services>().ReverseMap();
           CreateMap<CreateServicesDto , BabyCare.Web.DataAccess.Entities.Services>().ReverseMap();
           CreateMap<UpdateServicesDto , BabyCare.Web.DataAccess.Entities.Services>().ReverseMap();

        }
    }
}
