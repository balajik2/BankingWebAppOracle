using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_CON_
{
    public decimal OWNER_ { get; set; }

    public string NAME { get; set; } = null!;

    public decimal CON_ { get; set; }

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }

    public decimal? START_SCNBAS { get; set; }

    public decimal? START_SCNWRP { get; set; }
}
