﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAbpProject.Controllers;

namespace OrchardPC.Controllers
{
    public class LoginController : MyAbpProjectControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}