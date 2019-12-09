using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.Controllers;

namespace MyAbpProject.UI.Areas.Admin.Controllers
{
    /// <summary>
    /// 特性必须得加Area 否则404
    /// </summary>
    [Area("Admin")]
    public class LoginController : MyAbpProjectControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}