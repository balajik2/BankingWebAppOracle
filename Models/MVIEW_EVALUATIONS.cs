using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class MVIEW_EVALUATIONS
{
    public decimal RUNID { get; set; }

    public string? MVIEW_OWNER { get; set; }

    public string? MVIEW_NAME { get; set; }

    public decimal RANK { get; set; }

    public decimal? STORAGE_IN_BYTES { get; set; }

    public decimal? FREQUENCY { get; set; }

    public decimal? CUMULATIVE_BENEFIT { get; set; }

    public decimal BENEFIT_TO_COST_RATIO { get; set; }
}
