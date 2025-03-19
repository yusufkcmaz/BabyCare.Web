using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.Dtos.InstructorDtos
{
    public class ResultInstructorDto
    {
        public class Instructor
        {
           
            public string InstructorId { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ImageUrl { get; set; }
            public string Title { get; set; }
        }
    }
}
