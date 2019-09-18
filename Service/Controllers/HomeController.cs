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
  public class HomeController : Controller
  {
    private MyContext dbContext;
    public HomeController(MyContext context)
    {
      dbContext = context;
    } 
    public IActionResult Index()
    {
      if(HttpContext.Session.GetString("UserName") != null)
      {
        ViewBag.AllTickets = dbContext.Tickets.Include(u1 => u1.Reported_By).Include(u2 => u2.Assigned_To).Include(s => s.Location).ToList().OrderByDescending(u => u.CreatedAt);
        ViewBag.user_name = HttpContext.Session.GetString("UserName");
        return View("Index");
      }
      else
      {
        return RedirectToAction("LogIn", "User");
      }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
