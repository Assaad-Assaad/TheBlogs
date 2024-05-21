using System.ComponentModel.DataAnnotations;

namespace TheBlogs.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        [Display(Name = "All Comments")]
        public string Text { get; set; } = null!;
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        public int BlogId { get; set; }
    }
}
