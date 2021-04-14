using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace EBANK.Web.Views
{
    public abstract class EBANKRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected EBANKRazorPage()
        {
            LocalizationSourceName = EBANKConsts.LocalizationSourceName;
        }
    }
}
