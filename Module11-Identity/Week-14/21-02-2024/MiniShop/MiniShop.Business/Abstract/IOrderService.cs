using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IOrderService
    {
        Task CreateAsync(Order order);
        Task<Order> GetOrderAsync(int orderId);
        Task<List<Order>> GetAllOrdersAsync(string? userId = null);
    }
}
