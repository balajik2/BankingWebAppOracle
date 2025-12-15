using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class CUSTOMERS
{
    public decimal CUSTOMER_ID { get; set; }

    public string FIRST_NAME { get; set; } = null!;

    public string LAST_NAME { get; set; } = null!;

    public string? EMAIL { get; set; }

    public string? PHONE { get; set; }

    public string? ADDRESS { get; set; }

    public DateTime? DOB { get; set; }

    public string? GENDER { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public virtual ICollection<ACCOUNTS> ACCOUNTS { get; set; } = new List<ACCOUNTS>();

    public virtual ICollection<CARDS> CARDS { get; set; } = new List<CARDS>();

    public virtual ICollection<CUSTOMER_CONTACTS> CUSTOMER_CONTACTS { get; set; } = new List<CUSTOMER_CONTACTS>();

    public virtual ICollection<LOANS> LOANS { get; set; } = new List<LOANS>();
}
