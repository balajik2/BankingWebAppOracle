using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Output table for summary recommendations and evaluations
/// </summary>
public partial class MVIEW__ADV_OUTPUT
{
    public decimal RUNID_ { get; set; }

    public decimal OUTPUT_TYPE { get; set; }

    public decimal RANK_ { get; set; }

    public string? ACTION_TYPE { get; set; }

    public string? SUMMARY_OWNER { get; set; }

    public string? SUMMARY_NAME { get; set; }

    public string? GROUP_BY_COLUMNS { get; set; }

    public string? WHERE_CLAUSE { get; set; }

    public string? FROM_CLAUSE { get; set; }

    public string? MEASURES_LIST { get; set; }

    public string? FACT_TABLES { get; set; }

    public string? GROUPING_LEVELS { get; set; }

    public decimal? QUERYLEN { get; set; }

    public string? QUERY_TEXT { get; set; }

    public decimal? STORAGE_IN_BYTES { get; set; }

    public decimal? PCT_PERFORMANCE_GAIN { get; set; }

    public decimal? FREQUENCY { get; set; }

    public decimal? CUMULATIVE_BENEFIT { get; set; }

    public decimal BENEFIT_TO_COST_RATIO { get; set; }

    public decimal? VALIDATED { get; set; }

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
