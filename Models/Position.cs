using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class Position
{
    public int Id { get; set; }

    public int? Rang { get; set; }

    public int? IntegrRang { get; set; }

    public string? DescrRu { get; set; }

    public string? DescrKz { get; set; }

    public int? CategoryId { get; set; }

    public int? Rdlorder { get; set; }

    public int? ParentPosId { get; set; }

    public string? DepId { get; set; }

    public string? OrgIdAd { get; set; }

    public int? IntegrId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? Rang2022 { get; set; }

    public virtual Departament? Dep { get; set; }

    public virtual ICollection<Position> InverseParentPos { get; } = new List<Position>();

    public virtual Position? ParentPos { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
