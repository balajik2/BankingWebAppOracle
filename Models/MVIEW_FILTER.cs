using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class MVIEW_FILTER
{
    public decimal FILTERID { get; set; }

    public decimal SUBFILTERNUM { get; set; }

    public string? SUBFILTERTYPE { get; set; }

    public string? STR_VALUE { get; set; }

    public decimal? NUM_VALUE1 { get; set; }

    public decimal? NUM_VALUE2 { get; set; }

    public DateTime? DATE_VALUE1 { get; set; }

    public DateTime? DATE_VALUE2 { get; set; }
}
