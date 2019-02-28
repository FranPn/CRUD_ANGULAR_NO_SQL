using System.Threading.Tasks;
using CRUD_Angular.Domain.Repositories;
using CRUD_Angular.Persistence.Contexts;

namespace CRUD_Angular.Persistence.Repositories
{
    /* Poiché EF Core implementa già il Repository Model e Unit Of Work 
     * dietro le quinte, non ci dobbiamo preoccupare di un metodo di rollback. */
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
