using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class AQ__SCHEDULES
{
    public Guid OID { get; set; }

    public string DESTINATION { get; set; } = null!;

    public DateTime? START_TIME { get; set; }

    public string? DURATION { get; set; }

    public string? NEXT_TIME { get; set; }

    public string? LATENCY { get; set; }

    public DateTime? LAST_TIME { get; set; }

    public decimal? JOBNO { get; set; }
}
