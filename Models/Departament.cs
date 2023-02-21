using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class Departament
{
    public int Id { get; set; }

    public string? DescrRu { get; set; }

    public string? DescrKz { get; set; }

    public string? InfoRu { get; set; }

    public string? InfoKz { get; set; }

    public string? ShortNameRu { get; set; }

    public string? ShortNameKz { get; set; }

    public string Code { get; set; } = null!;

    public Guid? DocGuid { get; set; }

    public bool? IsActive { get; set; }

    public string? ParentCode { get; set; }

    public string? OrgIdAd { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? IntegrId { get; set; }

    public string? IntegrCode { get; set; }

    public virtual ICollection<Position> Positions { get; } = new List<Position>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
