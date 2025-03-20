using BabyCare.Web.Dtos.ProductDtos;

namespace BabyCare.Web.Services.ProductServices

{
    public interface IProductService
    {
        Task<List<ResultProductDto>>GetAllAsync();
        Task<UpdateProductDto>GetById(string id);
        Task CreateAsync(CreateProductDto createProductDto);
        Task UpdateAsync(UpdateProductDto updateProductDto);
        Task DeleteAsync(string id);
    }
}
