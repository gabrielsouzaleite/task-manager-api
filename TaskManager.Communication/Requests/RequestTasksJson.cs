using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestTasksJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TaskPriorities Priorities { get; set; }

    public string DateLimit { get; set; } = string.Empty;

    public Enums.TaskStatus Status { get; set; }

}
