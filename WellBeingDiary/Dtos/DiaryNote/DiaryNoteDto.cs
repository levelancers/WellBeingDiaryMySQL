namespace WellBeingDiary.Dtos.DiaryNote
{
    public class DiaryNoteDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public bool IsPublic { get; set; } = false;
        public int Rating { get; set; }
        public string? UserId { get; set; }
    }
}
