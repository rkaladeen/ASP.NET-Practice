using System.ComponentModel.DataAnnotations;

namespace Service.Models 
{
  public class StoreModel : BaseEntityModel
  {
    [Key]
    public int Store_Id {get; set;}

    [Required]
    [MinLength(3)]
    public string Name {get; set;}

    [Required]
    [MinLength(3)]
    public string StreetAddress {get; set;}

    [Required]
    [MinLength(3)]
    public string City {get; set;}

    [Required]
    [MinLength(2)]
    public string State {get; set;}

    [Required]
    [StringLength(5, ErrorMessage="{0} length must be {1} digits.")]
    public int Zip {get; set;}

    [Required]
    public UserModel GeneralManager {get; set;}

    [Required]
    public UserModel Supervisor {get; set;}

    [Required]
    public UserModel OTP {get; set;}
  }

}