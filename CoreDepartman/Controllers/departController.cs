﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class departController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
