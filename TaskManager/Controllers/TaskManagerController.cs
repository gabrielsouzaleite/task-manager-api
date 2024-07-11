using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.Register;
using TaskManager.Application.UseCases.Tasks.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Response;

namespace TaskManager.Controllers;
public class TaskManagerController : MyBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestTasksJson request)
    {
        var useCase = new RegisterTaskUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        if (response.Books.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTasksJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteTaskByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}
