using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class ProtocolDepartment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DepartmentCode { get; set; } = null!;

    public int? Level { get; set; }
}
