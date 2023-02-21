using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolResolution
{
    public long Id { get; set; }

    public string? NameRu { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? AuthorId { get; set; }

    public int ProtocolMissionId { get; set; }

    public DateTime? DeadLine { get; set; }

    public bool? IsNew { get; set; }
}
