using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_ENC_
{
    public decimal? OBJ_ { get; set; }

    public decimal? OWNER_ { get; set; }

    public decimal? ENCALG { get; set; }

    public decimal? INTALG { get; set; }

    public byte[]? COLKLC { get; set; }

    public decimal? KLCLEN { get; set; }

    public decimal? FLAG { get; set; }

    public string MKEYID { get; set; } = null!;

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }
}
