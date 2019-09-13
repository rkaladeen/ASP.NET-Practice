using Microsoft.EntityFrameworkCore;
 
namespace Service.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<UserModel> Users {get;set;}
    public DbSet<TicketModel> Tickets {get;set;}
  }
}