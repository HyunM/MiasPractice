using System;
using System.ComponentModel.DataAnnotations;

namespace Mias.Practice.Customers
{
    public class CreateCustomerDto
    {
        [Required]
        [StringLength(CustomerConsts.MaxNameLength)]
        public string Name { get; set; }
        
        public string Tel { get; set; }
    }
}