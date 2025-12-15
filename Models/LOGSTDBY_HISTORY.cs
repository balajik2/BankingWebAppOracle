using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGSTDBY_HISTORY
{
    public decimal? STREAM_SEQUENCE_ { get; set; }

    public decimal? LMNR_SID { get; set; }

    public decimal? DBID { get; set; }

    public decimal? FIRST_CHANGE_ { get; set; }

    public decimal? LAST_CHANGE_ { get; set; }

    public decimal? SOURCE { get; set; }

    public decimal? STATUS { get; set; }

    public DateTime? FIRST_TIME { get; set; }

    public DateTime? LAST_TIME { get; set; }

    public string? DGNAME { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
