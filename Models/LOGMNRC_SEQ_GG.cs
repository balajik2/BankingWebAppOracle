using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_SEQ_GG
{
    public decimal LOGMNR_UID { get; set; }

    public decimal OBJ_ { get; set; }

    public decimal COMMIT_SCN { get; set; }

    public decimal? DROP_SCN { get; set; }

    public decimal SEQ_FLAGS { get; set; }

    public decimal OWNER_ { get; set; }

    public string OWNERNAME { get; set; } = null!;

    public string OBJNAME { get; set; } = null!;

    public decimal? SEQCACHE { get; set; }

    public decimal? SEQINC { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }

    public string? SPARE4 { get; set; }
}
