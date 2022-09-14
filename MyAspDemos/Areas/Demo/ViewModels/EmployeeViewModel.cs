using System;
using System.ComponentModel.DataAnnotations;

namespace MyAspDemos.Areas.Demo.ViewModels
{
    public class EmployeeViewModel
    {
        [Key]
        [Display(Name = "ID")]
        [Required]
        public int EmployeeId { get; set; }


        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        [MaxLength(80, ErrorMessage = "{0} can contain a maxium of {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} should contain a minimum of {1} characters.")]
        public string EmployeeName { get; set; }

        [Required]
        [EmailAddress]
        public String EMail { get; set; }

        [Display(Name = "Date of joining")]
        [Required]
        public DateTime JoinedOn { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "{0} can contain a maxium of {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} should contain a minimum of {1} characters.")]
        [Display(Name = "Designation")]
      
        public String Role { get; set; }


        [Display(Name = "Is Enabled?")]
        public bool IsEnabled { get; set; }

    }
}
