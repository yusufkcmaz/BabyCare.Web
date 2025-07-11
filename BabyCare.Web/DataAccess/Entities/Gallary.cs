using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Gallary
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string GallaryId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

    }
}
