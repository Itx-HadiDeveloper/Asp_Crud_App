using Microsoft.EntityFrameworkCore;
using AspCrudApp.Models;

namespace AspCrudApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        // DbSet for your Student model
        public DbSet<Student> Students { get; set; }
    }
}
