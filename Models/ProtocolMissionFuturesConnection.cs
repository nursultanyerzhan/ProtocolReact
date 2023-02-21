using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolMissionFuturesConnection
{
    public long Id { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ProtocolMissionId { get; set; }

    public long ProtocolMissionFutureId { get; set; }
}
