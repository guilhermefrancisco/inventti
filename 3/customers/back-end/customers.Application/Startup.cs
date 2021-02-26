using customers.Domain.Validators;
using customers.Infra.CrossCutting.AutoMapper;
using customers.Infra.CrossCutting.InversionOfControl;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace customers.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssembly(typeof(CreateCustomerCommandValidator).Assembly);
            });

            services.AddContextDependency();
            services.AddRepositoryDependency();
            services.AddServiceDependency();
            services.AddAutoMapperCustomer();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
