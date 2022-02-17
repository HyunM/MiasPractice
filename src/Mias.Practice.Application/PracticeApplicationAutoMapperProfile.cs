using AutoMapper;

namespace Mias.Practice.Customers;

public class PracticeApplicationAutoMapperProfile : Profile
{
    public PracticeApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Customer, CustomerDto>();
    }
}
