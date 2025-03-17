using Microsoft.AspNetCore.Mvc;

namespace tm_task_manager_mngr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {
                statusCode = 200,
                status = "Healthy",
                message = "La aplicación está funcionando correctamente" 
            });
        }
    }
    
}