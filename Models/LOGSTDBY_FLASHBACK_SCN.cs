using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGSTDBY_FLASHBACK_SCN
{
    public decimal PRIMARY_SCN { get; set; }

    public DateTime? PRIMARY_TIME { get; set; }

    public decimal? STANDBY_SCN { get; set; }

    public DateTime? STANDBY_TIME { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public DateTime? SPARE3 { get; set; }
}
