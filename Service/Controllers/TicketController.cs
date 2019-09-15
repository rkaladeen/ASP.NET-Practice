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
  public class TicketController : Controller
  {
    private MyContext dbContext;
    public TicketController(MyContext context)
    {
      dbContext = context;
    } 
    public IActionResult NewTicket()
    {
      if(HttpContext.Session.GetString("UserName") != null)
      {
        ViewData["user_logged_in"] = HttpContext.Session.GetString("UserName");
        return View();
      }
      else
      {
        return RedirectToAction("LogIn", "User");
      }
    }

    public IActionResult CreateTicket(TicketModel Ticket)
    {
      if(ModelState.IsValid)
      {
        dbContext.Tickets.Add(Ticket);
        dbContext.SaveChanges();
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View("NewTicket");
      }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
