using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Internal table for passing information from the SQL analyzer
/// </summary>
public partial class MVIEW__ADV_INFO
{
    public decimal RUNID_ { get; set; }

    public decimal SEQ_ { get; set; }

    public decimal TYPE { get; set; }

    public decimal INFOLEN { get; set; }

    public byte[]? INFO { get; set; }

    public decimal? STATUS { get; set; }

    public decimal? FLAG { get; set; }

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
