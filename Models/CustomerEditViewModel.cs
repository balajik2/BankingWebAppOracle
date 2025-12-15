
using System;
using System.ComponentModel.DataAnnotations;

namespace BankingWebApp.Models
{
    public class CustomerEditViewModel
    {
        [Required]
        public int CustomerId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress, StringLength(100)]
        public string? Email { get; set; }

        [StringLength(15)]
        public string? Phone { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        public DateTime? Dob { get; set; }

        [StringLength(10)]
        public string? Gender { get; set; }
    }
}
