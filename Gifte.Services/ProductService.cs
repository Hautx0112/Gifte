using Gifte.Repositories;
using Gifte.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifte.Services
{
    public interface IProductService
    {   
        Task<List<Product>> GetAll();
        Task <Product> GetById(int id);
    }

    public class ProductService : IProductService
    {
        private ProductRepository _repository;

        public ProductService() => _repository = new ProductRepository();
        public async Task<List<Product>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _repository.GetById(id);
        }
    }
}
