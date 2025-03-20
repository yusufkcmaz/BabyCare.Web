using BabyCare.Web.Dtos.InstructorDtos;

namespace BabyCare.Web.Services.InstructorServices
{
    public interface IInstructorService
    {
        Task<List<ResultInstructorDto>> GetAllInstructorAsync();
        Task<UpdateInstructorDto> GetInstructorByIdAsync(string id);
        Task CreateInstructorAsync(CreateInstructorDto createInstructor);
        Task UpdateInstructorAsync(UpdateInstructorDto updateInstructor);
        Task DeleteInstructorAsync(string id);
    } 
}
