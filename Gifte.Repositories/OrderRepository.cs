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
    public class OrderRepository : GenericRepository<Order>
    {
        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<List<Order>> GetAllOrderAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByUserId(int userId)
        {
            return await _context.Orders.Where(o => o.UserAccountId == userId).ToListAsync();
        }
    }
}
