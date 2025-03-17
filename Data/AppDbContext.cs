using Microsoft.EntityFrameworkCore;

namespace tm_task_manager_mngr.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
