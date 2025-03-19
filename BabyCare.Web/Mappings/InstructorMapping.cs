using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.InstructorDtos;

namespace BabyCare.Web.Mappings
{
    public class InstructorMapping : Profile
    {
        public InstructorMapping()
        {
            CreateMap<ResultInstructorDto , Instructor>().ReverseMap();
            CreateMap<CreateInstructorDto , Instructor>().ReverseMap();
            CreateMap<UpdateInstructorDto , Instructor>().ReverseMap();
        }
    }
}
