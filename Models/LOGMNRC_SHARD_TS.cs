using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_SHARD_TS
{
    public decimal LOGMNR_UID { get; set; }

    public string TABLESPACE_NAME { get; set; } = null!;

    public decimal CHUNK_NUMBER { get; set; }

    public decimal START_SCN { get; set; }

    public decimal? DROP_SCN { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
