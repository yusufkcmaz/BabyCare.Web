using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Services
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServicesId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Descripton { get; set; }
       
    }
}
