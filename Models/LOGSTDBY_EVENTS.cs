using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGSTDBY_EVENTS
{
    public DateTime EVENT_TIME { get; set; }

    public decimal? CURRENT_SCN { get; set; }

    public decimal? COMMIT_SCN { get; set; }

    public decimal? XIDUSN { get; set; }

    public decimal? XIDSLT { get; set; }

    public decimal? XIDSQN { get; set; }

    public decimal? ERRVAL { get; set; }

    public string? EVENT { get; set; }

    public string? FULL_EVENT { get; set; }

    public string? ERROR { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }

    public string? CON_NAME { get; set; }

    public decimal? CON_ID { get; set; }
}
