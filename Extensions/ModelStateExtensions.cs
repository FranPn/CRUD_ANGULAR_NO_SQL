using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CRUD_Angular.Extensions
{
    /* Metodo che estende le funzionalità di una classe o interfaccia già esistente 
     * che implementa la conversione degli errori di convalida in stringhe 
     * semplici da restituire al client. */

    /* Tutti i metodi di estensione dovrebbero essere statici, 
     * così come le classi in cui sono dichiarati. 
     * Significa che non gestiscono dati di istanza specifici e che vengono caricati 
     * una sola volta all'avvio dell'applicazione. */
    public static class ModelStateExtensions
    {
        public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
        {
            return dictionary.SelectMany(m => m.Value.Errors)
                             .Select(m => m.ErrorMessage)
                             .ToList();
        }
    }
}
