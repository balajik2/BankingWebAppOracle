using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class CARDS
{
    public decimal CARD_ID { get; set; }

    public decimal CUSTOMER_ID { get; set; }

    public string? CARD_TYPE { get; set; }

    public string? CARD_NUMBER { get; set; }

    public DateTime? EXPIRY_DATE { get; set; }

    public string? STATUS { get; set; }

    public virtual CUSTOMERS CUSTOMER { get; set; } = null!;
}
