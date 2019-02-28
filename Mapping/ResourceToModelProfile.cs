using AutoMapper;
using CRUD_Angular.Domain.Models;
using CRUD_Angular.Resources;

namespace CRUD_Angular.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
