using System.ComponentModel.DataAnnotations;

namespace CRUD_Angular.Resources
{
    public class SaveCategoryResource
    {
        /* Gli attributi [Required] e [MaxLength(30)] sono chiamati data annotation.
         * I .NET Core pipeline usano questi metadati per validare richeste e risposte */
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
