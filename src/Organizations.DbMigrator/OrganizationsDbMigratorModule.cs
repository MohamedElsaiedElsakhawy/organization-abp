using Organizations.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Organizations.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrganizationsEntityFrameworkCoreModule),
    typeof(OrganizationsApplicationContractsModule)
    )]
public class OrganizationsDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
