using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGSTDBY_APPLY_MILESTONE
{
    public decimal SESSION_ID { get; set; }

    public decimal COMMIT_SCN { get; set; }

    public DateTime? COMMIT_TIME { get; set; }

    public decimal SYNCH_SCN { get; set; }

    public decimal EPOCH { get; set; }

    public decimal PROCESSED_SCN { get; set; }

    public DateTime? PROCESSED_TIME { get; set; }

    public decimal FETCHLWM_SCN { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }

    public decimal? FLAGS { get; set; }

    public DateTime? LWM_UPD_TIME { get; set; }

    public decimal? SPARE4 { get; set; }

    public decimal? SPARE5 { get; set; }

    public decimal? SPARE6 { get; set; }

    public DateTime? SPARE7 { get; set; }

    public decimal? PTO_RECOVERY_SCN { get; set; }

    public decimal? PTO_RECOVERY_INCARNATION { get; set; }
}
