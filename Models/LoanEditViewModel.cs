
using System.ComponentModel.DataAnnotations;

namespace BankingWebApp.Models
{
    public class LoanEditViewModel
    {
        [Required]
        public int LoanId { get; set; }

        [Required, StringLength(20)]
        public string Status { get; set; } = "ACTIVE";
    }
}
