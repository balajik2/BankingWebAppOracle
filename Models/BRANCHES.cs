using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class BRANCHES
{
    public decimal BRANCH_ID { get; set; }

    public string BRANCH_NAME { get; set; } = null!;

    public string LOCATION { get; set; } = null!;

    public string? MANAGER_NAME { get; set; }

    public virtual ICollection<ACCOUNTS> ACCOUNTS { get; set; } = new List<ACCOUNTS>();

    public virtual ICollection<EMPLOYEES> EMPLOYEES { get; set; } = new List<EMPLOYEES>();

    public virtual ICollection<LOANS> LOANS { get; set; } = new List<LOANS>();
}
