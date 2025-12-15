using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_INDCOL_GG
{
    public decimal LOGMNR_UID { get; set; }

    public decimal OBJ_ { get; set; }

    public decimal COMMIT_SCN { get; set; }

    public decimal INTCOL_ { get; set; }

    public decimal POS_ { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
