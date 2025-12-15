using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_GSII
{
    public decimal LOGMNR_UID { get; set; }

    public decimal OBJ_ { get; set; }

    public decimal BO_ { get; set; }

    public decimal INDTYPE_ { get; set; }

    public decimal? DROP_SCN { get; set; }

    public decimal? LOGMNR_SPARE1 { get; set; }

    public decimal? LOGMNR_SPARE2 { get; set; }

    public string? LOGMNR_SPARE3 { get; set; }

    public DateTime? LOGMNR_SPARE4 { get; set; }
}
