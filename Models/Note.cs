using System.ComponentModel.DataAnnotations;

namespace md_notes.Models
{
    public class Note : BaseEntity
    {
        [Required]
        string Title { get; set; } = null!;

        [Required]
        string Path { get; set; } = null!;
    }
}
