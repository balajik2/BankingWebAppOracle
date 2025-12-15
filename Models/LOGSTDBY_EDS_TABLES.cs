using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGSTDBY_EDS_TABLES
{
    public string OWNER { get; set; } = null!;

    public string TABLE_NAME { get; set; } = null!;

    public string? SHADOW_TABLE_NAME { get; set; }

    public string? BASE_TRIGGER_NAME { get; set; }

    public string? SHADOW_TRIGGER_NAME { get; set; }

    public string? DBLINK { get; set; }

    public decimal? FLAGS { get; set; }

    public string? STATE { get; set; }

    public decimal? OBJV { get; set; }

    public decimal? OBJ_ { get; set; }

    public decimal? SOBJ_ { get; set; }

    public DateTime? CTIME { get; set; }

    public decimal? SPARE1 { get; set; }

    public string? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public string? MVIEW_NAME { get; set; }

    public string? MVIEW_LOG_NAME { get; set; }

    public string? MVIEW_TRIGGER_NAME { get; set; }
}
