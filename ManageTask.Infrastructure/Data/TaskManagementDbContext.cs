using ManageTask.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManageTask.Infrastructure.Data
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<ManageTask.Core.Entities.Task> Tasks { get; set; }
    }
}
