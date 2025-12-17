using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Loan
{
    public decimal LoanId { get; set; }

    public decimal CustomerId { get; set; }

    public decimal BranchId { get; set; }

    public decimal? LoanAmount { get; set; }

    public decimal? InterestRate { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
