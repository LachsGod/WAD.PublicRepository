using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAD.WebApplication._7586.DAL;
using WAD.WebApplication._7586.DAL.DBO;

namespace WAD.WebApplication.DAL.Repository
{
    public class ProductRepo : BaseRepo, IRepository<Product>
    {
        public ProductRepo(WebApplicationDbContext context)
            :base(context)
        {
        }
        public async Task Create(Product entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products
            .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Update(Product entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
