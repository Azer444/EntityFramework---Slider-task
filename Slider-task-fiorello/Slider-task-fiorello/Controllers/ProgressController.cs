using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slider_task_fiorello.Controllers
{
    public class ProgressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
