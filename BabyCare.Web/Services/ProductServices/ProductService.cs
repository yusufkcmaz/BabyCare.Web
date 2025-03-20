﻿using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Dtos.ProductDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCare.Web.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IMapper mapper , IDataBaseSettings dataBaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(dataBaseSettings.ConnectionString);
            var database = client.GetDatabase(dataBaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(dataBaseSettings.ProductCollectionName);


        }


        public async Task CreateAsync(CreateProductDto createProductDto)
        {
           var product = _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(product);
        }

        public async Task DeleteAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductId == id);

        }

        public async Task<List<ResultProductDto>> GetAllAsync()
        {
           var values = await _productCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<UpdateProductDto> GetById(string id)
        {
           var value  = await _productCollection.Find(x => x.ProductId == id).FirstOrDefaultAsync();
           return _mapper.Map<UpdateProductDto>(value);
           
        }

        public async Task UpdateAsync(UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == product.ProductId, product);
        }
    }
}
