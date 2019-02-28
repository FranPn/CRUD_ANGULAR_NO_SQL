using System.Threading.Tasks;

/*Il Repository e Unit of Work hanno lo scopo di creare un 
 * livello di astrazione tra il livello di accesso ai dati 
 * e il livello della logica aziendale di un'applicazione. 
 * L'implementazione di questi modelli può aiutare a isolare 
 * l'applicazione dai cambiamenti nell'archivio dati e può 
 * facilitare il test dell'unità automatizzata o 
 * lo sviluppo basato sui test (TDD).*/

namespace CRUD_Angular.Domain.Repositories
{
    /* Unit of Work Pattern: questo modello è costituito da una classe che riceve 
     * l'istanza AppDbContext come dipendenza e espone i metodi per avviare, 
     * completare o interrompere le transazioni. */
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
