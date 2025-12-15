using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGSTDBY_APPLY_PROGRESS
{
    public decimal? XIDUSN { get; set; }

    public decimal? XIDSLT { get; set; }

    public decimal? XIDSQN { get; set; }

    public decimal? COMMIT_SCN { get; set; }

    public DateTime? COMMIT_TIME { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
