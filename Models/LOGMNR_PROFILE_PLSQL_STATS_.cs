using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_PROFILE_PLSQL_STATS_
{
    public string PKGOWNER { get; set; } = null!;

    public string PKGNAME { get; set; } = null!;

    public decimal NAME { get; set; }

    public decimal? PRAGMAOP { get; set; }

    public decimal? OPNUM { get; set; }

    public decimal? TLSBYUNSUPPOPNUM { get; set; }

    public decimal? OGGUNSUPPOPNUM { get; set; }

    public decimal? REDOSIZE { get; set; }

    public decimal? REDORATE { get; set; }

    public string? SPARE1 { get; set; }

    public string? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public decimal? SPARE4 { get; set; }

    public decimal? SPARE5 { get; set; }

    public decimal? SPARE6 { get; set; }
}
