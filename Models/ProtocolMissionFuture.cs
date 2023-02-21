using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolMissionFuture
{
    public long Id { get; set; }

    public string EventName { get; set; } = null!;

    public string DepartmentCode { get; set; } = null!;

    public DateTime Dedline { get; set; }

    public bool IsAddedToProtocolMission { get; set; }

    public bool IsLongTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? ProtocolExecutingDateTypeId { get; set; }

    public long? Author { get; set; }

    public long? DeletedBy { get; set; }

    public int? ParentProtocolMissionId { get; set; }

    public int? ChildProtocolMissionId { get; set; }

    public string? Footnote { get; set; }

    public int? Status { get; set; }

    public long? ExecutorUid { get; set; }
}
