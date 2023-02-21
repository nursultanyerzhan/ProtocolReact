using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolFutureStatesByUser
{
    public long Id { get; set; }

    public long Uid { get; set; }

    public int ProtocolFutureDatesForFilterByWeeksId { get; set; }
}
