using System.Threading.Tasks;

namespace Organizations.Data;

public interface IOrganizationsDbSchemaMigrator
{
    Task MigrateAsync();
}
