using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;
using System.ComponentModel.DataAnnotations;


namespace Site.Controllers
{
    public class NamesController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Form(UserName guestName)
        {
            if (ModelState.IsValid)
            {
                NameStore.AddName(guestName);
                return View("HelloName", guestName);
            }
            else return View();
        }
       

    }
}
