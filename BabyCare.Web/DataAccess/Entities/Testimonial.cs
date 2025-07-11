using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string HeadName  { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public int Stars { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
