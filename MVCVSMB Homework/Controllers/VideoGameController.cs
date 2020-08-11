using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCVSMB_Homework.Models;

namespace MVCVSMB_Homework.Controllers
{
    public class VideoGameController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost] //Call this method after user posts form data.

        public IActionResult Add(IFormCollection form)
        {
            VideoGame vid = new VideoGame();
            vid.Title = form["title"];
            vid.ESRBRating = Convert.ToChar(form["rating"]);
            vid.Systems = form["systems"];
            vid.Price = Convert.ToDecimal(form["price"]);
            //Add to Database
            ViewData["Added"] = vid.Title;
            return View();
        }

        public IActionResult AddWithBinding()
        {
            return View();
        }
    }
}
