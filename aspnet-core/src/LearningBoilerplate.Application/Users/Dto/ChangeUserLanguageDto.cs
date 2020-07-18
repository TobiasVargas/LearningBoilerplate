using System.ComponentModel.DataAnnotations;

namespace LearningBoilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}