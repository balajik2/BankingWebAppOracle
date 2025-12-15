using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_USER
{
    public decimal LOGMNR_UID { get; set; }

    public decimal USER_ { get; set; }

    public decimal? SPARE1 { get; set; }

    public string NAME { get; set; } = null!;

    public decimal START_SCN { get; set; }

    public decimal? DROP_SCN { get; set; }

    public decimal? SPARE1_C { get; set; }

    public decimal? SPARE2_C { get; set; }

    public string? SPARE3_C { get; set; }
}
