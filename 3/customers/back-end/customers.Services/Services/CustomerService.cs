using customers.Domain.DTOs;
using customers.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace customers.Service.Services
{
    public class CustomerService : IServiceCustomer
    {
        private readonly IRepositoryCustomer _repositoryCustomer;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO Insert(CreateCustomerDTO createCustomer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDTO> RecoverAll()
        {
            throw new NotImplementedException();
        }

        public CustomerDTO RecoverById(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO Update(UpdateCustomerDTO updateCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
