using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WellBeingDiary.Dtos.DiaryNote
{
    public class CreateDiaryNoteRequestDto
    {
        [MaxLength(50, ErrorMessage = "Title can not be longer than 50 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(1, ErrorMessage = "Text can not be empty.")]
        [MaxLength(2000, ErrorMessage = "Text can not be longer than 2000 characters.")]
        public string Text { get; set; } = string.Empty;

        [DefaultValue(false)]
        public bool IsPublic { get; set; } = false;

        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }
        private string UserId { get; set; } = string.Empty;
    }
}
