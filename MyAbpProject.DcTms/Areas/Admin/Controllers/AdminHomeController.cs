using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.Controllers;

namespace MyAbpProject.DcTms.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpAuthorize]
    public class AdminHomeController : MyAbpProjectControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Center()
        {
            return View();
        }

        [HttpPost]
        public void GetNavigationList()
        {

        }
    }
}