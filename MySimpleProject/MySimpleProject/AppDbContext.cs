using Microsoft.EntityFrameworkCore;

namespace MySimpleProject
{
    public class AppDbContext : DbContext
    {
        //Written By Logan Kim 
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
