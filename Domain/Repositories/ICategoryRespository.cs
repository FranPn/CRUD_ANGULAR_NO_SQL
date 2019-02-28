using CRUD_Angular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Angular.Domain.Repositories
{
    public interface ICategoryRepository
    {
        /* Pattern di repository che viene utilizzato per gestire i dati dai database.
         * Quando si utilizza il pattern di repository, definiamo le classi di repository , 
         * che sostanzialmente incapsulano tutte le logiche per gestire l'accesso ai dati. 
         * Questi repository espongono i metodi per elencare, creare, modificare ed eliminare oggetti 
         * di un determinato modello, allo stesso modo in cui puoi manipolare le raccolte. */
        //Get
        Task<IEnumerable<Category>> ListAsync();
        //Push
        Task AddAsync(Category category);
        //Pull
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
        //Delete
        void Remove(Category category);
    }
}
