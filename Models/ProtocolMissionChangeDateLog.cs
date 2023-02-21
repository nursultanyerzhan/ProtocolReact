using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolMissionChangeDateLog
{
    public long Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ProtocolMissionId { get; set; }

    public DateTime? Dedline { get; set; }

    public string? Notice { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? Resolution { get; set; }

    public DateTime? ResolutionDate { get; set; }

    public string? ActionAuthorAndDate { get; set; }

    public long? Uid { get; set; }

    public string? ActionInformation { get; set; }

    public long? ProtocolMissionFutureId { get; set; }
}
