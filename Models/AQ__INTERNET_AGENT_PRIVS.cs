using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class AQ__INTERNET_AGENT_PRIVS
{
    public string AGENT_NAME { get; set; } = null!;

    public string DB_USERNAME { get; set; } = null!;

    public virtual AQ__INTERNET_AGENTS AGENT_NAMENavigation { get; set; } = null!;
}
