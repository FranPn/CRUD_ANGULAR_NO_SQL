using CRUD_Angular.Domain.Models;
using CRUD_Angular.Domain.Repositories;
using CRUD_Angular.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Angular.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        //Get
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        //Post
        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<Category> FindByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        //Pull
        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }

        //Delete
        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
        }
    }
}
