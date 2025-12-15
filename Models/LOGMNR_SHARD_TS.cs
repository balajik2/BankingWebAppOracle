using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_SHARD_TS
{
    public decimal LOGMNR_UID { get; set; }

    public string TABLESPACE_NAME { get; set; } = null!;

    public decimal CHUNK_NUMBER { get; set; }

    public decimal? START_SCNBAS { get; set; }

    public decimal? START_SCNWRP { get; set; }
}
