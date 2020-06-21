namespace ChillForum.Posts.Models.Posts
{
    using System.Collections.Generic;

    using ChillForum.Common.Infrastructure.AutoMapper;
    using ChillForum.Posts.Data.Models;

    public class PostOutputModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
