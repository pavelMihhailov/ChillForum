namespace ChillForum.Posts.Data.Configurations
{
    using ChillForum.Posts.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static ChillForum.Posts.Data.DataConstants;

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.AuthorId)
                .IsRequired();

            builder
                .Property(x => x.Content)
                .IsRequired()
                .HasMaxLength(MaxCommentContentLength);

            builder
                .HasOne(x => x.Post)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
