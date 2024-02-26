using Microsoft.EntityFrameworkCore;
using OnlineFoodOrder.Models.Domain;

namespace OnlineFoodOrder.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions<MVCDemoDbContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants {  get; set; }
        public DbSet<Customer> Customers { get; set; }  
  

    }
}
