namespace TaskApi.Models;

public class UpdateTaskDTO
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = "Normal";
    public bool IsCompleted { get; set; }
}