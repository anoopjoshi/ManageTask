using ManageTask.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskManager _taskManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksController"/> class.
        /// </summary>
        /// <param name="taskManager">The task manager.</param>
        public TasksController(ITaskManager taskManager)
        {
            _taskManager = taskManager;
        }

        /// <summary>
        /// Adds a new task.
        /// </summary>
        /// <param name="task">The task to add.</param>
        /// <returns>The created task.</returns>
        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] Core.Entities.Task task)
        {
            if (task == null)
            {
                return BadRequest("Task is null.");
            }

            if(string.IsNullOrEmpty(task.Title))
            {
                return BadRequest("Task title is required.");
            }

            var createdTask = await _taskManager.AddTaskAsync(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = createdTask.Id }, createdTask);
        }

        /// <summary>
        /// Gets a task by its ID.
        /// </summary>
        /// <param name="id">The ID of the task.</param>
        /// <returns>The task with the specified ID.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var task = await _taskManager.GetTaskByIdAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        /// <summary>
        /// Gets all tasks.
        /// </summary>
        /// <returns>All tasks.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var tasks = await _taskManager.GetAllTasksAsync();
            return Ok(tasks);
        }

        /// <summary>
        /// Deletes a task by its ID.
        /// </summary>
        /// <param name="id">The ID of the task to delete.</param>
        /// <returns>No content if the task was deleted successfully, otherwise NotFound.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var result = await _taskManager.DeleteTaskAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
