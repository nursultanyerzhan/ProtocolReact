using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolMain
{
    public Guid Id { get; set; }

    public string? NameRu { get; set; }

    public DateTime CreatedDate { get; set; }

    public string DepatmentId { get; set; } = null!;

    public int ProtocolStatusId { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? ConfirmerId { get; set; }

    public bool IsConfirmed { get; set; }

    public Guid? ProtocolId { get; set; }

    public long? SenderId { get; set; }
}
