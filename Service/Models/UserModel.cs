using System;
using System.ComponentModel.DataAnnotations;

namespace Service.Models 
{
  public class UserModel 
  {
    [Required]
    [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
    [Display(Name = "First Name")]
    public string FirstName {get; set;}

    [Required]
    [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
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