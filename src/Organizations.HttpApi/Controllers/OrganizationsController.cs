using Organizations.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Organizations.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OrganizationsController : AbpControllerBase
{
    protected OrganizationsController()
    {
        LocalizationResource = typeof(OrganizationsResource);
    }
}
