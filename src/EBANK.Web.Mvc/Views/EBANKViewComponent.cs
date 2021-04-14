using Abp.AspNetCore.Mvc.ViewComponents;

namespace EBANK.Web.Views
{
    public abstract class EBANKViewComponent : AbpViewComponent
    {
        protected EBANKViewComponent()
        {
            LocalizationSourceName = EBANKConsts.LocalizationSourceName;
        }
    }
}
