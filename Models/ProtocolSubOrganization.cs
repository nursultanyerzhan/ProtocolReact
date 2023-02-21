using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolSubOrganization
{
    public long Id { get; set; }

    public int ProtocolMissionId { get; set; }

    public long Uid { get; set; }

    public bool IsThematic { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? ArchivatedDate { get; set; }

    public long? ParentId { get; set; }

    public bool IsUserResponsible { get; set; }

    public string? Text { get; set; }

    public DateTime DeathLine { get; set; }

    public int InternalStatus { get; set; }
}
