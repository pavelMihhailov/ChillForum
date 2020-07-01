namespace ChillForum.Profiles.Data.Models
{
    using System.Collections.Generic;

    public class Trophy
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }

        public string Title { get; set; }

        public ICollection<ProfileTrophy> ProfileTrophies { get; set; } = new List<ProfileTrophy>();
    }
}
