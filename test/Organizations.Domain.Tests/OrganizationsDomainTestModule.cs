using Organizations.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Organizations;

[DependsOn(
    typeof(OrganizationsEntityFrameworkCoreTestModule)
    )]
public class OrganizationsDomainTestModule : AbpModule
{

}
