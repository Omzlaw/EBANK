using System.ComponentModel.DataAnnotations;

namespace EBANK.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}