using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class TRANSACTIONS
{
    public decimal TRANSACTION_ID { get; set; }

    public decimal ACCOUNT_ID { get; set; }

    public decimal AMOUNT { get; set; }

    public string? TRANSACTION_TYPE { get; set; }

    public DateTime? TRANSACTION_DATE { get; set; }

    public virtual ACCOUNTS ACCOUNT { get; set; } = null!;
}
