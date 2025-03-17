
using Microsoft.EntityFrameworkCore;
using tm_task_manager_mngr.Data;

namespace tm_task_manager_mngr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase(builder.Configuration.GetConnectionString("DBTaskMemory"))
            );
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/", async context =>
            {
                context.Response.Redirect("/swagger/index.html");
            });

            app.MapControllers();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.EnsureCreated();
            }

            app.Run();
        }
    }
}
