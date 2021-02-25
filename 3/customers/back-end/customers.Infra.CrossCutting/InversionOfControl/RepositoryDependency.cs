using customers.Domain.Interfaces;
using customers.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace customers.Infra.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryCustomer, CustomerRepository>();
        }
    }
}
