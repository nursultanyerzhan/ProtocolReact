using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolUserAction
{
    public Guid Id { get; set; }

    public long Uid { get; set; }

    public int ProtocolUserActionTypeId { get; set; }

    public DateTime ActionDate { get; set; }

    public string? Description { get; set; }

    public string? ObjectId { get; set; }

    public string? UserHostAddress { get; set; }
}
