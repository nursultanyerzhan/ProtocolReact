using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolThematic
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? NameRu { get; set; }

    public string? ProtocolThematicNumber { get; set; }

    public long? AuthorId { get; set; }

    public DateTime? ProtocolThematicDate { get; set; }

    public int ProtocolStatusId { get; set; }

    public bool IsParent { get; set; }

    public int? ProtocolThematicTypeId { get; set; }
}
