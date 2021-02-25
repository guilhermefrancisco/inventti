using customers.Domain.DTOs;
using System.Collections.Generic;

namespace customers.Domain.Interfaces
{
    public interface IServiceCustomer
    {
        CustomerDTO Insert(CreateCustomerDTO createCustomer);
        CustomerDTO Update(UpdateCustomerDTO updateCustomer);
        void Delete(int id);
        IEnumerable<CustomerDTO> RecoverAll();
        CustomerDTO RecoverById(int id);
    }
}
