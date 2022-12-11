using System;
using System.Collections.Generic;
using System.Text;
using Organizations.Localization;
using Volo.Abp.Application.Services;

namespace Organizations;

/* Inherit your application services from this class.
 */
public abstract class OrganizationsAppService : ApplicationService
{
    protected OrganizationsAppService()
    {
        LocalizationResource = typeof(OrganizationsResource);
    }
}
