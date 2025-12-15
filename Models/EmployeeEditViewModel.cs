
using System.ComponentModel.DataAnnotations;

namespace BankingWebApp.Models
{
    public class EmployeeEditViewModel
    {
        [Required]
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string? Position { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? Salary { get; set; }

        public int? BranchId { get; set; }
    }
}
