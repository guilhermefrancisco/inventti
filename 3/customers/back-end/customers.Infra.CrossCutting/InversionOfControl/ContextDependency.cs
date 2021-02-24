using customers.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace customers.Infra.CrossCutting.InversionOfControl
{
    public static class ContextDependency
    {
        public static void AddContextDependency(this IServiceCollection services)
        {
            services.AddDbContext<CustomersContext>(options =>
            {
                options.UseInMemoryDatabase(databaseName: "inventtiDB");
            });
        }
    }
}
