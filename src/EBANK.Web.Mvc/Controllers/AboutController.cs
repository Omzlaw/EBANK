using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EBANK.Controllers;

namespace EBANK.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : EBANKControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
