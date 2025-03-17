using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tm_task_manager_mngr.Data;
using tm_task_manager_mngr.Dto;
using tm_task_manager_mngr.Models;
using Task = tm_task_manager_mngr.Models.Task;

namespace tm_task_manager_mngr.Controllers
{
    [Route("v1/api/task-mngr/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Task>>> GetTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Task>> GetTask(string id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return NotFound(new ErrorResponse("Task not Found"));
            }

            return task;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(string id, TaskDto task)
        {

            try
            {
                var taskInBd = await _context.Tasks.FindAsync(id);
                if (taskInBd == null)
                {
                    return NotFound(new ErrorResponse("Task not Found"));
                }else{

                    var taskUpdated = taskInBd;
                    taskUpdated.Title = StringNullDefault(task.Title, taskInBd.Title);
                    taskUpdated.Description = StringNullDefault(task.Description, taskInBd.Description);
                    taskUpdated.Status = StringNullDefault(task.Status, taskInBd.Status);
                    _context.Entry(taskUpdated).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<Task>> PostTask(Task task)
        {
            _context.Tasks.Add(task);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TaskExists(task.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTask", new { id = task.Id }, task);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(string id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound(new ErrorResponse("Task not Found"));
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskExists(string id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }

        private string StringNullDefault(string validateText, string defaultText)
        {
            return string.IsNullOrEmpty(validateText)? defaultText: validateText;
        }
    }
}
