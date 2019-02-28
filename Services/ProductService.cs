using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_Angular.Domain.Models;
using CRUD_Angular.Domain.Repositories;
using CRUD_Angular.Domain.Services;

namespace CRUD_Angular.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
