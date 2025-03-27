using Gifte.Repositories;
using Gifte.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifte.Services
{
    public interface IOrderService
    {   
        Task<List<Order>> GetAll();
        Task <Order> GetById(int id);
        Task<int> Create(Order order);
    }

    public class OrderService : IOrderService
    {
        private OrderRepository _repository;

        public OrderService() => _repository = new OrderRepository();
        
        public async Task<List<Order>> GetAll()
        {
            return await _repository.GetAllOrderAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _repository.GetOrderById(id);
        }

        public async Task<int> Create(Order order)
        {
            return await _repository.CreateAsync(order);
        }
    }
}
