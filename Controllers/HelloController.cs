using Microsoft.AspNetCore.Mvc;

namespace cs_app.Controllers
{
    public class HelloController
    {

        [HttpGet]
        [Route("")]
        public string Index1()
        {
            return $"Hello !";
        }

        [HttpGet]
        [Route("{name}")]
        public string Index(string name)
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
    }
}