using Organizations.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Organizations.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class OrganizationsPageModel : AbpPageModel
{
    protected OrganizationsPageModel()
    {
        LocalizationResourceType = typeof(OrganizationsResource);
    }
}
