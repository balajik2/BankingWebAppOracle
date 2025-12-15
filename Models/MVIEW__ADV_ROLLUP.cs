using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Each row repesents either a functional dependency or join-key relationship
/// </summary>
public partial class MVIEW__ADV_ROLLUP
{
    public decimal RUNID_ { get; set; }

    public decimal CLEVELID_ { get; set; }

    public decimal PLEVELID_ { get; set; }

    public decimal FLAGS { get; set; }

    public virtual MVIEW__ADV_LEVEL MVIEW__ADV_LEVEL { get; set; } = null!;

    public virtual MVIEW__ADV_LEVEL MVIEW__ADV_LEVELNavigation { get; set; } = null!;

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
