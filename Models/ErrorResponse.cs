namespace tm_task_manager_mngr.Models
{
    public class ErrorResponse
    {
        public string Error { get; set; }

        public ErrorResponse(string error)
        {
            Error = error;
        }
    }
}
