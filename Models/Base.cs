namespace library_system_dotnet.Models
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Base()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateTimestamp()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        // Optional constructor to explicitly set Id and timestamps
        public Base(int id, DateTime? createdAt = null, DateTime? updatedAt = null)
        {
            Id = id;
            CreatedAt = createdAt ?? DateTime.UtcNow;
            UpdatedAt = updatedAt ?? CreatedAt;
        }
    }

}
