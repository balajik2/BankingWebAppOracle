using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Card
{
    public decimal CardId { get; set; }

    public decimal CustomerId { get; set; }

    public string? CardType { get; set; }

    public string? CardNumber { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Status { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
