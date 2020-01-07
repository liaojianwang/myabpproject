using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Authorization;
using Abp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.Controllers;
using MyAbpProject.Navigations;

namespace MyAbpProject.DcTms.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpAuthorize]
    public class AdminHomeController : MyAbpProjectControllerBase
    {
        private readonly INavigationService _navigation;
        public AdminHomeController(INavigationService navigation)
        {
            _navigation = navigation;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Center()
        {
            return View();
        }

        [HttpGet]
        [DontWrapResult]
        public JsonResult GetNavigationList()
        {
            var result = _navigation.GetList(0, "System");
            return Json(result);
        }
    }
}