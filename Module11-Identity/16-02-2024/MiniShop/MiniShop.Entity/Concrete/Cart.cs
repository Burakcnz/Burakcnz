using MiniShop.Entity.Abstract;
using MiniShop.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity.Concrete
{
    public class Cart:IMainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UserId { get; set; }
        public User? User { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
