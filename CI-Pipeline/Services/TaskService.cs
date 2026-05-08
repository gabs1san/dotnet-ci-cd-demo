using Api.Models;

namespace Api.Services;

public class TaskService
{
    private static List<TaskItem> tasks = new();
    private static int id = 1;

    public List<TaskItem> GetAll() => tasks;

    public TaskItem Add(string titulo)
    {
        var task = new TaskItem
        {
            Id = id++,
            Titulo = titulo,
            Concluida = false
        };

        tasks.Add(task);
        return task;
    }
}