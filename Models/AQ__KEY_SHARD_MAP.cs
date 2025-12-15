using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class AQ__KEY_SHARD_MAP
{
    public decimal QUEUE { get; set; }

    public string KEY { get; set; } = null!;

    public decimal SHARD { get; set; }

    public decimal DELAY_SHARD { get; set; }
}
