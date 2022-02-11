using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Mias.Practice.Customers
{
    public class CustomerManager : DomainService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> CreateAsync(
            [NotNull] string name,
            [CanBeNull] string tel = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingCustomer = await _customerRepository.FindByNameAsync(name);
            if (existingCustomer != null)
            {
                throw new CustomerAlreadyExistsException(name);
            }

            return new Customer(
                GuidGenerator.Create(),
                name,
                tel
            );
        }

        public async Task ChangeNameAsync(
            [NotNull] Customer customer,
            [NotNull] string newName)
        {
            Check.NotNull(customer, nameof(customer));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingCustomer = await _customerRepository.FindByNameAsync(newName);
            if (existingCustomer != null && existingCustomer.Id != customer.Id)
            {
                throw new CustomerAlreadyExistsException(newName);
            }

            customer.ChangeName(newName);
        }
    }
}