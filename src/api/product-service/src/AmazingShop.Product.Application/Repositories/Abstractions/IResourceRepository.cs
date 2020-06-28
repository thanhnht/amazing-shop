using System.Linq;

namespace AmazingShop.Product.Application.Repository.Abstraction
{
    public interface IResourceRepository
    {
        IQueryable<Domain.Entity.Resource> Resources { get; }
    }
}