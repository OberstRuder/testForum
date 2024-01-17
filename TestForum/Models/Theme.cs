using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestForum.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public List<Post>? Posts { get; set;}
    }
}
