using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Dtos.InstructorDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCare.Web.Services.InstructorServices
{
    public class InstructorService : IInstructorService
    {
        private readonly IMongoCollection<Instructor>  _mongoCollection;
        private readonly IMapper _mapper;

        public InstructorService(IDataBaseSettings dataBaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client = new MongoClient(dataBaseSettings.ConnectionString);
            var databasee = client.GetDatabase(dataBaseSettings.DatabaseName);
            _mongoCollection = databasee.GetCollection<Instructor>(dataBaseSettings.InstructorCollectionName);
        }

        public async Task CreateInstructorAsync(CreateInstructorDto createInstructor)
        {
            var instructor = _mapper.Map<Instructor>(createInstructor);
            await _mongoCollection.InsertOneAsync(instructor);
        }

        public async Task DeleteInstructorAsync(string id)
        {
            await _mongoCollection.DeleteOneAsync(x=> x.InstructorId == id);
        }

        public async Task<List<ResultInstructorDto>> GetAllInstructorAsync()
        {
            var values = await _mongoCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultInstructorDto>> (values);
        }

        public async Task<UpdateInstructorDto> GetInstructorByIdAsync(string id)
        {
            var instructor = await _mongoCollection.Find(x=> x.InstructorId == id).FirstOrDefaultAsync();
            
            var dto= _mapper.Map<UpdateInstructorDto>(instructor);
            return dto;

        }

        public async Task UpdateInstructorAsync(UpdateInstructorDto updateInstructor)
        {
            var ınstructor = _mapper.Map<Instructor> (updateInstructor);
            await _mongoCollection.FindOneAndReplaceAsync(x => x.InstructorId == ınstructor.InstructorId, ınstructor);
        }
    }
}
