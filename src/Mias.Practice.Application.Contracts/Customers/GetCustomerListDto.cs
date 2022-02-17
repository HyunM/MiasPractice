using Volo.Abp.Application.Dtos;

namespace Mias.Practice.Customers
{
    public class GetCustomerListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}