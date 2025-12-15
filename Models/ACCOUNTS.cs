using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ACCOUNTS
{
    public decimal ACCOUNT_ID { get; set; }

    public decimal CUSTOMER_ID { get; set; }

    public decimal BRANCH_ID { get; set; }

    public string? ACCOUNT_TYPE { get; set; }

    public decimal? BALANCE { get; set; }

    public string? STATUS { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public virtual BRANCHES BRANCH { get; set; } = null!;

    public virtual CUSTOMERS CUSTOMER { get; set; } = null!;

    public virtual ICollection<TRANSACTIONS> TRANSACTIONS { get; set; } = new List<TRANSACTIONS>();
}
