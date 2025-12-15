using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_RESTART_CKPT_
{
    public decimal SESSION_ { get; set; }

    public decimal? VALID { get; set; }

    public decimal CKPT_SCN { get; set; }

    public decimal XIDUSN { get; set; }

    public decimal XIDSLT { get; set; }

    public decimal XIDSQN { get; set; }

    public decimal SESSION_NUM { get; set; }

    public decimal SERIAL_NUM { get; set; }

    public byte[]? CKPT_INFO { get; set; }

    public decimal? FLAG { get; set; }

    public decimal? OFFSET { get; set; }

    public byte[]? CLIENT_DATA { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal PDBID { get; set; }
}
