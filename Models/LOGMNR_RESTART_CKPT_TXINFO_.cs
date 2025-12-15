using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_RESTART_CKPT_TXINFO_
{
    public decimal SESSION_ { get; set; }

    public decimal XIDUSN { get; set; }

    public decimal XIDSLT { get; set; }

    public decimal XIDSQN { get; set; }

    public decimal SESSION_NUM { get; set; }

    public decimal SERIAL_NUM { get; set; }

    public decimal? FLAG { get; set; }

    public decimal? START_SCN { get; set; }

    public decimal EFFECTIVE_SCN { get; set; }

    public decimal? OFFSET { get; set; }

    public byte[]? TX_DATA { get; set; }
}
