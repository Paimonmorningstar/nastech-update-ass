using efday1.Models;
using Microsoft.EntityFrameworkCore;

namespace efday1.Data
{
    public class StdManagementContext : DbContext
    {
        public StdManagementContext(DbContextOptions<StdManagementContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = null!;
    }
}