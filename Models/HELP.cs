using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class HELP
{
    public string TOPIC { get; set; } = null!;

    public decimal SEQ { get; set; }

    public string? INFO { get; set; }
}
