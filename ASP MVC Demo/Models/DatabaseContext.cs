using System.Data.Entity;

namespace ASP_MVC_Demo.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}