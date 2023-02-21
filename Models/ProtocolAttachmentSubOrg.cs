using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolAttachmentSubOrg
{
    public Guid Id { get; set; }

    public string? FileName { get; set; }

    public int? ProtocolMissionId { get; set; }

    public long? AuthorId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public byte[]? FileContent { get; set; }
}
