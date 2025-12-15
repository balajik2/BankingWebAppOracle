using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_KOPM_
{
    public decimal? LENGTH { get; set; }

    public byte[]? METADATA { get; set; }

    public string NAME { get; set; } = null!;

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }
}
