using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_ERROR_
{
    public decimal? SESSION_ { get; set; }

    public DateTime? TIME_OF_ERROR { get; set; }

    public decimal? CODE { get; set; }

    public string? MESSAGE { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public string? SPARE4 { get; set; }

    public string? SPARE5 { get; set; }
}
