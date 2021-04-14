using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EBANK.Controllers;

namespace EBANK.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EBANKControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
