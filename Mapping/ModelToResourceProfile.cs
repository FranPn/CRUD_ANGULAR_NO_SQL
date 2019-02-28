using AutoMapper;
using CRUD_Angular.Domain.Models;
using CRUD_Angular.Resources;
using CRUD_Angular.Extensions;

namespace CRUD_Angular.Mapping
{
    /*La classe Profile è un tipo di classe che AutoMapper 
     * utilizza per verificare come funzioneranno le nostre mappature.*/
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            /* Nel costruttore, creiamo una mappa tra la classe del modello Categoria e la classe CategoryResource. 
             * Poiché le proprietà delle classi hanno gli stessi nomi e tipi, 
             * non dobbiamo usare alcuna configurazione speciale per loro.*/
            
            //Category
            CreateMap<Category, CategoryResource>();

            //Product
            //ToDescription --> API Reflection 
            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
