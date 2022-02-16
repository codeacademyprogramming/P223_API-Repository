using Microsoft.EntityFrameworkCore;
using ShopApiP223.Data.DAL;
using ShopApiP223.Data.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopApiP223.Repositories
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private readonly ShopDbContext _context;

        public ProductRepository(ShopDbContext context):base(context)
        {
            _context = context;
        }
    }
}
