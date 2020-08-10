using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCVSMB_Homework.Controllers
{
    public class VideoGameController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
