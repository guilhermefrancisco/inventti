using customers.Domain.Interfaces;
using customers.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace customers.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceCustomer, CustomerService>();
        }
    }
}
