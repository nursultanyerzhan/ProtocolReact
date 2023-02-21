using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolFutureDatesForFilterByWeek
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public bool HasProtocolMissionFuture { get; set; }
}
