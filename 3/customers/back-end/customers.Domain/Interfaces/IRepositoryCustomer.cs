using customers.Domain.Entities;
using System.Collections.Generic;

namespace customers.Domain.Interfaces
{
    public interface IRepositoryCustomer
    {
        void Save(Customer customer);
        void Remove(int id);
        Customer GetById(int id);
        IList<Customer> GetAll();
    }
}
