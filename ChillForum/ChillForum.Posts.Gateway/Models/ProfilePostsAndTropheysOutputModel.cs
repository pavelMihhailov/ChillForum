namespace ChillForum.Posts.Gateway.Models
{
    using System.Collections.Generic;

    using ChillForum.Posts.Gateway.Models.Posts;
    using ChillForum.Posts.Gateway.Models.Tropheys;

    public class ProfilePostsAndTropheysOutputModel
    {
        public int ProfileId { get; set; }

        public string Username { get; set; }

        public IList<PostOutputModel> Posts { get; set; }

        public IList<TrophyOutputModel> Tropheys { get; set; }
    }
}
