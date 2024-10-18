using ManageTask.Application.Interfaces;


namespace ManageTask.Application.Services
{
    /// <summary>
    /// Represents a task manager service.
    /// </summary>
    public class TaskManager : ITaskManager
    {
        private readonly ITaskRepository _taskRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManager"/> class.
        /// </summary>
        /// <param name="taskRepository">The task repository.</param>
        public TaskManager(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        /// <summary>
        /// Adds a task asynchronously.
        /// </summary>
        /// <param name="task">The task to add.</param>
        /// <returns>The added task.</returns>
        public async Task<ManageTask.Core.Entities.Task> AddTaskAsync(ManageTask.Core.Entities.Task task)
        {
            return await _taskRepository.AddTaskAsync(task);
        }

        /// <summary>
        /// Gets a task by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the task.</param>
        /// <returns>The task with the specified ID.</returns>
        public async Task<ManageTask.Core.Entities.Task> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetTaskByIdAsync(id);
        }

        /// <summary>
        /// Gets all tasks asynchronously.
        /// </summary>
        /// <returns>A collection of all tasks.</returns>
        public async Task<IEnumerable<ManageTask.Core.Entities.Task>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        /// <summary>
        /// Deletes a task by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the task to delete.</param>
        /// <returns>True if the task was deleted successfully, otherwise false.</returns>
        public async Task<bool> DeleteTaskAsync(int id)
        {
            return await _taskRepository.DeleteTaskAsync(id);
        }
    }
}
