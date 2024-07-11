using TaskManager.Communication.Requests;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTasksJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priorities = request.Priorities 
        };
    }
}
