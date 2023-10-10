using BlazorServerApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
