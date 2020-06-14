namespace ChillForum.Profiles.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Profile
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public DateTime? BirthDate { get; set; }

        public ICollection<ProfileTrophy> ProfileTrophies { get; set; } = new List<ProfileTrophy>();
    }
}
