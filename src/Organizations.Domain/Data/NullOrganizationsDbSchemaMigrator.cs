using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Organizations.Data;

/* This is used if database provider does't define
 * IOrganizationsDbSchemaMigrator implementation.
 */
public class NullOrganizationsDbSchemaMigrator : IOrganizationsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
