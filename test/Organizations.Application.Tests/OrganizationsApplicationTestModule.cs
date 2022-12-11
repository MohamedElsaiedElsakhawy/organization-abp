using Volo.Abp.Modularity;

namespace Organizations;

[DependsOn(
    typeof(OrganizationsApplicationModule),
    typeof(OrganizationsDomainTestModule)
    )]
public class OrganizationsApplicationTestModule : AbpModule
{

}
