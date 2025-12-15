using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Representation for query join sub-graph not in AJG 
/// </summary>
public partial class MVIEW__ADV_FJG
{
    public decimal FJGID_ { get; set; }

    public decimal AJGID_ { get; set; }

    public decimal FJGDESLEN { get; set; }

    public byte[] FJGDES { get; set; } = null!;

    public decimal HASHVALUE { get; set; }

    public decimal? FREQUENCY { get; set; }

    public virtual MVIEW__ADV_AJG AJGID_Navigation { get; set; } = null!;

    public virtual ICollection<MVIEW__ADV_GC> MVIEW__ADV_GC { get; set; } = new List<MVIEW__ADV_GC>();
}
