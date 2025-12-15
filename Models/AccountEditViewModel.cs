
using System.ComponentModel.DataAnnotations;

namespace BankingWebApp.Models
{
    public class AccountEditViewModel
    {
        [Required]
        public int AccountId { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "ACTIVE"; // ACTIVE or CLOSED
    }
}
