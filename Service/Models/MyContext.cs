using Microsoft.EntityFrameworkCore;
 
namespace Service.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<UserModel> Users {get;set;}
    public DbSet<TicketModel> Tickets {get;set;}
    public DbSet<StoreModel> Stores {get;set;}
    public DbSet<NewsModel> News {get;set;}
    public DbSet<NewsCategoryModel> NewsCategorys {get;set;}
    
    public DbSet<LikeModel> Likes {get;set;}


  }
}