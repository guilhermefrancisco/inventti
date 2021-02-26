using AutoMapper;
using customers.Domain.DTOs;
using customers.Domain.Entities;
using customers.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace customers.Service.Services
{
    public class CustomerService : IServiceCustomer
    {
        private readonly IRepositoryCustomer _repositoryCustomer;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryCustomer repositoryCustomer, IMapper mapper)
        {
            _repositoryCustomer = repositoryCustomer;
            _mapper = mapper;
        }

        public void Delete(int id) => _repositoryCustomer.Remove(id);

        public CustomerDTO Insert(CreateCustomerDTO createCustomer)
        {
            var customer = _mapper.Map<CreateCustomerDTO, Customer>(createCustomer);
            _repositoryCustomer.Save(customer);

            return _mapper.Map<Customer, CustomerDTO>(customer);
        }

        public IEnumerable<CustomerDTO> RecoverAll() => _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDTO>>(_repositoryCustomer.GetAll());

        public CustomerDTO RecoverById(int id) => _mapper.Map<Customer, CustomerDTO>(_repositoryCustomer.GetById(id));

        public CustomerDTO Update(UpdateCustomerDTO updateCustomer)
        {
            var customer = _repositoryCustomer.GetById(updateCustomer.Id);
            _repositoryCustomer.Save(_mapper.Map<UpdateCustomerDTO, Customer>(updateCustomer, customer));

            return _mapper.Map<Customer, CustomerDTO>(customer);
        }
    }
}
