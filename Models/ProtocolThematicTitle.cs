using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolThematicTitle
{
    public long Id { get; set; }

    public Guid ProtocolThematicId { get; set; }

    public string? NameRu { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public long? AuthorId { get; set; }

    public int? Rang { get; set; }
}
