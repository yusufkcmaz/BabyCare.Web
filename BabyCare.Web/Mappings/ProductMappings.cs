using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.ProductDtos;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace BabyCare.Web.Mappings
{
    public class ProductMappings:Profile
    {
        public ProductMappings()
        {
            CreateMap<Product , ResultProductDto>().ReverseMap();
            CreateMap<Product , UpdateProductDto>().ReverseMap();
            CreateMap<Product , CreateProductDto>().ReverseMap();
        }
    }
}
