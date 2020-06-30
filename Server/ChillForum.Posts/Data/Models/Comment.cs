namespace ChillForum.Posts.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public int AuthorId { get; set; }

        public string Content { get; set; }
    }
}
