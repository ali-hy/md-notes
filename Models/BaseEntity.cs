namespace md_notes.Models
{
    /// <summary>
    /// Interface with CreatedAt and UpdatedAt properties that are automatically set by BaseEntityInterceptor
    /// </summary>
    public interface IBaseEntity 
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    /// <summary>
    /// Base Implementation of IBaseEntity
    /// </summary>
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
