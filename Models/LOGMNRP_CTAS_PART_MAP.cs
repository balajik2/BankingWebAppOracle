using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRP_CTAS_PART_MAP
{
    public decimal LOGMNR_UID { get; set; }

    public decimal BASEOBJ_ { get; set; }

    public decimal BASEOBJV_ { get; set; }

    public decimal KEYOBJ_ { get; set; }

    public decimal PART_ { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
