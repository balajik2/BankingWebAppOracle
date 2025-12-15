using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Temporary table for workload collections
/// </summary>
public partial class MVIEW__ADV_SQLDEPEND
{
    public decimal? COLLECTIONID_ { get; set; }

    public decimal? INST_ID { get; set; }

    public Guid? FROM_ADDRESS { get; set; }

    public decimal? FROM_HASH { get; set; }

    public string? TO_OWNER { get; set; }

    public string? TO_NAME { get; set; }

    public decimal? TO_TYPE { get; set; }

    public decimal? CARDINALITY { get; set; }
}
