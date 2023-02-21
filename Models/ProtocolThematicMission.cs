using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolThematicMission
{
    public long Id { get; set; }

    public string? EventName { get; set; }

    public long ProtocolThematicTitleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? DeadLine { get; set; }

    public DateTime? DeadLine2 { get; set; }

    public int? ProtocolExecutingDateTypeId { get; set; }

    public bool IsAddedToProtocolMission { get; set; }

    public long? AuthorId { get; set; }

    public long? UserId { get; set; }

    public int? ProtocolMissionId { get; set; }

    public int ProtocolStatusId { get; set; }

    public bool IsPrivate { get; set; }

    public string? FreedomNumber { get; set; }
}
