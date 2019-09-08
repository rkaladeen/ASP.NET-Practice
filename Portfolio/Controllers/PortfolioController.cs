using System;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
  public class PortfolioController : Controller
  {
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Index()
    {
      ViewBag.Title = "About Me";
      ViewBag.active = "active";
      DateTime time = DateTime.Now;
      ViewBag.time = time;
      return View();
    }

    [HttpGet]
    [Route("projects")]
    public ViewResult Projects()
    {
      ViewBag.Title = "Completed Projects";
      ViewBag.active = "active";
      DateTime time = DateTime.Now;
      ViewBag.time = time;
      return View("Projects");
    }

    [HttpGet]
    [Route("contact")]
    public ViewResult Contact()
    {
      ViewBag.Title = "Contact Me";
      ViewBag.active = "active";
      DateTime time = DateTime.Now;
      ViewBag.time = time;
      return View("Contact");
    }

    [HttpGet]
    [Route("displayanon")]
    public JsonResult DisplayAnon()
    {
        var AnonObject = new {
          FirstName = "Raz",
          LastName = "Aquato",
          Age = 10
        };
        return Json(AnonObject);
    }

    [HttpGet("{favoriteResponse}")]
    public IActionResult ItDepends(string favoriteResponse)
    {
      if(favoriteResponse == "Redirect")
      {
        return RedirectToAction("Index");
      }
      else if(favoriteResponse == "Json")
      {
        return Json(new {FavoriteResponse = favoriteResponse});
      }
      return View();
    }

  }
}