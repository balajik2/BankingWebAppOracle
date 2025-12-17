using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class CustomerContact
{
    public decimal ContactId { get; set; }

    public decimal? CustomerId { get; set; }

    public string? ContactType { get; set; }

    public string? ContactValue { get; set; }

    public virtual Customer? Customer { get; set; }
}
