using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolRole
{
    public int Id { get; set; }

    public long UserId { get; set; }

    public int ProtocolRoleTypeId { get; set; }
}
