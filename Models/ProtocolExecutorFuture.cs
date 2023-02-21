using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolExecutorFuture
{
    public int Id { get; set; }

    public long? UserId { get; set; }

    public DateTime? Dedline { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public long ProtocolMissionFutureId { get; set; }

    public int? ProtocolExecutingDateTypeId { get; set; }

    public string? NotUserName { get; set; }

    public string? UserFullNameRu { get; set; }

    public string? UserName { get; set; }

    public string? UserSurName { get; set; }

    public string? UserMiddleName { get; set; }
}
