using WellBeingDiary.Dtos.DiaryNote;
using WellBeingDiary.Entities;

namespace WellBeingDiary.Mappers
{
    public static class DiaryNoteMappers
    {
        public static DiaryNoteDto ToDiaryNoteDto(this DiaryNote diaryNote)
        {
            return new DiaryNoteDto
            {
                Id = diaryNote.Id,
                Title = diaryNote.Title,
                Text = diaryNote.Text,
                IsPublic = diaryNote.IsPublic,
                Rating = diaryNote.Rating,
                UserId = diaryNote.UserId
            };
        }

        public static DiaryNote ToDiaryNoteFromCreateDto(this CreateDiaryNoteRequestDto diaryNoteDto, string userId)
        {
            return new DiaryNote 
            { 
                Title = string.IsNullOrWhiteSpace(diaryNoteDto.Title) ? $"Note from {DateTime.UtcNow.ToString("dd-MM-yyyy")}" : diaryNoteDto.Title,
                Text = diaryNoteDto.Text,
                IsPublic = diaryNoteDto.IsPublic,
                Rating = diaryNoteDto.Rating,
                CreationDate = DateTime.UtcNow,
                UserId = userId
            };
        }
    }
}
