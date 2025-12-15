using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_LOGMNR_BUILDLOG
{
    public string? BUILD_DATE { get; set; }

    public decimal? DB_TXN_SCNBAS { get; set; }

    public decimal? DB_TXN_SCNWRP { get; set; }

    public decimal? CURRENT_BUILD_STATE { get; set; }

    public decimal? COMPLETION_STATUS { get; set; }

    public decimal? MARKED_LOG_FILE_LOW_SCN { get; set; }

    public string INITIAL_XID { get; set; } = null!;

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }

    public string? CDB_XID { get; set; }

    public decimal? SPARE1 { get; set; }

    public string? SPARE2 { get; set; }
}
