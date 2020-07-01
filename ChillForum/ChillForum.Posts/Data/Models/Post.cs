namespace ChillForum.Posts.Data.Models
{
    using System.Collections.Generic;

    public class Post
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
