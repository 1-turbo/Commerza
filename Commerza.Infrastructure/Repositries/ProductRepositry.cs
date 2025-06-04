using Commerza.Core.Entities.Product;
using Commerza.Core.Interfaces;
using Commerza.Infrastructure.Data;

namespace Commerza.Infrastructure.Repositries
{
    public class ProductRepositry : GeneticRepositry<Product>, IProductRepositry
    {
        public ProductRepositry(AppDbContext context) : base(context)
        {
        }
    }
}
