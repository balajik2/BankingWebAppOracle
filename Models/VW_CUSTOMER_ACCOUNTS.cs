using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class VW_CUSTOMER_ACCOUNTS
{
    public string FIRST_NAME { get; set; } = null!;

    public string LAST_NAME { get; set; } = null!;

    public decimal ACCOUNT_ID { get; set; }

    public decimal? BALANCE { get; set; }
}
