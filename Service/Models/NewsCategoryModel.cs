using System.ComponentModel.DataAnnotations;

namespace Service.Models {
  public class NewsCategoryModel : BaseEntityModel
  {
    [Key]
    public int Category_Id {get; set;}

    [Required]
    [StringLength(25, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 5)]
    public string Title {get; set;}
  }
}