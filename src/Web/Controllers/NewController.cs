using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Public()
        {
            return Content("<html><body>Hello This a Method reply with Html</body></html>", "text/html");
        }

         public IActionResult View()
        {
            return Content("Hello This a Method reply with text!");
        }

         public IActionResult Json()
        {
            return Json(new
                {
                    name = "This is a Json file",
                    type = "Json"

                });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
