using Microsoft.AspNetCore.Mvc;

namespace cs_app.Controllers
{
    public class HelloController
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World from Hello Controller";
        }
    }
}