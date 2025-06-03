using Commerza.Core.Entities.Product;
using Commerza.Core.Interfaces;
using Commerza.Infrastructure.Data;

namespace Commerza.Infrastructure.Repositries
{
    public class CategoryRepositry : GeneticRepositry<Category>, ICategoryRepositry
    {
        public CategoryRepositry(AppDbContext context) : base(context)
        {
        }
    }
}
