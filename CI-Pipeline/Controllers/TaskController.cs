using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.Models;

namespace Api.Controllers;

[ApiController]
[Route("tasks")]
public class TaskController : ControllerBase
{
    private readonly TaskService _service;

    public TaskController(TaskService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<TaskItem>> Get()
    {
        return Ok(_service.GetAll());
    }

    [HttpPost]
    public ActionResult<TaskItem> Post([FromBody] string titulo)
    {
        var task = _service.Add(titulo);
        return Ok(task);
    }
}