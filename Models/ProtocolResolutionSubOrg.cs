using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolResolutionSubOrg
{
    public long Id { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? AuthorId { get; set; }

    public int? ProtocolMissionId { get; set; }

    public long? DirectorUid { get; set; }

    public string? Number { get; set; }

    public DateTime? Date { get; set; }

    public string? Comment { get; set; }
}
