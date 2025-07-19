using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ContactId { get; set; }
        public string Adress { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string MapUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
