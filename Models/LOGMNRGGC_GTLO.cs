using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRGGC_GTLO
{
    public decimal LOGMNR_UID { get; set; }

    public decimal KEYOBJ_ { get; set; }

    public decimal LVLCNT { get; set; }

    public decimal BASEOBJ_ { get; set; }

    public decimal BASEOBJV_ { get; set; }

    public decimal? LVL1OBJ_ { get; set; }

    public decimal? LVL2OBJ_ { get; set; }

    public decimal LVL0TYPE_ { get; set; }

    public decimal? LVL1TYPE_ { get; set; }

    public decimal? LVL2TYPE_ { get; set; }

    public decimal? OWNER_ { get; set; }

    public string OWNERNAME { get; set; } = null!;

    public string LVL0NAME { get; set; } = null!;

    public string? LVL1NAME { get; set; }

    public string? LVL2NAME { get; set; }

    public decimal INTCOLS { get; set; }

    public decimal? COLS { get; set; }

    public decimal? KERNELCOLS { get; set; }

    public decimal? TAB_FLAGS { get; set; }

    public decimal? TRIGFLAG { get; set; }

    public decimal? ASSOC_ { get; set; }

    public decimal? OBJ_FLAGS { get; set; }

    public decimal? TS_ { get; set; }

    public string? TSNAME { get; set; }

    public decimal? PROPERTY { get; set; }

    public decimal START_SCN { get; set; }

    public decimal? DROP_SCN { get; set; }

    public decimal? XIDUSN { get; set; }

    public decimal? XIDSLT { get; set; }

    public decimal? XIDSQN { get; set; }

    public decimal? FLAGS { get; set; }

    public decimal? LOGMNR_SPARE1 { get; set; }

    public decimal? LOGMNR_SPARE2 { get; set; }

    public string? LOGMNR_SPARE3 { get; set; }

    public DateTime? LOGMNR_SPARE4 { get; set; }

    public decimal? LOGMNR_SPARE5 { get; set; }

    public decimal? LOGMNR_SPARE6 { get; set; }

    public decimal? LOGMNR_SPARE7 { get; set; }

    public decimal? LOGMNR_SPARE8 { get; set; }

    public decimal? LOGMNR_SPARE9 { get; set; }

    public decimal? PARTTYPE { get; set; }

    public decimal? SUBPARTTYPE { get; set; }

    public decimal? UNSUPPORTEDCOLS { get; set; }

    public decimal? COMPLEXTYPECOLS { get; set; }

    public decimal? NTPARENTOBJNUM { get; set; }

    public decimal? NTPARENTOBJVERSION { get; set; }

    public decimal? NTPARENTINTCOLNUM { get; set; }

    public decimal? LOGMNRTLOFLAGS { get; set; }

    public string? LOGMNRMCV { get; set; }

    public decimal? ACDRFLAGS { get; set; }

    public decimal? ACDRTSOBJ_ { get; set; }

    public decimal? ACDRROWTSINTCOL_ { get; set; }
}
