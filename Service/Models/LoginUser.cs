using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Models {
  public class LoginUser
  {
    public string Email {get; set;}
    public string Password { get; set; }
  }


}
