using CRUD_Angular.Domain.Models;
using CRUD_Angular.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Angular.Domain.Services
{
    public interface ICategoryService
    {
        /*Le implementazioni del metodo ListAsync devono restituire
         * in modo asincrono un'enumerazione di categorie*/

        //CRUD collegato con CategoriesController
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
        Task<SaveCategoryResponse> DeleteAsync(int id);
    }
}
