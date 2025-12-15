using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class MVIEW_LOG
{
    public decimal ID { get; set; }

    public decimal? FILTERID { get; set; }

    public DateTime? RUN_BEGIN { get; set; }

    public DateTime? RUN_END { get; set; }

    public string? TYPE { get; set; }

    public string? STATUS { get; set; }

    public string? MESSAGE { get; set; }

    public decimal? COMPLETED { get; set; }

    public decimal? TOTAL { get; set; }

    public string? ERROR_CODE { get; set; }
}
