using System;
using System.Collections.Generic;

namespace HelpDesk.Models;

public partial class Requrst
{
    public int IdReq { get; set; }

    public int? IdTypeReq { get; set; }

    public int? IdPrior { get; set; }

    public int? IdStatus { get; set; }

    public int? IdUser { get; set; }

    public int? IdSupe { get; set; }

    public DateTime? Datee { get; set; }

    public string? Comment { get; set; }

    public virtual Status? IdPriorNavigation { get; set; }

    public virtual Priority? IdStatusNavigation { get; set; }

    public virtual Suplier? IdSupeNavigation { get; set; }

    public virtual TypesReq? IdTypeReqNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
