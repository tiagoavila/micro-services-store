using Catalog.Domain;
using Catalog.Domain.Interfaces;
using Catalog.Infra.Context;

namespace Catalog.Infra.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CatalogContext context)
            : base(context)
        {

        }
    }
}
