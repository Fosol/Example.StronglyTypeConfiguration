﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.OptionsModel;

namespace Example.StronglyTypeConfiguration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExampleConfiguration _configuration;

        public HomeController(IOptions<ExampleConfiguration> configuration)
        {
            _configuration = configuration.Options;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
