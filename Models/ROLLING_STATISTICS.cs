using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_STATISTICS
{
    public decimal? STATID { get; set; }

    public decimal? RDBID { get; set; }

    public decimal? ATTRIBUTES { get; set; }

    public decimal? TYPE { get; set; }

    public string? NAME { get; set; }

    public string? VALUESTR { get; set; }

    public decimal? VALUENUM { get; set; }

    public DateTime? VALUETS { get; set; }

    public TimeSpan? VALUEINT { get; set; }

    public DateTime? UPDATE_TIME { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
