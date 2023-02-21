using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolMission
{
    public int Id { get; set; }

    public string? EventName { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public Guid ProtocolMainId { get; set; }

    public DateTime? Dedline { get; set; }

    public int? ProtocolExecutingDateTypeId { get; set; }

    public int ProtocolStatusId { get; set; }

    public long? Author { get; set; }

    public long? Executor { get; set; }

    public long? DeletedBy { get; set; }

    public int? ParentProtocolMissionId { get; set; }

    public long? ProtocolThematicTitleId { get; set; }

    public bool IsExtendedAndDeleted { get; set; }

    public string? MissionColor { get; set; }

    public string? ThematicProtocolInfo { get; set; }

    public string? FreedomNumber { get; set; }

    public bool IsPrivate { get; set; }

    public bool? WasUsedForExecutingDateType { get; set; }

    public bool IsAchivmentSubOrg { get; set; }

    public string? Footnote { get; set; }

    public DateTime? DateForOrder { get; set; }

    public bool? IsDeleted { get; set; }
}
