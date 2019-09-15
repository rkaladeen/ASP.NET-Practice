using System.ComponentModel.DataAnnotations;

namespace Service.Models 
{
  public class TicketModel : BaseEntityModel
  {
    [Key]
    public int Ticket_Id {get; set;}

    [Required]
    public UserModel Reported_By {get; set;}

    public UserModel Assigned_To {get; set;}

    [Required]
    public StoreModel Location {get; set;}

    [Required]
    public string Priority {get; set;}

    public string Status {get; set;}

    [Required]
    [StringLength(1000, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Description {get; set;}

    [StringLength(1000, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Resolution {get; set;}
  }

}