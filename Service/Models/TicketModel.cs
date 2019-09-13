using System;
using System.ComponentModel.DataAnnotations;

namespace Service.Models 
{
  public class TicketModel 
  {
    [Key]

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

    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
  }

}