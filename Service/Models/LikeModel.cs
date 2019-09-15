using System.ComponentModel.DataAnnotations;
using Service.Models;

namespace Service
{
  public class LikeModel : BaseEntityModel
  {
    [Key]
    public int Like_Id {get; set;}
    public int User_Id {get; set;}
    public UserModel User {get; set;}

    public int News_Id {get; set;}
    public NewsModel Article {get; set;}
  }
}