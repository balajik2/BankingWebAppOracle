using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Transaction
{
    public decimal TransactionId { get; set; }

    public decimal AccountId { get; set; }

    public decimal Amount { get; set; }

    public string? TransactionType { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Account Account { get; set; } = null!;
}
