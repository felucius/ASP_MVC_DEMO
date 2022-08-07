using System.Data.Entity;

namespace ASP_MVC_Demo.Models
{
    public class DatabaseContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}