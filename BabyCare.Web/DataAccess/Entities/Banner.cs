using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Banner
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BannerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
