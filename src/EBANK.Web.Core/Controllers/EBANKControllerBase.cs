using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EBANK.Controllers
{
    public abstract class EBANKControllerBase: AbpController
    {
        protected EBANKControllerBase()
        {
            LocalizationSourceName = EBANKConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
