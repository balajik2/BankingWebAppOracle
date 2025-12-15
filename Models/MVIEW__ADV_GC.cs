using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Group-by columns of a query
/// </summary>
public partial class MVIEW__ADV_GC
{
    public decimal GCID_ { get; set; }

    public decimal FJGID_ { get; set; }

    public decimal GCDESLEN { get; set; }

    public byte[] GCDES { get; set; } = null!;

    public decimal HASHVALUE { get; set; }

    public decimal? FREQUENCY { get; set; }

    public virtual MVIEW__ADV_FJG FJGID_Navigation { get; set; } = null!;
}
