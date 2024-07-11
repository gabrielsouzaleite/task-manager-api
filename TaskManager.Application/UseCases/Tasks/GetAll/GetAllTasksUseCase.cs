using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Books = new List<ResponseShortTasksJson>
            {
                new ResponseShortTasksJson
                {
                    Id = 1,
                    Name = "The Little Prince",
                    Description = "Antoine de Saint-Exupéry",
                    DateLimit = "05-05-2000",
                    Status = Communication.Enums.TaskStatus.completed,
                    Priorities = Communication.Enums.TaskPriorities.medium
                }
            }
        };
    }
}
