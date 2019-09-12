using System;
using System.ComponentModel.DataAnnotations;

namespace Service.Models 
{
  public class TicketModel 
  {
    [Required]
    [MinLength(3)]
    public string Name {get; set;}

    [Required]
    [MinLength(3)]
    public string Location {get; set;}

    [Required]
    [MinLength(3)]
    public string Priority {get; set;}

    [Required]
    [MinLength(3)]
    [MaxLength(250)]
    public string Description {get; set;}

    public string View()
    {
      string text;
      text = $"{Name} | {Location} | {Priority} \n {Description}";
      return text;
    }
  }

}