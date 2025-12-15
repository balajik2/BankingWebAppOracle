using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_EVENTS
{
    public decimal? EVENTID { get; set; }

    public decimal? INSTID { get; set; }

    public decimal? REVISION { get; set; }

    public DateTime? EVENT_TIME { get; set; }

    public string? TYPE { get; set; }

    public decimal? STATUS { get; set; }

    public string? MESSAGE { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
