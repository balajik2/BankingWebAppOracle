using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Base tables refered by a query
/// </summary>
public partial class MVIEW__ADV_BASETABLE
{
    public decimal COLLECTIONID_ { get; set; }

    public decimal QUERYID_ { get; set; }

    public string? OWNER { get; set; }

    public string? TABLE_NAME { get; set; }

    public decimal? TABLE_TYPE { get; set; }

    public virtual MVIEW__ADV_WORKLOAD QUERYID_Navigation { get; set; } = null!;
}
