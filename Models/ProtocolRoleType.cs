using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolRoleType
{
    public int Id { get; set; }

    public string NameRu { get; set; } = null!;

    public string? DescrRu { get; set; }
}
