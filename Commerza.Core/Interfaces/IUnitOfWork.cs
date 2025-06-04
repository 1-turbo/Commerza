namespace Commerza.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public ICategoryRepositry CategoryRepositry { get; }
        public IProductRepositry ProductRepositry { get; }
        public IPhotoRepositry PhotoRepositry { get; }
    }
}
