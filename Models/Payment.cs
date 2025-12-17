using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Payment
{
    public decimal PaymentId { get; set; }

    public decimal? LoanId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual Loan? Loan { get; set; }
}
