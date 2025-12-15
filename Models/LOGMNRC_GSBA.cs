using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_GSBA
{
    public decimal LOGMNR_UID { get; set; }

    public decimal AS_OF_SCN { get; set; }

    public decimal? FDO_LENGTH { get; set; }

    public byte[]? FDO_VALUE { get; set; }

    public decimal? CHARSETID { get; set; }

    public decimal? NCHARSETID { get; set; }

    public decimal? DBTIMEZONE_LEN { get; set; }

    public string? DBTIMEZONE_VALUE { get; set; }

    public decimal? LOGMNR_SPARE1 { get; set; }

    public decimal? LOGMNR_SPARE2 { get; set; }

    public string? LOGMNR_SPARE3 { get; set; }

    public DateTime? LOGMNR_SPARE4 { get; set; }

    public string? DB_GLOBAL_NAME { get; set; }
}
