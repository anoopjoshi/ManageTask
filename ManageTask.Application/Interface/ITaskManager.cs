using ManageTask.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageTask.Application.Interfaces
{
    /// <summary>
    /// Represents the interface for managing tasks.
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// Adds a task asynchronously.
        /// </summary>
        /// <param name="task">The task to add.</param>
        /// <returns>The added task.</returns>
        Task<ManageTask.Core.Entities.Task> AddTaskAsync(ManageTask.Core.Entities.Task task);

        /// <summary>
        /// Gets a task by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the task.</param>
        /// <returns>The task with the specified ID.</returns>
        Task<ManageTask.Core.Entities.Task> GetTaskByIdAsync(int id);

        /// <summary>
        /// Gets all tasks asynchronously.
        /// </summary>
        /// <returns>A collection of all tasks.</returns>
        Task<IEnumerable<ManageTask.Core.Entities.Task>> GetAllTasksAsync();

        /// <summary>
        /// Deletes a task by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the task to delete.</param>
        /// <returns>True if the task was deleted successfully, otherwise false.</returns>
        Task<bool> DeleteTaskAsync(int id);
    }
}
