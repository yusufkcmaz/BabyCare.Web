using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Subscribe
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubcribeId { get; set; }
        public string Email { get; set; }
    }
}
