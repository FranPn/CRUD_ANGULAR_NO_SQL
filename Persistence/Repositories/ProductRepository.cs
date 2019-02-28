using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Angular.Domain.Models;
using CRUD_Angular.Domain.Repositories;
using CRUD_Angular.Persistence.Contexts;

namespace CRUD_Angular.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            /* la chiamata a Include (p => p.Categoria). Si può concatenare questa sintassi 
             * per includere tutte le entità necessarie quando si interrogano i dati. 
             * EF Core lo tradurrà in un join quando si esegue la selezione. */
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
