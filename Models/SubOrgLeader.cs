using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class SubOrgLeader
{
    public int Id { get; set; }

    public string? FullNameRu { get; set; }

    public string? PositionNameRu { get; set; }

    public long? Uid { get; set; }

    public string? ShortName { get; set; }

    public bool? IsDirector { get; set; }
}
