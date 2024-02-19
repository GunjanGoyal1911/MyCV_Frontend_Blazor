using System.ComponentModel.DataAnnotations;

namespace MyCV_Frontend_Blazor.Data
{
    public class Skill
    {
        public int SkillId { get; set; }

        [Required(ErrorMessage = "Skill name required.")]
        [StringLength(15, ErrorMessage = "Skill name must be at least 1 characters long.", MinimumLength = 1)]
        public string SkillName { get; set; }

        [Required(ErrorMessage = "Year of experience required.")]
        [Range(typeof(int), "0","50")]
        public int YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Skill Level required.")]
        public string SkillLevel { get; set; }
    }
}
