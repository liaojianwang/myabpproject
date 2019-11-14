using System.ComponentModel.DataAnnotations;

namespace MyAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}