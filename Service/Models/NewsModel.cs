using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Models {
  public class NewsModel : BaseEntityModel
  {
    [Key]
    public int News_Id {get; set;}

    [Required]
    public UserModel Author {get; set;}

    [Required]
    [StringLength(25, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Title {get; set;}

    [Required]
    [StringLength(100, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string SubTitle {get; set;}

    [Required]
    public NewsCategoryModel Category {get; set;}

    [Required]
    [StringLength(1000, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 100)]
    public string Text {get; set;}

    [Required]
    [Display(Name = "Image URL")]
    public string Img_Url {get; set;}

    [Display(Name = "Likes")]
    public List<LikeModel> Liked_By {get; set;}
    public NewsModel()
    {
      Liked_By = new List<LikeModel>();
    }
  }
}