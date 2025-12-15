using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_USER_
{
    public decimal? USER_ { get; set; }

    public string NAME { get; set; } = null!;

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }

    public decimal? SPARE1 { get; set; }
}
