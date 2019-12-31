using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.Controllers;

namespace MyAbpProject.Web.Host.Controllers
{
    public class OrderCenterController : MyAbpProjectControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}