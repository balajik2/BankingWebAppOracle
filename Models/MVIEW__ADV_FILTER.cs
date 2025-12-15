using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Table for workload filter definition
/// </summary>
public partial class MVIEW__ADV_FILTER
{
    public decimal FILTERID_ { get; set; }

    public decimal SUBFILTERNUM_ { get; set; }

    public decimal SUBFILTERTYPE { get; set; }

    public string? STR_VALUE { get; set; }

    public decimal? NUM_VALUE1 { get; set; }

    public decimal? NUM_VALUE2 { get; set; }

    public DateTime? DATE_VALUE1 { get; set; }

    public DateTime? DATE_VALUE2 { get; set; }
}
