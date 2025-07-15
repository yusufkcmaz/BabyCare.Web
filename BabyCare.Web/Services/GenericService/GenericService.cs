using BabyCare.Web.DataAccess.Settings;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BabyCare.Web.Services.GenericService
{
    public class GenericService<T> : IGenericService<T> where T : class
    {


        private readonly IMongoCollection<T> _collection;
        //MongoDb bağlantısı koleksiyonu seçme.
        public GenericService(IDataBaseSettings settings, string collectionName)
        {
            //MongoDb istemici .
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<T>(collectionName);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(string id, T entity)
        {
            var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
            await _collection.ReplaceOneAsync(filter, entity);
        }

        public async Task DeleteAsync(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
            await _collection.DeleteOneAsync(filter);
        }
    }

}

