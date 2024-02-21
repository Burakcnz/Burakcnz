﻿using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class CartRepository:GenericRepository<Cart>,ICartRepository
    {
        public CartRepository(MiniShopDbContext _context):base(_context)
        {
            
        }
        MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
    }
}
