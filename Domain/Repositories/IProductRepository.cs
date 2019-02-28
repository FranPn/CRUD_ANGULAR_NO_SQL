using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_Angular.Domain.Models;

namespace CRUD_Angular.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
