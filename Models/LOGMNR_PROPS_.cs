using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_PROPS_
{
    public string? VALUE_ { get; set; }

    public string? COMMENT_ { get; set; }

    public string NAME { get; set; } = null!;

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }
}
