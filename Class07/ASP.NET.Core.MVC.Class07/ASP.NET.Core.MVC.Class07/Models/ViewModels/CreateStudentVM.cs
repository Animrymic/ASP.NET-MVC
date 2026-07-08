using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Core.MVC.Class07.Models.ViewModels
{
    public class CreateStudentVM
    {
        [Required]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "First name must have at most 50 characters long.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must have between 2 and 50 characters long.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
