using Commerza.Core.Interfaces;
using Commerza.Infrastructure.Repositries;
using Microsoft.Extensions.DependencyInjection;

namespace Commerza.Infrastructure
{
    public static class InfrastructureRegisteration
    {
        public static IServiceCollection infrastructureConfiguration(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IGeneticRepositry<>), typeof(GeneticRepositry<>));
            //services.AddScoped<ICategoryRepositry, CategoryRepositry>();
            //services.AddScoped<IProductRepositry, ProductRepositry>();
            //services.AddScoped<IPhotoRepositry, PhotoRepositry>();
            services.AddScoped<IUnitOfWork, UnitOfWork>(); 
            return services;
        }
    }
}
