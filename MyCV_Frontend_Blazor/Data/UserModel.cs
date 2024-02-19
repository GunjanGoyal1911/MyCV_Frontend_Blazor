using System.ComponentModel.DataAnnotations;

namespace MyCV_Frontend_Blazor.Data
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "First name required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name required.")]
        public string LastName { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "Email required.")]
        public string Email { get; set; }
        [Required]
        public List<Skill> Skills { get; set; } = new List<Skill> ();
        [Required]
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
