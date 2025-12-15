using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class MVIEW_WORKLOAD
{
    public decimal WORKLOADID { get; set; }

    public DateTime IMPORT_TIME { get; set; }

    public decimal QUERYID { get; set; }

    public string? APPLICATION { get; set; }

    public decimal? CARDINALITY { get; set; }

    public decimal? RESULTSIZE { get; set; }

    public DateTime? LASTUSE { get; set; }

    public decimal? FREQUENCY { get; set; }

    public string OWNER { get; set; } = null!;

    public decimal? PRIORITY { get; set; }

    public string QUERY { get; set; } = null!;

    public decimal? RESPONSETIME { get; set; }
}
