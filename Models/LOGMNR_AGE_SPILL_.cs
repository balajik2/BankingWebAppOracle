using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_AGE_SPILL_
{
    public decimal SESSION_ { get; set; }

    public decimal XIDUSN { get; set; }

    public decimal XIDSLT { get; set; }

    public decimal XIDSQN { get; set; }

    public decimal CHUNK { get; set; }

    public decimal SEQUENCE_ { get; set; }

    public decimal? OFFSET { get; set; }

    public byte[]? SPILL_DATA { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal PDBID { get; set; }
}
