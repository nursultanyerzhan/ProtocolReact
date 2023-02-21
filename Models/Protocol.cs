using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class Protocol
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? ProtocolNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? MeetingDay { get; set; }

    public long? ChancellerId { get; set; }

    public int StatusId { get; set; }

    public string? Comment { get; set; }

    public bool IsActual { get; set; }
}
