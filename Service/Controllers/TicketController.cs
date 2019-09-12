using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Models;

namespace Service.Controllers
{
  public class TicketController : Controller
  {
    public IActionResult NewTicket()
    {
      return View();
    }

    public IActionResult CreateTicket(TicketModel Ticket)
    {
      if(ModelState.IsValid)
      {
        Console.WriteLine(Ticket.View());
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
