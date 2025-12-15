using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Shared workload repository for DBA users of summary advisor
/// </summary>
public partial class MVIEW__ADV_WORKLOAD
{
    public decimal QUERYID_ { get; set; }

    public decimal COLLECTIONID_ { get; set; }

    public DateTime COLLECTTIME { get; set; }

    public string? APPLICATION { get; set; }

    public decimal? CARDINALITY { get; set; }

    public decimal? RESULTSIZE { get; set; }

    public string UNAME { get; set; } = null!;

    public DateTime? QDATE { get; set; }

    public decimal? PRIORITY { get; set; }

    public decimal? EXEC_TIME { get; set; }

    public string SQL_TEXT { get; set; } = null!;

    public decimal SQL_TEXTLEN { get; set; }

    public decimal? SQL_HASH { get; set; }

    public Guid? SQL_ADDR { get; set; }

    public decimal? FREQUENCY { get; set; }
}
