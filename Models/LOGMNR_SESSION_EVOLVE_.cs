using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_SESSION_EVOLVE_
{
    public decimal? BRANCH_LEVEL { get; set; }

    public decimal SESSION_ { get; set; }

    public decimal DB_ID { get; set; }

    public decimal RESET_SCN { get; set; }

    public decimal RESET_TIMESTAMP { get; set; }

    public decimal? PREV_RESET_SCN { get; set; }

    public decimal? PREV_RESET_TIMESTAMP { get; set; }

    public decimal? STATUS { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public DateTime? SPARE4 { get; set; }
}
