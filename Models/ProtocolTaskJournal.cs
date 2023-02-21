using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolTaskJournal
{
    public Guid Id { get; set; }

    public Guid ProtocolId { get; set; }

    public long UserEventerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? DescrRu { get; set; }

    public int ProtocolTaskEventId { get; set; }

    public Guid? ProtocolMainId { get; set; }
}
