using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolThematicExecutor
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public string? NotUserName { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public long ProtocolThematicMissionId { get; set; }

    public int? ProtocolExecutingDateTypeId { get; set; }

    public DateTime? DeadLine { get; set; }
}
