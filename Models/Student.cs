using System;
using System.ComponentModel.DataAnnotations;

namespace AspCrudApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Course { get; set; } = string.Empty;

        [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}
