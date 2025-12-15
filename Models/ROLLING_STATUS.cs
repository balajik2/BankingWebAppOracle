using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_STATUS
{
    public decimal? REVISION { get; set; }

    public decimal? PHASE { get; set; }

    public decimal? BATCHID { get; set; }

    public decimal? STATUS { get; set; }

    public decimal? COORDID { get; set; }

    public decimal? OPRIMARY { get; set; }

    public decimal? FPRIMARY { get; set; }

    public decimal? PID { get; set; }

    public decimal? INSTANCE { get; set; }

    public decimal? DBTOTAL { get; set; }

    public decimal? DBACTIVE { get; set; }

    public string? LOCATION { get; set; }

    public DateTime? INIT_TIME { get; set; }

    public DateTime? BUILD_TIME { get; set; }

    public DateTime? START_TIME { get; set; }

    public DateTime? SWITCH_TIME { get; set; }

    public DateTime? FINISH_TIME { get; set; }

    public decimal? LAST_INSTID { get; set; }

    public decimal? LAST_BATCHID { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
