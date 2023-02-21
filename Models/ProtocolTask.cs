using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolTask
{
    public Guid Id { get; set; }

    public Guid ProtocolId { get; set; }

    public long UserConfirmerId { get; set; }

    public bool IsConfirmed { get; set; }

    public bool IsApproved { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }
}
