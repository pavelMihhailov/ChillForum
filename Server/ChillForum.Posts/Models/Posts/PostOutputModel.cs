namespace ChillForum.Posts.Models.Posts
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using ChillForum.Common.Infrastructure.AutoMapper;
    using ChillForum.Posts.Data.Models;

    public class PostOutputModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CommentsCount { get; set; }

        public void Mapping(Profile mapper)
            => mapper
                .CreateMap<Post, PostOutputModel>()
                .ForMember(p => p.CommentsCount, cfg => cfg
                    .MapFrom(d => d.Comments.Count()));
    }
}
