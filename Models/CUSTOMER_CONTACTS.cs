using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class CUSTOMER_CONTACTS
{
    public decimal CONTACT_ID { get; set; }

    public decimal? CUSTOMER_ID { get; set; }

    public string? CONTACT_TYPE { get; set; }

    public string? CONTACT_VALUE { get; set; }

    public virtual CUSTOMERS? CUSTOMER { get; set; }
}
