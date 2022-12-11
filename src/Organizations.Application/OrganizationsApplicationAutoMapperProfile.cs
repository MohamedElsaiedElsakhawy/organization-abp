using AutoMapper;
using Organizations.Classifications;

namespace Organizations;

public class OrganizationsApplicationAutoMapperProfile : Profile
{
    public OrganizationsApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        CreateMap<Classification, ClassificationDto>().ReverseMap();
        CreateMap<CreateClassification, Classification>().ReverseMap();
    }
}
