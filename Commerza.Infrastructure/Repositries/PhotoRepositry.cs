using Commerza.Core.Entities.Product;
using Commerza.Core.Interfaces;
using Commerza.Infrastructure.Data;

namespace Commerza.Infrastructure.Repositries
{
    public class PhotoRepositry : GeneticRepositry<Photo>, IPhotoRepositry
    {
        public PhotoRepositry(AppDbContext context) : base(context)
        {
        }
    }
}
