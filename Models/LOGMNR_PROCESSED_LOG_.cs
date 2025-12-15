using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_PROCESSED_LOG_
{
    public decimal SESSION_ { get; set; }

    public decimal THREAD_ { get; set; }

    public decimal? SEQUENCE_ { get; set; }

    public decimal? FIRST_CHANGE_ { get; set; }

    public decimal? NEXT_CHANGE_ { get; set; }

    public DateTime? FIRST_TIME { get; set; }

    public DateTime? NEXT_TIME { get; set; }

    public string? FILE_NAME { get; set; }

    public decimal? STATUS { get; set; }

    public string? INFO { get; set; }

    public DateTime? TIMESTAMP { get; set; }
}
