using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Models;

namespace Service.Controllers
{
  public class UserController : Controller
  {
    public IActionResult NewUser()
    {
      return View();
    }
    public IActionResult LogIn()
    {
      return View();
    }
    public IActionResult CreateUser(UserModel User)
    {
      if(ModelState.IsValid)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View("NewUser");
      }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    
  }
}
