using AutoMapper;
using customers.Domain.DTOs;
using customers.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace customers.Infra.CrossCutting.AutoMapper
{
    public static class AutoMapperCustomer
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CreateCustomerDTO, Customer>();
                config.CreateMap<UpdateCustomerDTO, Customer>();
                config.CreateMap<Customer, CustomerDTO>();
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
