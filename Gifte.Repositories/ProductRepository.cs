using Gifte.Repositories.Base;
using Gifte.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifte.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository() { }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
