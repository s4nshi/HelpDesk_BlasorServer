using System;
using System.Collections.Generic;

namespace HelpDesk.Models;

public partial class TypesReq
{
    public int IdT { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<HestoryReq> HestoryReqs { get; set; } = new List<HestoryReq>();

    public virtual ICollection<Requrst> Reqursts { get; set; } = new List<Requrst>();
}
