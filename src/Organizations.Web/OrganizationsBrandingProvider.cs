using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Organizations.Web;

[Dependency(ReplaceServices = true)]
public class OrganizationsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Organizations";
}
