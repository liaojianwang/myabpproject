using Microsoft.AspNetCore.Antiforgery;
using MyAbpProject.Controllers;

namespace MyAbpProject.Web.Host.Controllers
{
    public class AntiForgeryController : MyAbpProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
