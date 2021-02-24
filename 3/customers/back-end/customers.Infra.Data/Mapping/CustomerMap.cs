using customers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace customers.Infra.Data.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired();

            builder.Property(prop => prop.BirthDate)
                .IsRequired();

            builder.Property(prop => prop.Email)
                .IsRequired();
        }
    }
}
