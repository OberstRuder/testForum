using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestForum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public int? ThemeId { get; set; }
        [ForeignKey("ThemeId")]
        public Theme? Theme { get; set; }
    }
}
