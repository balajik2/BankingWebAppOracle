using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class PAYMENTS
{
    public decimal PAYMENT_ID { get; set; }

    public decimal? LOAN_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public DateTime? PAYMENT_DATE { get; set; }

    public virtual LOANS? LOAN { get; set; }
}
