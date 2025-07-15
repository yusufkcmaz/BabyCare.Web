namespace BabyCare.Web.Services.GenericService
{
    public interface IGenericService<T>  where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity);
        Task UpdateAsync(string id, T entity);
        Task DeleteAsync(string id);
    }
}
//Await: İşlem tamamlana kadar beklemek.
//Task: Veri döndürmez.