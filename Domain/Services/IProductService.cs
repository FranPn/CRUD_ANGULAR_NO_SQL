using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_Angular.Domain.Models;

namespace CRUD_Angular.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
