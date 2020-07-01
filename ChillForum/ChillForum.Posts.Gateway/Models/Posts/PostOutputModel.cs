namespace ChillForum.Posts.Gateway.Models.Posts
{
    public class PostOutputModel
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CommentsCount { get; set; }
    }
}
