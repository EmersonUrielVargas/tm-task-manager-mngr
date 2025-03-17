using Microsoft.EntityFrameworkCore;
using Task = tm_task_manager_mngr.Models.Task;

namespace tm_task_manager_mngr.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Task>().HasData(
                new Task
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Hacer ejercicio",
                    Description = "Ir al gimnasio a las 7 AM",
                    Status = "Pendiente"
                },
                new Task
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Realizar App",
                    Description = "Realizar implementacion base del administrador de tareas",
                    Status = "Completa"
                },
                new Task
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Mercado",
                    Description = "Revisar faltantes de la alacena",
                    Status = "Pendiente"
                }

            );
        }
    }
}
