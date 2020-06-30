namespace ChillForum.Posts.Models.Posts
{
    using System.ComponentModel.DataAnnotations;

    using static ChillForum.Posts.Data.DataConstants;

    public class CreatePostInputModel
    {
        [Required]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(MaxPostTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
