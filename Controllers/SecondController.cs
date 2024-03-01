

using Microsoft.AspNetCore.Mvc;

public class SecondController : Controller
{
    public ViewResult Index2()
    {
        return View();
    }

    [HttpGet("{favoriteResponse}")]
    public IActionResult ItDepends(string favoriteResponse)
    {
            if(favoriteResponse == "Redirect")
        {
            return RedirectToAction("Index2");
        }
            else if(favoriteResponse == "Json")
        {
            return Json(new {FavoriteResponse = favoriteResponse});
        }

    return View();
    }

}