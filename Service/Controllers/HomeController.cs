using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Models;

namespace Service.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      
      return View();
    }

    public IActionResult NewTicket()
    {
      List<string> Store = new List<string>();
      Store.Add("400");
      Store.Add("882");
      Store.Add("2797");
      ViewData["Store"] = Store;

      List<string> Priority = new List<string>();
      Priority.Add("Low");
      Priority.Add("Med");
      Priority.Add("High");
      ViewData["Priority"] = Priority;

      return View();
    }

    public RedirectToActionResult CreateTicket(TicketModel Ticket)
    {
      Console.WriteLine(Ticket.View());
      return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
