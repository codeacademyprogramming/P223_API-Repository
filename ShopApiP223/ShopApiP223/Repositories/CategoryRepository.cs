using Microsoft.EntityFrameworkCore;
using ShopApiP223.Data.DAL;
using ShopApiP223.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopApiP223.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private readonly ShopDbContext _context;

        public CategoryRepository(ShopDbContext context ):base(context)
        {
            _context = context;
        }

    }
}
