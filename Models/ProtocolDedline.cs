using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolDedline
{
    public Guid Id { get; set; }

    public DateTime Dedline { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ProtocolMissionId { get; set; }
}
