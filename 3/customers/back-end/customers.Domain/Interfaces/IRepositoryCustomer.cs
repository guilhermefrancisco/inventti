using customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
