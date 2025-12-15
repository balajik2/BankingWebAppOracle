using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_IND_GG
{
    public decimal LOGMNR_UID { get; set; }

    public decimal OBJ_ { get; set; }

    public string NAME { get; set; } = null!;

    public decimal COMMIT_SCN { get; set; }

    public decimal? DROP_SCN { get; set; }

    public decimal BASEOBJ_ { get; set; }

    public decimal BASEOBJV_ { get; set; }

    public decimal FLAGS { get; set; }

    public decimal OWNER_ { get; set; }

    public string OWNERNAME { get; set; } = null!;

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public string? SPARE4 { get; set; }

    public string? SPARE5 { get; set; }

    public string? SPARE6 { get; set; }
}
