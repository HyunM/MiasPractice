using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mias.Practice.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Mias.Practice.Customers
{
    [Authorize(PracticePermissions.Customers.Default)]
    public class CustomerAppService : PracticeAppService, ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerManager _customerManager;

        public CustomerAppService(
            ICustomerRepository customerRepository,
            CustomerManager customerManager)
        {
            _customerRepository = customerRepository;
            _customerManager = customerManager;
        }

        //...SERVICE METHODS WILL COME HERE...
        public async Task<CustomerDto> GetAsync(Guid id)
        {
            var customer = await _customerRepository.GetAsync(id);
            return ObjectMapper.Map<Customer, CustomerDto>(customer);
        }
        public async Task<PagedResultDto<CustomerDto>> GetListAsync(GetCustomerListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Customer.Name);
            }

            var customers = await _customerRepository.GetListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting,
                input.Filter
            );

            var totalCount = input.Filter == null
                ? await _customerRepository.CountAsync()
                : await _customerRepository.CountAsync(
                    customer => customer.Name.Contains(input.Filter));

            return new PagedResultDto<CustomerDto>(
                totalCount,
                ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers)
            );
        }

        [Authorize(PracticePermissions.Customers.Create)]
        public async Task<CustomerDto> CreateAsync(CreateCustomerDto input)
        {
            var customer = await _customerManager.CreateAsync(
                input.Name,
                input.Tel
            );

            await _customerRepository.InsertAsync(customer);

            return ObjectMapper.Map<Customer, CustomerDto>(customer);
        }

        [Authorize(PracticePermissions.Customers.Edit)]
        public async Task UpdateAsync(Guid id, UpdateCustomerDto input)
        {
            var customer = await _customerRepository.GetAsync(id);

            if (customer.Name != input.Name)
            {
                await _customerManager.ChangeNameAsync(customer, input.Name);
            }

            customer.Tel = input.Tel;

            await _customerRepository.UpdateAsync(customer);
        }

        [Authorize(PracticePermissions.Customers.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            await _customerRepository.DeleteAsync(id);
        }
    }
}