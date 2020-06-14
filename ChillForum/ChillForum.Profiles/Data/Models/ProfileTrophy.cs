namespace ChillForum.Profiles.Data.Models
{
    public class ProfileTrophy
    {
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }

        public int TrophyId { get; set; }

        public virtual Trophy Trophy { get; set; }
    }
}
