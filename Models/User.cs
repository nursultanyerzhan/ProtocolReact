using System;
using System.Collections.Generic;

namespace ProtocolReact.Models;

public partial class User
{
    public long Uid { get; set; }

    public int PositionId { get; set; }

    public string DepartmentId { get; set; } = null!;

    public string? SurnameRu { get; set; }

    public string? SurnameKz { get; set; }

    public string? NameRu { get; set; }

    public string? NameKz { get; set; }

    public string? FullNameRu { get; set; }

    public string? FullNameKz { get; set; }

    public string? PhoneNumber { get; set; }

    public string? MobileNumber { get; set; }

    public string? OfficeNumber { get; set; }

    public string? DutyReason { get; set; }

    public DateTime? EmploymentDate { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? PhotoLink { get; set; }

    public string? FireReason { get; set; }

    public string? Email { get; set; }

    public long? BuildingId { get; set; }

    public int? RoleId { get; set; }

    public string? InfoRu { get; set; }

    public string? InfoKz { get; set; }

    public bool? IsMale { get; set; }

    public string? AccountName { get; set; }

    public DateTime? FiredDate { get; set; }

    public bool? IsActive { get; set; }

    public Guid? GuidInstruction { get; set; }

    public string? FileNameInstruction { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime ChangedDateTime { get; set; }

    public Guid? ResponsibilityDocKz { get; set; }

    public Guid? ResponsibilityDocRu { get; set; }

    public bool? NoNeedToSentLotus { get; set; }

    public string? EmpShortNameRu { get; set; }

    public string? EmpShortNameKz { get; set; }

    public string? OrgIdAd { get; set; }

    public long? SkudId { get; set; }

    public int? IntegrId { get; set; }

    public string? MiddleNameRu { get; set; }

    public string? MiddleNameKz { get; set; }

    public string? Iin { get; set; }

    public long? SkudId2 { get; set; }

    public bool IsHideLd { get; set; }

    public virtual Departament Department { get; set; } = null!;

    public virtual Position Position { get; set; } = null!;
}
