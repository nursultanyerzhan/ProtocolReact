using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProtocolReact.Models;

public partial class WebPortalContext : DbContext
{
    public WebPortalContext()
    {
    }

    public WebPortalContext(DbContextOptions<WebPortalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departament> Departaments { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Protocol> Protocols { get; set; }

    public virtual DbSet<ProtocolAttachment> ProtocolAttachments { get; set; }

    public virtual DbSet<ProtocolAttachmentBackupIntegrationInfo> ProtocolAttachmentBackupIntegrationInfos { get; set; }

    public virtual DbSet<ProtocolAttachmentSubOrg> ProtocolAttachmentSubOrgs { get; set; }

    public virtual DbSet<ProtocolDedline> ProtocolDedlines { get; set; }

    public virtual DbSet<ProtocolDepartment> ProtocolDepartments { get; set; }

    public virtual DbSet<ProtocolExecutingDateType> ProtocolExecutingDateTypes { get; set; }

    public virtual DbSet<ProtocolExecutor> ProtocolExecutors { get; set; }

    public virtual DbSet<ProtocolExecutor1> ProtocolExecutors1 { get; set; }

    public virtual DbSet<ProtocolExecutorFuture> ProtocolExecutorFutures { get; set; }

    public virtual DbSet<ProtocolFutureDatesForFilterByWeek> ProtocolFutureDatesForFilterByWeeks { get; set; }

    public virtual DbSet<ProtocolFutureStatesByUser> ProtocolFutureStatesByUsers { get; set; }

    public virtual DbSet<ProtocolInternalStatus> ProtocolInternalStatuses { get; set; }

    public virtual DbSet<ProtocolMain> ProtocolMains { get; set; }

    public virtual DbSet<ProtocolMission> ProtocolMissions { get; set; }

    public virtual DbSet<ProtocolMissionChangeDateLog> ProtocolMissionChangeDateLogs { get; set; }

    public virtual DbSet<ProtocolMissionFuture> ProtocolMissionFutures { get; set; }

    public virtual DbSet<ProtocolMissionFuturesConnection> ProtocolMissionFuturesConnections { get; set; }

    public virtual DbSet<ProtocolResolution> ProtocolResolutions { get; set; }

    public virtual DbSet<ProtocolResolutionSubOrg> ProtocolResolutionSubOrgs { get; set; }

    public virtual DbSet<ProtocolRole> ProtocolRoles { get; set; }

    public virtual DbSet<ProtocolRoleType> ProtocolRoleTypes { get; set; }

    public virtual DbSet<ProtocolStatus> ProtocolStatuses { get; set; }

    public virtual DbSet<ProtocolSubConfirmer> ProtocolSubConfirmers { get; set; }

    public virtual DbSet<ProtocolSubOrganization> ProtocolSubOrganizations { get; set; }

    public virtual DbSet<ProtocolTask> ProtocolTasks { get; set; }

    public virtual DbSet<ProtocolTaskEvent> ProtocolTaskEvents { get; set; }

    public virtual DbSet<ProtocolTaskJournal> ProtocolTaskJournals { get; set; }

    public virtual DbSet<ProtocolThematic> ProtocolThematics { get; set; }

    public virtual DbSet<ProtocolThematicExecutor> ProtocolThematicExecutors { get; set; }

    public virtual DbSet<ProtocolThematicMission> ProtocolThematicMissions { get; set; }

    public virtual DbSet<ProtocolThematicTitle> ProtocolThematicTitles { get; set; }

    public virtual DbSet<ProtocolThematicType> ProtocolThematicTypes { get; set; }

    public virtual DbSet<ProtocolUserAction> ProtocolUserActions { get; set; }

    public virtual DbSet<ProtocolUserActionType> ProtocolUserActionTypes { get; set; }

    public virtual DbSet<SubOrgLeader> SubOrgLeaders { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Progr;Database=WebPortal;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departament>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Departament");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.DescrKz)
                .HasMaxLength(255)
                .HasColumnName("DescrKZ");
            entity.Property(e => e.DescrRu)
                .HasMaxLength(255)
                .HasColumnName("DescrRU");
            entity.Property(e => e.DocGuid).HasColumnName("DocGUID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InfoKz)
                .HasMaxLength(255)
                .HasColumnName("InfoKZ");
            entity.Property(e => e.InfoRu)
                .HasMaxLength(255)
                .HasColumnName("InfoRU");
            entity.Property(e => e.IntegrCode).HasMaxLength(200);
            entity.Property(e => e.IntegrId).HasColumnName("IntegrID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");
            entity.Property(e => e.OrgIdAd)
                .HasMaxLength(50)
                .HasColumnName("OrgIdAD");
            entity.Property(e => e.ParentCode).HasMaxLength(10);
            entity.Property(e => e.ShortNameKz)
                .HasMaxLength(255)
                .HasColumnName("ShortNameKZ");
            entity.Property(e => e.ShortNameRu)
                .HasMaxLength(255)
                .HasColumnName("ShortNameRU");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.ToTable("Position");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.DepId)
                .HasMaxLength(10)
                .HasColumnName("DepID");
            entity.Property(e => e.DescrKz)
                .HasMaxLength(255)
                .HasColumnName("DescrKZ");
            entity.Property(e => e.DescrRu)
                .HasMaxLength(255)
                .HasColumnName("DescrRU");
            entity.Property(e => e.IntegrId).HasColumnName("IntegrID");
            entity.Property(e => e.OrgIdAd)
                .HasMaxLength(50)
                .HasColumnName("OrgIdAD");
            entity.Property(e => e.ParentPosId).HasColumnName("ParentPosID");
            entity.Property(e => e.Rdlorder).HasColumnName("RDLOrder");

            entity.HasOne(d => d.Dep).WithMany(p => p.Positions)
                .HasForeignKey(d => d.DepId)
                .HasConstraintName("fk_DepID");

            entity.HasOne(d => d.ParentPos).WithMany(p => p.InverseParentPos)
                .HasForeignKey(d => d.ParentPosId)
                .HasConstraintName("fk_ParentPosID");
        });

        modelBuilder.Entity<Protocol>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Comment).HasMaxLength(2000);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.MeetingDay).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.ProtocolNumber).HasMaxLength(500);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasDefaultValueSql("((3))");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolAttachment>(entity =>
        {
            entity.ToTable("ProtocolAttachment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.IsAttachedToLog)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolAttachmentBackupIntegrationInfo>(entity =>
        {
            entity.ToTable("ProtocolAttachmentBackupIntegrationInfo");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolAttachmentSubOrg>(entity =>
        {
            entity.ToTable("ProtocolAttachmentSubOrg");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolDedline>(entity =>
        {
            entity.ToTable("ProtocolDedline");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dedline).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolDepartment>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(50)
                .HasColumnName("departmentCode");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ProtocolExecutingDateType>(entity =>
        {
            entity.ToTable("ProtocolExecutingDateType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProtocolExecutingDateTypeNameRu).HasMaxLength(50);
        });

        modelBuilder.Entity<ProtocolExecutor>(entity =>
        {
            entity.ToTable("ProtocolExecutor");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProtocolExecutor1>(entity =>
        {
            entity.ToTable("ProtocolExecutors");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dedline).HasColumnType("datetime");
            entity.Property(e => e.DedlineStringFormat).HasMaxLength(500);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.NotUserName).HasMaxLength(500);
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserNameInitial).HasMaxLength(500);
        });

        modelBuilder.Entity<ProtocolExecutorFuture>(entity =>
        {
            entity.ToTable("ProtocolExecutorFuture");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dedline).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.NotUserName).HasMaxLength(500);
            entity.Property(e => e.UserFullNameRu)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.UserMiddleName)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.UserSurName)
                .HasMaxLength(500)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProtocolFutureDatesForFilterByWeek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProtocolFutureState");

            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        modelBuilder.Entity<ProtocolFutureStatesByUser>(entity =>
        {
            entity.ToTable("ProtocolFutureStatesByUser");

            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<ProtocolInternalStatus>(entity =>
        {
            entity.ToTable("ProtocolInternalStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameRu).HasMaxLength(50);
        });

        modelBuilder.Entity<ProtocolMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProtolMains");

            entity.ToTable("ProtocolMain");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.DepatmentId).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolMission>(entity =>
        {
            entity.ToTable("ProtocolMission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateForOrder).HasColumnType("datetime");
            entity.Property(e => e.Dedline).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.FreedomNumber).HasMaxLength(1000);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.MissionColor).HasMaxLength(100);
            entity.Property(e => e.ProtocolStatusId).HasDefaultValueSql("((8))");
            entity.Property(e => e.ThematicProtocolInfo).HasMaxLength(2000);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolMissionChangeDateLog>(entity =>
        {
            entity.ToTable("ProtocolMissionChangeDateLog");

            entity.Property(e => e.ActionAuthorAndDate).HasMaxLength(1000);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dedline).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.ResolutionDate).HasColumnType("datetime");
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<ProtocolMissionFuture>(entity =>
        {
            entity.ToTable("ProtocolMissionFuture");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dedline).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentCode).HasMaxLength(50);
            entity.Property(e => e.ExecutorUid).HasColumnName("ExecutorUID");
        });

        modelBuilder.Entity<ProtocolMissionFuturesConnection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProtocolMissionFuturesConnection_1");

            entity.ToTable("ProtocolMissionFuturesConnection");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolResolution>(entity =>
        {
            entity.ToTable("ProtocolResolution");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeadLine).HasColumnType("date");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolResolutionSubOrg>(entity =>
        {
            entity.ToTable("ProtocolResolutionSubOrg");

            entity.Property(e => e.Comment).HasMaxLength(3000);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.DirectorUid).HasColumnName("DirectorUID");
            entity.Property(e => e.Number).HasMaxLength(1000);
        });

        modelBuilder.Entity<ProtocolRole>(entity =>
        {
            entity.ToTable("ProtocolRole");
        });

        modelBuilder.Entity<ProtocolRoleType>(entity =>
        {
            entity.ToTable("ProtocolRoleType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DescrRu).HasMaxLength(500);
            entity.Property(e => e.NameRu).HasMaxLength(500);
        });

        modelBuilder.Entity<ProtocolStatus>(entity =>
        {
            entity.ToTable("ProtocolStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameRu).HasMaxLength(50);
        });

        modelBuilder.Entity<ProtocolSubConfirmer>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<ProtocolSubOrganization>(entity =>
        {
            entity.ToTable("ProtocolSubOrganization");

            entity.Property(e => e.ArchivatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeathLine)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<ProtocolTask>(entity =>
        {
            entity.ToTable("ProtocolTask");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolTaskEvent>(entity =>
        {
            entity.ToTable("ProtocolTaskEvent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EventName).HasMaxLength(500);
        });

        modelBuilder.Entity<ProtocolTaskJournal>(entity =>
        {
            entity.ToTable("ProtocolTaskJournal");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolThematic>(entity =>
        {
            entity.ToTable("ProtocolThematic");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.ProtocolStatusId).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProtocolThematicDate).HasColumnType("date");
            entity.Property(e => e.ProtocolThematicNumber).HasMaxLength(500);
            entity.Property(e => e.ProtocolThematicTypeId).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ProtocolThematicExecutor>(entity =>
        {
            entity.ToTable("ProtocolThematicExecutor");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeadLine).HasColumnType("date");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolThematicMission>(entity =>
        {
            entity.ToTable("ProtocolThematicMission");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeadLine).HasColumnType("date");
            entity.Property(e => e.DeadLine2).HasColumnType("date");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.FreedomNumber).HasMaxLength(2000);
            entity.Property(e => e.ProtocolStatusId).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ProtocolThematicTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProtocolThematicMain");

            entity.ToTable("ProtocolThematicTitle");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProtocolThematicType>(entity =>
        {
            entity.ToTable("ProtocolThematicType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TypeNameRu).HasMaxLength(50);
        });

        modelBuilder.Entity<ProtocolUserAction>(entity =>
        {
            entity.ToTable("ProtocolUserAction");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.UserHostAddress).HasMaxLength(900);
        });

        modelBuilder.Entity<ProtocolUserActionType>(entity =>
        {
            entity.ToTable("ProtocolUserActionType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameRu).HasMaxLength(500);
        });

        modelBuilder.Entity<SubOrgLeader>(entity =>
        {
            entity.Property(e => e.FullNameRu).HasMaxLength(500);
            entity.Property(e => e.PositionNameRu).HasMaxLength(500);
            entity.Property(e => e.ShortName).HasMaxLength(500);
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("UID");
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.ChangedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(10)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.DutyReason).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.EmpShortNameKz)
                .HasMaxLength(255)
                .HasColumnName("EmpShortNameKZ");
            entity.Property(e => e.EmpShortNameRu)
                .HasMaxLength(255)
                .HasColumnName("EmpShortNameRU");
            entity.Property(e => e.EmploymentDate).HasColumnType("datetime");
            entity.Property(e => e.FileNameInstruction)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FireReason).HasMaxLength(255);
            entity.Property(e => e.FiredDate).HasColumnType("datetime");
            entity.Property(e => e.FullNameKz)
                .HasMaxLength(255)
                .HasColumnName("FullNameKZ");
            entity.Property(e => e.FullNameRu)
                .HasMaxLength(255)
                .HasColumnName("FullNameRU");
            entity.Property(e => e.Iin)
                .HasMaxLength(15)
                .HasColumnName("IIN");
            entity.Property(e => e.InfoKz)
                .HasMaxLength(255)
                .HasColumnName("InfoKZ");
            entity.Property(e => e.InfoRu)
                .HasMaxLength(255)
                .HasColumnName("InfoRU");
            entity.Property(e => e.IntegrId).HasColumnName("IntegrID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsHideLd).HasColumnName("IsHideLD");
            entity.Property(e => e.IsMale)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MiddleNameKz)
                .HasMaxLength(255)
                .HasColumnName("MiddleNameKZ");
            entity.Property(e => e.MiddleNameRu)
                .HasMaxLength(255)
                .HasColumnName("MiddleNameRU");
            entity.Property(e => e.MobileNumber).HasMaxLength(255);
            entity.Property(e => e.NameKz)
                .HasMaxLength(255)
                .HasColumnName("NameKZ");
            entity.Property(e => e.NameRu)
                .HasMaxLength(255)
                .HasColumnName("NameRU");
            entity.Property(e => e.OfficeNumber).HasMaxLength(255);
            entity.Property(e => e.OrgIdAd)
                .HasMaxLength(50)
                .HasColumnName("OrgIdAD");
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.PhotoLink).HasMaxLength(255);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.ResponsibilityDocKz).HasColumnName("ResponsibilityDocKZ");
            entity.Property(e => e.ResponsibilityDocRu).HasColumnName("ResponsibilityDocRU");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.SkudId).HasColumnName("SkudID");
            entity.Property(e => e.SkudId2).HasColumnName("SkudID2");
            entity.Property(e => e.SurnameKz)
                .HasMaxLength(255)
                .HasColumnName("SurnameKZ");
            entity.Property(e => e.SurnameRu)
                .HasMaxLength(255)
                .HasColumnName("SurnameRU");

            entity.HasOne(d => d.Department).WithMany(p => p.Users)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Departament");

            entity.HasOne(d => d.Position).WithMany(p => p.Users)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Position");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
