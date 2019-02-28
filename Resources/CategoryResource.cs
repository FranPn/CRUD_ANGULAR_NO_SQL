using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Angular.Resources
{
    public class CategoryResource
    {
        //Abbiamo bisogno di una risorsa per rappresentare solo le nostre categorie, senza i prodotti.
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
