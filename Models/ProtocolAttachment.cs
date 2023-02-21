using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolAttachment
{
    public Guid Id { get; set; }

    public string? FileName { get; set; }

    public byte[]? FileContent { get; set; }

    public int ProtocolMissionId { get; set; }

    public long AuthorId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool? IsAttachedToLog { get; set; }

    public bool IsAttachedBySubOrg { get; set; }
}
