using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class AQ__QUEUES
{
    public Guid OID { get; set; }

    public decimal EVENTID { get; set; }

    public string NAME { get; set; } = null!;

    public decimal TABLE_OBJNO { get; set; }

    public decimal USAGE { get; set; }

    public decimal ENABLE_FLAG { get; set; }

    public decimal? MAX_RETRIES { get; set; }

    public decimal? RETRY_DELAY { get; set; }

    public decimal? PROPERTIES { get; set; }

    public decimal? RET_TIME { get; set; }

    public string? QUEUE_COMMENT { get; set; }

    public decimal? MEMORY_THRESHOLD { get; set; }

    public string? SERVICE_NAME { get; set; }

    public string? NETWORK_NAME { get; set; }

    public Guid? SUB_OID { get; set; }

    public decimal? SHARDED { get; set; }

    public decimal? BASE_QUEUE { get; set; }
}
