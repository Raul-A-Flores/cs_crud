using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace cs_app.Controllers
{
    public class HelloController: Controller
    {
/* 
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }  */

        [HttpGet]
        [Route("{name}")]
        public string Index1(string name)
        {
            return $"Hello {name}!";
        }

        [HttpGet]
        [Route("pizza/{topping}")]
        public string PizzaParty(string topping)
        {
            return $"Whos ready for a {topping} Pizza!";
        }


        [HttpGet("about")]
        public string About(){
            return "About";
        }

        [HttpGet]
        [Route("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age)
        {
            return $"{name}, aged {age}, is from {location}";
        }



        [HttpPost]
        [Route("submission")]
        public string FormSubmission(string formInput){
            return "yep";
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Example = "Hello World";
            return View();
        }

/* 
        [HttpPost]
        [Route("method")]
        public IActionResult Method(string TextField, int NumberField)
        {
            return View();
        } */


 /*        

       [HttpGet("displayint")]
       public JsonResult DisplayInt()
       {
        return Json(34);
       }

       [HttpGet("displayhuman")]
       public JsonResult DisplayHuman()
       {
        return Json(new Human("Moose Phillips", 50, 5, 5));
       } */


       

    }
}