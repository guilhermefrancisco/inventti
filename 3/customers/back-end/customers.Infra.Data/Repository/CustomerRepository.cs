using customers.Domain.Entities;
using customers.Domain.Interfaces;
using customers.Infra.Data.Context;
using System.Collections.Generic;

namespace customers.Infra.Data.Repository
{
    public class CustomerRepository : BaseRepository<Customer, int>, IRepositoryCustomer
    {
        public CustomerRepository(CustomersContext customersContext) : base(customersContext) { }
        public IList<Customer> GetAll() => base.Select();
        public Customer GetById(int id) => base.Select(id);
        public void Remove(int id) => base.Delete(id);

        public void Save(Customer customer)
        {
            if (customer.Id == 0)
                base.Insert(customer);
            else
                base.Update(customer);
        }
    }
}
