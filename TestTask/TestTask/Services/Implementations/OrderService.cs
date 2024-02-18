using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Migrations;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementations
{
    public class OrderService : BaseDBService, IOrderService //Added implementation for IOrderService, and add Base class for all DataBase services
    {
        public Task<Order> GetOrder()
        {
            var order = from orders in _dbContext.Orders
                        orderby orders.Price descending
                        select orders;
            return order.FirstAsync();
        }

        public Task<List<Order>> GetOrders()
        {
            var order = from orders in _dbContext.Orders
                        where orders.Quantity > 10
                        select orders;
            return order.ToListAsync();
        }
    }
}
