using System;
using System.Collections.Generic;

namespace HelpDesk.Models;

public partial class Admin
{
    public int IdAd { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }
}
