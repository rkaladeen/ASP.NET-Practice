using System;
using System.ComponentModel.DataAnnotations;

namespace Service.Models 
{
  public class UserModel 
  {
    [Required]
    [MinLength(3)]
    [Display(Name = "First Name")]
    public string FirstName {get; set;}

    [Required]
    [MinLength(3)]
    [Display(Name = "Last Name")]
    public string LastName {get; set;}

    [Required]
    [EmailAddress]
    public string Email {get; set;}

    [Required]
    [DataType(DataType.Password)]
    public string Password {get; set;}


    public string View()
    {
      string text;
      text = $"{FirstName} {LastName}\n{Email}";
      return text;
    }
  }

}