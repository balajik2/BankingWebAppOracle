using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Summary advisor journal table for debugging and information
/// </summary>
public partial class MVIEW__ADV_JOURNAL
{
    public decimal RUNID_ { get; set; }

    public decimal SEQ_ { get; set; }

    public DateTime TIMESTAMP { get; set; }

    public decimal FLAGS { get; set; }

    public decimal? NUM { get; set; }

    public string? TEXT { get; set; }

    public decimal? TEXTLEN { get; set; }

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
