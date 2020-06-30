namespace ChillForum.Posts.Models.Comments
{
    using System.ComponentModel.DataAnnotations;

    using static ChillForum.Posts.Data.DataConstants;

    public class CreateCommentInputModel
    {
        [Required]
        public int PostId { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [MaxLength(MaxCommentContentLength)]
        public string Content { get; set; }
    }
}
