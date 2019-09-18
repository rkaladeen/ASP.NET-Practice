using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Models 
{
  public class TicketModel : BaseEntityModel
  {
    [Key]
    public int Ticket_Id {get; set;}

    [Display(Name = "Reported By")] 
    public int Reporter_Id {get; set;}
    [ForeignKey("Reporter_Id")]
    public virtual UserModel Reported_By {get; set;}

    [Display(Name = "Assigned To")] 
    public int Assigned_User_Id {get; set;}
    [ForeignKey("Assigned_User_Id")]
    public virtual UserModel Assigned_To {get; set;}

    [Display(Name = "Store")] 
    public int Location_Id {get; set;}
    [ForeignKey("Location_Id")]
    public virtual StoreModel Location {get; set;}

    public string Priority {get; set;}

    public string Status {get; set;}

    [Required]
    [StringLength(1000, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Description {get; set;}

    [StringLength(1000, ErrorMessage="{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Resolution {get; set;}
  }

}