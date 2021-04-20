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
    public class CategoryRepo : BaseRepo, IRepository<Category>
    {
        public CategoryRepo(WebApplicationDbContext context)
            :base(context)
        {
        }

        public async Task Create(Category entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public Task<List<Category>> GetAll()
        {
            return _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Update(Category entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
