using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolAttachmentBackupIntegrationInfo
{
    public Guid Id { get; set; }

    public Guid ProtocolAttachmentId { get; set; }

    public DateTime CreatedDate { get; set; }
}
