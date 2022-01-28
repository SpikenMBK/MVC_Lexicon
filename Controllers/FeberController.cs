using Microsoft.AspNetCore.Mvc;
using MVC_Lexicon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lexicon.Controllers
{
    public class FeberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckFever()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckFever(int temp)
        {
            ViewBag.Message = FeverModel.Check(temp);  // string !!!!
            /*if(temp > 37)
            ViewBag.Message = "Du har feber som är "+ temp+" grader";
           
            else ViewBag.Message = "Du är kärn frisk din rackare";*/

            return View();
        }
    }
}
