﻿using Microsoft.AspNetCore.Mvc;
using First_MVC_App.Models;

namespace First_MVC_App.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {   
            DogViewModel beno = new DogViewModel() { Name="Beno", Age=4};
            return View(beno);
        }

        public IActionResult Create() 
        { 
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View("Index");
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
