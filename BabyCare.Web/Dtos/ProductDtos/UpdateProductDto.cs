namespace BabyCare.Web.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string ProductId { get; set; } // FIELD (SQL'de PRIMARY KEY gibi)
        public string Title { get; set; }  // FIELD
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string InstructorName { get; set; }
        public string InstructorImage { get; set; }
    }
}
