

using System;
using Microsoft.AspNetCore.Mvc;

public class FirstController : Controller
{
    
    public RedirectToActionResult Method()
        {
            return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5});
        }
        

        
    [HttpGet]
    [Route("other/{Food}/{Quantity}")]
    public ViewResult OtherMethod(string Food, int Quantity)
        {
            Console.WriteLine($"I ate {Quantity} {Food}");
            return View();
        }
}


