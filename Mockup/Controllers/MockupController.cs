using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mockup.Controllers
{
    public class MockupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRole()
        {
            return View();
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        public IActionResult EditRole()
        {
            return View();
        }

        public IActionResult AddOrRemove()
        {
            return View();
        }

    }
}
