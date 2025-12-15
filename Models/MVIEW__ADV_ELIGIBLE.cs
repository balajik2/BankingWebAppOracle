using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Summary management rewrite eligibility information
/// </summary>
public partial class MVIEW__ADV_ELIGIBLE
{
    public decimal SUMOBJN_ { get; set; }

    public decimal RUNID_ { get; set; }

    public decimal BYTECOST { get; set; }

    public decimal FLAGS { get; set; }

    public decimal FREQUENCY { get; set; }

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
