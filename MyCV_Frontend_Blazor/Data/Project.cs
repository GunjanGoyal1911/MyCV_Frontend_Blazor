using System.ComponentModel.DataAnnotations;

namespace MyCV_Frontend_Blazor.Data
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Project name required.")]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Project description required.")]
        public string ProjectDescription { get; set; }
    }
}
