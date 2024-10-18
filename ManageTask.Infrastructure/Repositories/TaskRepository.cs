using ManageTask.Application.Interfaces;
using ManageTask.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ManageTask.Infrastructure.Repositories
{
    /// <summary>
    /// Repository class for managing tasks.
    /// </summary>
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagementDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public TaskRepository(TaskManagementDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds a new task to the database.
        /// </summary>
        /// <param name="task">The task to add.</param>
        /// <returns>The added task.</returns>
        public async Task<Core.Entities.Task> AddTaskAsync(Core.Entities.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        /// <summary>
        /// Retrieves a task by its ID.
        /// </summary>
        /// <param name="id">The ID of the task to retrieve.</param>
        /// <returns>The retrieved task, or null if not found.</returns>
        public async Task<Core.Entities.Task> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        /// <summary>
        /// Retrieves all tasks from the database.
        /// </summary>
        /// <returns>A collection of all tasks.</returns>
        public async Task<IEnumerable<Core.Entities.Task>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        /// <summary>
        /// Deletes a task from the database.
        /// </summary>
        /// <param name="id">The ID of the task to delete.</param>
        /// <returns>True if the task was deleted, false if not found.</returns>
        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return false;
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
