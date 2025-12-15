using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_CONNECTIONS
{
    public decimal? SOURCE_RDBID { get; set; }

    public decimal? DEST_RDBID { get; set; }

    public decimal? ATTRIBUTES { get; set; }

    public string? SERVICE_NAME { get; set; }

    public decimal? CONN_HANDLE { get; set; }

    public DateTime? CONNECT_TIME { get; set; }

    public DateTime? SEND_TIME { get; set; }

    public DateTime? DISCONNECT_TIME { get; set; }

    public DateTime? UPDATE_TIME { get; set; }

    public decimal? SOURCE_PID { get; set; }

    public decimal? DEST_PID { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
