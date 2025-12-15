using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class REPL_SUPPORT_MATRIX
{
    public string? FEATURE_NAME { get; set; }

    public decimal? REASON_CODE { get; set; }

    public decimal BMAP1 { get; set; }

    public decimal BMAP2 { get; set; }

    public decimal REPL_PRODUCT { get; set; }

    public decimal SUPPORT_MODE { get; set; }

    public decimal? MIN_COMPAT { get; set; }

    public decimal? MAX_COMPAT { get; set; }
}
