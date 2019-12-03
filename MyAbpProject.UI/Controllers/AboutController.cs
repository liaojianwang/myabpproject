using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyAbpProject.Controllers;

namespace MyAbpProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MyAbpProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
