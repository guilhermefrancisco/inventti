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

        public CustomerService(IRepositoryCustomer repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;
        }

        public void Delete(int id) => _repositoryCustomer.Remove(id);

        public CustomerDTO Insert(CreateCustomerDTO createCustomer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDTO> RecoverAll()
        {
            var customers = _repositoryCustomer.GetAll();

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
