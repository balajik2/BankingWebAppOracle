using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Anchor-join graph representation
/// </summary>
public partial class MVIEW__ADV_AJG
{
    public decimal AJGID_ { get; set; }

    public decimal RUNID_ { get; set; }

    public decimal AJGDESLEN { get; set; }

    public byte[] AJGDES { get; set; } = null!;

    public decimal HASHVALUE { get; set; }

    public decimal? FREQUENCY { get; set; }

    public virtual ICollection<MVIEW__ADV_FJG> MVIEW__ADV_FJG { get; set; } = new List<MVIEW__ADV_FJG>();

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
