using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_SESSION_
{
    public decimal SESSION_ { get; set; }

    public decimal? CLIENT_ { get; set; }

    public string SESSION_NAME { get; set; } = null!;

    public decimal? DB_ID { get; set; }

    public decimal? RESETLOGS_CHANGE_ { get; set; }

    public decimal? SESSION_ATTR { get; set; }

    public string? SESSION_ATTR_VERBOSE { get; set; }

    public decimal? START_SCN { get; set; }

    public decimal? END_SCN { get; set; }

    public decimal? SPILL_SCN { get; set; }

    public DateTime? SPILL_TIME { get; set; }

    public decimal? OLDEST_SCN { get; set; }

    public decimal? RESUME_SCN { get; set; }

    public string? GLOBAL_DB_NAME { get; set; }

    public decimal? RESET_TIMESTAMP { get; set; }

    public decimal? BRANCH_SCN { get; set; }

    public string? VERSION { get; set; }

    public string? REDO_COMPAT { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? PURGE_SCN { get; set; }

    public decimal? SPARE3 { get; set; }

    public decimal? SPARE4 { get; set; }

    public decimal? SPARE5 { get; set; }

    public DateTime? SPARE6 { get; set; }

    public string? SPARE7 { get; set; }

    public string? SPARE8 { get; set; }

    public decimal? SPARE9 { get; set; }
}
