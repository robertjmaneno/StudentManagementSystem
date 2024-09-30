using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.API.Models.Domain
{
    public class ClassName
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Class name is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Class name must be between 1 and 100 characters")]
        public string Name { get; set; } = string.Empty;
    }
}