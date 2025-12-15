using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Table for workload filter instance definition
/// </summary>
public partial class MVIEW__ADV_FILTERINSTANCE
{
    public decimal RUNID_ { get; set; }

    public decimal? FILTERID_ { get; set; }

    public decimal? SUBFILTERNUM_ { get; set; }

    public decimal? SUBFILTERTYPE { get; set; }

    public string? STR_VALUE { get; set; }

    public decimal? NUM_VALUE1 { get; set; }

    public decimal? NUM_VALUE2 { get; set; }

    public DateTime? DATE_VALUE1 { get; set; }

    public DateTime? DATE_VALUE2 { get; set; }

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
