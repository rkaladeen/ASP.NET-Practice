using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Service.Controllers
{
  public class UserController : Controller
  {
    private MyContext dbContext;
    public UserController(MyContext context)
    {
      dbContext = context;
    }
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
        if(dbContext.Users.Any(u => u.Email == User.Email))
        {
          ModelState.AddModelError("Email", "Email already in use!");
          return View("NewUser");
        }
        dbContext.Users.Add(User);
        dbContext.SaveChanges();
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
