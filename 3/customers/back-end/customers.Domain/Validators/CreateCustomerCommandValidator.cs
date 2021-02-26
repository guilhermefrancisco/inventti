using customers.Domain.DTOs;
using customers.Domain.Interfaces;
using FluentValidation;

namespace customers.Domain.Validators
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerDTO>
    {
        private readonly IRepositoryCustomer _repositoryCustomer;
        public CreateCustomerCommandValidator(IRepositoryCustomer repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .Must(NotExists).WithMessage("This name already exists!");
        }

        private bool NotExists(string name) => _repositoryCustomer.GetByName(name) == null;
    }
}
