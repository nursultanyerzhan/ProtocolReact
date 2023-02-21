using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolTaskEvent
{
    public int Id { get; set; }

    public string EventName { get; set; } = null!;
}
