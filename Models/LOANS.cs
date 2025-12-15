using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOANS
{
    public decimal LOAN_ID { get; set; }

    public decimal CUSTOMER_ID { get; set; }

    public decimal BRANCH_ID { get; set; }

    public decimal? LOAN_AMOUNT { get; set; }

    public decimal? INTEREST_RATE { get; set; }

    public string? STATUS { get; set; }

    public DateTime? START_DATE { get; set; }

    public DateTime? END_DATE { get; set; }

    public virtual BRANCHES BRANCH { get; set; } = null!;

    public virtual CUSTOMERS CUSTOMER { get; set; } = null!;

    public virtual ICollection<PAYMENTS> PAYMENTS { get; set; } = new List<PAYMENTS>();
}
