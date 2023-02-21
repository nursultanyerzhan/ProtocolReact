using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolExecutor1
{
    public long Id { get; set; }

    public long? Uid { get; set; }

    public DateTime? Dedline { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int ProtocolMissionId { get; set; }

    public int? ProtocolExecutingDateTypeId { get; set; }

    public string? NotUserName { get; set; }

    public string? UserNameInitial { get; set; }

    public string? DedlineStringFormat { get; set; }

    public bool DisableToShow { get; set; }
}
