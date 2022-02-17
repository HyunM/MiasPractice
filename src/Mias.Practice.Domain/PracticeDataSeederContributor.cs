using System;
using System.Threading.Tasks;
using Mias.Practice.Customers;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerManager _customerManager;

        public BookStoreDataSeederContributor(
            ICustomerRepository customerRepository,
            CustomerManager customerManager)
        {
            _customerRepository = customerRepository;
            _customerManager = customerManager;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
           

            // ADDED SEED DATA FOR AUTHORS

            if (await _customerRepository.GetCountAsync() <= 0)
            {
                await _customerRepository.InsertAsync(
                    await _customerManager.CreateAsync(
                        "Hyun Myung Kim",
                        "111"
                    )
                );

                await _customerRepository.InsertAsync(
                    await _customerManager.CreateAsync(
                        "Anthony Kim",
                        "222"
                    )
                );
            }
        }
    }
}