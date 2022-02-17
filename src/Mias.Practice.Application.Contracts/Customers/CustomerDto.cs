using System;
using Volo.Abp.Application.Dtos;

namespace Mias.Practice.Customers
{
    public class CustomerDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string Tel { get; set; }
    }
}