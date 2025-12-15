
using System.ComponentModel.DataAnnotations;

namespace BankingWebApp.Models
{
    public class CardEditViewModel
    {
        [Required]
        public int CardId { get; set; }

        [Required, StringLength(20)]
        public string Status { get; set; } = "ACTIVE";
    }
}
