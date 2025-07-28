using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.TestimonialDtos;

namespace BabyCare.Web.Mappings
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<ResultTestimonialDto , Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto , Testimonial>().ReverseMap();
            CreateMap<CreateTestimonialDto , Testimonial>().ReverseMap();

        }
    }
}
