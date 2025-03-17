using System.ComponentModel.DataAnnotations;

namespace tm_task_manager_mngr.Models
{
    public class Task
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

    }
}
