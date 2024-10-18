namespace ManageTask.Application.Interfaces
{
    /// <summary>
    /// Represents a repository for managing tasks.
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// Adds a task asynchronously.
        /// </summary>
        /// <param name="task">The task to add.</param>
        /// <returns>The added task.</returns>
        Task<ManageTask.Core.Entities.Task> AddTaskAsync(ManageTask.Core.Entities.Task task);

        /// <summary>
        /// Retrieves a task by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the task to retrieve.</param>
        /// <returns>The retrieved task.</returns>
        Task<ManageTask.Core.Entities.Task> GetTaskByIdAsync(int id);

        /// <summary>
        /// Retrieves all tasks asynchronously.
        /// </summary>
        /// <returns>A collection of all tasks.</returns>
        Task<IEnumerable<ManageTask.Core.Entities.Task>> GetAllTasksAsync();

        /// <summary>
        /// Deletes a task by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the task to delete.</param>
        /// <returns>A boolean indicating whether the task was deleted successfully.</returns>
        Task<bool> DeleteTaskAsync(int id);
    }
}
