using Volo.Abp;

namespace Mias.Practice.Customers
{
    public class CustomerAlreadyExistsException : BusinessException
    {
        public CustomerAlreadyExistsException(string name)
            : base(PracticeDomainErrorCodes.CustomerAlreadyExists)
        {
            WithData("name", name);
        }
    }
}