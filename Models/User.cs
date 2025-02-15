using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace md_notes.Models
{
    public class User : IdentityUser, IBaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
