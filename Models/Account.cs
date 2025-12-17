using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Account
{
    public decimal AccountId { get; set; }

    public decimal CustomerId { get; set; }

    public decimal BranchId { get; set; }

    public string? AccountType { get; set; }

    public decimal? Balance { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
