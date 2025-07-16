using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.ContactDtos;

namespace BabyCare.Web.Mappings
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<ResultContactDto , Contact>().ReverseMap();
            CreateMap<UpdateContactDto , Contact>().ReverseMap();
            CreateMap<CreateContactDto , Contact>().ReverseMap();
        }
    }
}
