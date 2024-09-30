using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.API.Models.Domain
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Url(ErrorMessage = "Invalid URL for profile photo")]
        public string? ProfilePhoto { get; set; }

        [Required(ErrorMessage = "Village is required")]
        [StringLength(100, ErrorMessage = "Village name cannot be longer than 100 characters")]
        public string Village { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required")]
        public DateOnly DateOfBirth { get; set; }

        [Required(ErrorMessage = "Traditional Authority Name is required")]
        [StringLength(100, ErrorMessage = "Traditional Authority Name cannot be longer than 100 characters")]
        public string TraditionalAuthorityName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Home District is required")]
        [StringLength(100, ErrorMessage = "Home District cannot be longer than 100 characters")]
        public string HomeDistrict { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nationality is required")]
        [StringLength(100, ErrorMessage = "Nationality cannot be longer than 100 characters")]
        public string Nationality { get; set; } = string.Empty;

        [Required(ErrorMessage = "Class Name ID is required")]
        public Guid ClassNameId { get; set; }

        public ClassName ClassName { get; set; }
    }
}