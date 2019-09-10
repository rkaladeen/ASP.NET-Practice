using System;

namespace Service.Models 
{
  public class TicketModel 
  {
    public string Name {get; set;}
    public string Location {get; set;}
    public string Priority {get; set;}
    public string Description {get; set;}

    public string View()
    {
      string text;
      text = $"{Name} | {Location} | {Priority} \n {Description}";
      return text;
    }
  }

}