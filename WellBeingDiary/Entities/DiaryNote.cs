namespace WellBeingDiary.Entities
{
    public class DiaryNote
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public bool IsPublic { get; set; } = false;
        public int Rating { get; set; }
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
