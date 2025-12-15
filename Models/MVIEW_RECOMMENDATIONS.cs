using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class MVIEW_RECOMMENDATIONS
{
    public decimal RUNID { get; set; }

    public string? ALL_TABLES { get; set; }

    public string? FACT_TABLES { get; set; }

    public string? GROUPING_LEVELS { get; set; }

    public string? QUERY_TEXT { get; set; }

    public decimal RECOMMENDATION_NUMBER { get; set; }

    public string? RECOMMENDED_ACTION { get; set; }

    public string? MVIEW_OWNER { get; set; }

    public string? MVIEW_NAME { get; set; }

    public decimal? STORAGE_IN_BYTES { get; set; }

    public decimal? PCT_PERFORMANCE_GAIN { get; set; }

    public decimal BENEFIT_TO_COST_RATIO { get; set; }
}
