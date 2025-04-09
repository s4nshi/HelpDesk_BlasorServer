using System;
using System.Collections.Generic;

namespace HelpDesk.Models;

public partial class Suplier
{
    public int IdSup { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<HestoryReq> HestoryReqs { get; set; } = new List<HestoryReq>();

    public virtual ICollection<Requrst> Reqursts { get; set; } = new List<Requrst>();
}
