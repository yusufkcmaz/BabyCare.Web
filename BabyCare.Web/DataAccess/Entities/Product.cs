using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Product //Collection(Tablo)
    { 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; } // FIELD (SQL'de PRIMARY KEY gibi)
        public string Title { get; set; }  // FIELD
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string InstructorName { get; set; }
    }
}
