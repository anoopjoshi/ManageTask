namespace ManageTask.Core.Entities
{
    public class Task
    {
        /// <summary>
        /// Gets or sets the ID of the task.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the task. Can be null.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the task. Can be null.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the created date of the task.
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
