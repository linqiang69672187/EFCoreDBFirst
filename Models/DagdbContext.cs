using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDBFirst.Models
{
    public partial class DagdbContext : DbContext
    {
        public DagdbContext()
        {
        }

        public DagdbContext(DbContextOptions<DagdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnalysisTime> AnalysisTime { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<BaseStationInfo> BaseStationInfo { get; set; }
        public virtual DbSet<BeaconIdInfo> BeaconIdInfo { get; set; }
        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BsgroupInfo> BsgroupInfo { get; set; }
        public virtual DbSet<CallLog> CallLog { get; set; }
        public virtual DbSet<DiskAlert> DiskAlert { get; set; }
        public virtual DbSet<DispatchInfo> DispatchInfo { get; set; }
        public virtual DbSet<DispatchListView> DispatchListView { get; set; }
        public virtual DbSet<DispatchUserView> DispatchUserView { get; set; }
        public virtual DbSet<DtgMember> DtgMember { get; set; }
        public virtual DbSet<DtgroupInfo> DtgroupInfo { get; set; }
        public virtual DbSet<DutyRecord> DutyRecord { get; set; }
        public virtual DbSet<DutyStatus> DutyStatus { get; set; }
        public virtual DbSet<DxgroupInfo> DxgroupInfo { get; set; }
        public virtual DbSet<Efnewusers> Efnewusers { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityDevice> EntityDevice { get; set; }
        public virtual DbSet<FrequentCalls> FrequentCalls { get; set; }
        public virtual DbSet<GisInfo> GisInfo { get; set; }
        public virtual DbSet<GisRecords> GisRecords { get; set; }
        public virtual DbSet<GpscontrolStatues> GpscontrolStatues { get; set; }
        public virtual DbSet<GpspullRecords> GpspullRecords { get; set; }
        public virtual DbSet<GroupInfo> GroupInfo { get; set; }
        public virtual DbSet<HistoryGisInfo> HistoryGisInfo { get; set; }
        public virtual DbSet<HistoryOnlineStatistics> HistoryOnlineStatistics { get; set; }
        public virtual DbSet<HistoryRssiInfo> HistoryRssiInfo { get; set; }
        public virtual DbSet<HistoryUserInStockade> HistoryUserInStockade { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<IsInStockadeView> IsInStockadeView { get; set; }
        public virtual DbSet<IssiInfo> IssiInfo { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<NavigationLine> NavigationLine { get; set; }
        public virtual DbSet<OnlineStatistics> OnlineStatistics { get; set; }
        public virtual DbSet<OperationLog> OperationLog { get; set; }
        public virtual DbSet<PdtRule> PdtRule { get; set; }
        public virtual DbSet<PoliceStrengthPlan> PoliceStrengthPlan { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PowerFunction> PowerFunction { get; set; }
        public virtual DbSet<PrePlan> PrePlan { get; set; }
        public virtual DbSet<PrePlanType> PrePlanType { get; set; }
        public virtual DbSet<Procedure> Procedure { get; set; }
        public virtual DbSet<ProcedureType> ProcedureType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SendMsg> SendMsg { get; set; }
        public virtual DbSet<SendMsgreceipt> SendMsgreceipt { get; set; }
        public virtual DbSet<SmsInfo> SmsInfo { get; set; }
        public virtual DbSet<Smslog> Smslog { get; set; }
        public virtual DbSet<Step> Step { get; set; }
        public virtual DbSet<Stockade> Stockade { get; set; }
        public virtual DbSet<SwitchInfo> SwitchInfo { get; set; }
        public virtual DbSet<TerminalType> TerminalType { get; set; }
        public virtual DbSet<TimePlan> TimePlan { get; set; }
        public virtual DbSet<TrafficControlBox> TrafficControlBox { get; set; }
        public virtual DbSet<UsePramater> UsePramater { get; set; }
        public virtual DbSet<UserChangeLog> UserChangeLog { get; set; }
        public virtual DbSet<UserDuty> UserDuty { get; set; }
        public virtual DbSet<UserInStockade> UserInStockade { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserIssiView> UserIssiView { get; set; }
        public virtual DbSet<UserOnlines> UserOnlines { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VideoInfo> VideoInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=10.8.59.251;Initial Catalog=Dagdb;uid=sa;pwd=gis1a6b7c!Z");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalysisTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimePlanId).HasColumnName("TimePlanID");
            });

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BirthPlace)
                    .IsRequired()
                    .HasMaxLength(41);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<BaseStationInfo>(entity =>
            {
                entity.ToTable("BaseStation_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DivId)
                    .HasColumnName("DivID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsUnderGround).HasDefaultValueSql("((0))");

                entity.Property(e => e.La)
                    .HasColumnType("decimal(9, 7)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Lo)
                    .HasColumnType("decimal(10, 7)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.PicUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationIssi)
                    .HasColumnName("StationISSI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SwitchId)
                    .HasColumnName("SwitchID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BeaconIdInfo>(entity =>
            {
                entity.ToTable("BeaconID_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeaconId).HasColumnName("BeaconID");

                entity.Property(e => e.BeaconName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bz)
                    .HasColumnName("BZ")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FrequencyPoint).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(10, 7)");
            });

            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId);
            });

            modelBuilder.Entity<BsgroupInfo>(entity =>
            {
                entity.ToTable("BSGroup_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BsgroupName)
                    .HasColumnName("BSGroupName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bsissi)
                    .HasColumnName("BSISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberIds).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CallLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apimsg)
                    .HasColumnName("APIMsg")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.RevDeviceUnit).HasMaxLength(20);

                entity.Property(e => e.RevSsi).HasColumnName("RevSSI");

                entity.Property(e => e.RevType).HasMaxLength(10);

                entity.Property(e => e.RevUnit).HasMaxLength(20);

                entity.Property(e => e.RevUser).HasMaxLength(20);

                entity.Property(e => e.SDate)
                    .HasColumnName("sDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SchedulIp)
                    .HasColumnName("SchedulIP")
                    .HasMaxLength(15);

                entity.Property(e => e.SchedulIssi).HasColumnName("SchedulISSI");

                entity.Property(e => e.SchedulUnit).HasMaxLength(20);

                entity.Property(e => e.SchedulUser).HasMaxLength(10);

                entity.Property(e => e.SchedulUserName).HasMaxLength(20);

                entity.Property(e => e.SchedulUserUnit).HasMaxLength(20);

                entity.Property(e => e.SendDeviceUnit).HasMaxLength(20);

                entity.Property(e => e.SendSsi).HasColumnName("SendSSI");

                entity.Property(e => e.SendType).HasMaxLength(10);

                entity.Property(e => e.SendUnit).HasMaxLength(20);

                entity.Property(e => e.SendUser).HasMaxLength(20);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<DiskAlert>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<DispatchInfo>(entity =>
            {
                entity.ToTable("Dispatch_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Issi)
                    .IsRequired()
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasColumnName("Login_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DispatchListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DispatchList_View");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Issi)
                    .IsRequired()
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasColumnName("Login_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<DispatchUserView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DispatchUser_View");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Issi)
                    .IsRequired()
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasColumnName("Login_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Loginintime)
                    .HasColumnName("loginintime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usename)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtgMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTG_Member");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DtgId).HasColumnName("DTG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MembIssi)
                    .HasColumnName("Memb_ISSI")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtgroupInfo>(entity =>
            {
                entity.ToTable("DTGroup_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Gssi)
                    .HasColumnName("GSSI")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<DutyRecord>(entity =>
            {
                entity.ToTable("duty_record");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StepChangeTime)
                    .HasColumnName("stepChangeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.StepName)
                    .HasColumnName("stepName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDutyId).HasColumnName("user_duty_id");
            });

            modelBuilder.Entity<DutyStatus>(entity =>
            {
                entity.ToTable("duty_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("changeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DutyRecordId).HasColumnName("duty_record_id");

                entity.Property(e => e.StepName)
                    .HasColumnName("stepName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DxgroupInfo>(entity =>
            {
                entity.ToTable("DXGroup_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupIndex)
                    .HasColumnName("Group_index")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Gssis)
                    .HasColumnName("GSSIS")
                    .IsUnicode(false);

                entity.Property(e => e.Gtype).HasColumnName("GType");
            });

            modelBuilder.Entity<Efnewusers>(entity =>
            {
                entity.ToTable("efnewusers");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bz)
                    .HasColumnName("BZ")
                    .HasMaxLength(200);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DivId)
                    .HasColumnName("DivID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.La)
                    .HasColumnType("numeric(10, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lo)
                    .HasColumnType("numeric(10, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntityDevice>(entity =>
            {
                entity.ToTable("Entity_Device");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrequentCalls>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DispatchId).HasColumnName("DispatchID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("拔号串");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdtRule).HasComment("拔号规则（1.PDT标准 2.PDT浙江 0.无拔号规则）");

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("终端类型（TETRA、PDT、LTE）");

                entity.Property(e => e.UserType).HasComment("用户类型（1.个2.组3.基站）");
            });

            modelBuilder.Entity<GisInfo>(entity =>
            {
                entity.ToTable("GIS_info");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_GIS_info_userId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Battery).HasMaxLength(10);

                entity.Property(e => e.BeaconId)
                    .HasColumnName("BeaconID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DirectionTravel)
                    .HasColumnName("Direction_travel")
                    .HasMaxLength(10);

                entity.Property(e => e.HorizontalVelocity)
                    .HasColumnName("Horizontal_velocity")
                    .HasMaxLength(20);

                entity.Property(e => e.InserttbTime)
                    .HasColumnName("Inserttb_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.MsRssi).HasMaxLength(10);

                entity.Property(e => e.PositionErr)
                    .HasColumnName("Position_err")
                    .HasMaxLength(30);

                entity.Property(e => e.SendReason)
                    .HasColumnName("Send_reason")
                    .HasMaxLength(30);

                entity.Property(e => e.SendTime)
                    .HasColumnName("Send_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UlRssi).HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GisRecords>(entity =>
            {
                entity.ToTable("GIS_Records");

                entity.HasIndex(e => new { e.Begtime, e.Username })
                    .HasName("username");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Begtime)
                    .HasColumnName("begtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cnt)
                    .HasColumnName("cnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Issi)
                    .HasColumnName("issi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GpscontrolStatues>(entity =>
            {
                entity.ToTable("GPSControlStatues");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CircleStatues).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DestinationStatues).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Gpscircle)
                    .HasColumnName("GPSCircle")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Gpsdestination)
                    .HasColumnName("GPSDestination")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.Gpsdistance).HasColumnName("GPSDistance");

                entity.Property(e => e.GpsdistanceStatues).HasColumnName("GPSDistanceStatues");

                entity.Property(e => e.Gpsopen)
                    .HasColumnName("GPSOpen")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.GpsorBeidou).HasColumnName("GPSorBEIDOU");

                entity.Property(e => e.GpsorBeidoustatues).HasColumnName("GPSorBEIDOUStatues");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpenStatues).HasDefaultValueSql("((-1))");

                entity.Property(e => e.OperatorTime).HasColumnType("datetime");

                entity.Property(e => e.Runner)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GpspullRecords>(entity =>
            {
                entity.ToTable("GPSPull_Records");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Distance)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DstIssi)
                    .HasColumnName("DstISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Expire)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GisAddr)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GisIssi)
                    .HasColumnName("GisISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Period)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PullStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SrcIssi)
                    .HasColumnName("SrcISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupInfo>(entity =>
            {
                entity.ToTable("Group_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Gssi)
                    .HasColumnName("GSSI")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gssis)
                    .HasColumnName("GSSIS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalGssi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoryGisInfo>(entity =>
            {
                entity.ToTable("HistoryGIS_info");

                entity.HasIndex(e => e.UserId)
                    .HasName("userid");

                entity.HasIndex(e => new { e.Latitude, e.Longitude, e.UserId, e.InserttbTime })
                    .HasName("IX_InserttbTime_Lo_La_UserId");

                entity.HasIndex(e => new { e.Longitude, e.Latitude, e.UserId, e.SendTime })
                    .HasName("HistoryGis_info_index_UserID_Sendtime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("主键ID");

                entity.Property(e => e.DirectionTravel)
                    .HasColumnName("Direction_travel")
                    .HasMaxLength(10)
                    .HasComment("移动方向");

                entity.Property(e => e.HorizontalVelocity)
                    .HasColumnName("Horizontal_velocity")
                    .HasMaxLength(20)
                    .HasComment("水平移动速度");

                entity.Property(e => e.InserttbTime)
                    .HasColumnName("Inserttb_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("GIS插入数据时间");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("设备ISSI编号");

                entity.Property(e => e.Latitude)
                    .HasColumnType("numeric(9, 7)")
                    .HasComment("纬度信息");

                entity.Property(e => e.Longitude)
                    .HasColumnType("numeric(10, 7)")
                    .HasComment("经度信息");

                entity.Property(e => e.PositionErr)
                    .HasColumnName("Position_err")
                    .HasMaxLength(30)
                    .HasComment("上报误差");

                entity.Property(e => e.SendReason)
                    .HasColumnName("Send_reason")
                    .HasMaxLength(30)
                    .HasComment("上报GIS信息原因");

                entity.Property(e => e.SendTime)
                    .HasColumnName("Send_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("GIS上报时间");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("使用该设备警员(警车)ID");
            });

            modelBuilder.Entity<HistoryOnlineStatistics>(entity =>
            {
                entity.HasIndex(e => e.CreateTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("Entity_ID");
            });

            modelBuilder.Entity<HistoryRssiInfo>(entity =>
            {
                entity.ToTable("HistoryRSSI_info");

                entity.HasIndex(e => e.InserttbTime)
                    .HasName("inserttb_time_index");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InserttbTime)
                    .HasColumnName("Inserttb_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.MsRssi).HasMaxLength(10);

                entity.Property(e => e.UlRssi).HasMaxLength(10);
            });

            modelBuilder.Entity<HistoryUserInStockade>(entity =>
            {
                entity.HasIndex(e => e.InsertTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.StockStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockadeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ImageContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageData).HasColumnType("image");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IsInStockadeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IsInStockade_View");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DivId)
                    .HasColumnName("DivID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DivStyle).IsUnicode(false);

                entity.Property(e => e.IsShow).HasColumnName("isShow");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Nam).HasMaxLength(20);

                entity.Property(e => e.PointArray).IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserInStockId).HasColumnName("UserInStockID");
            });

            modelBuilder.Entity<IssiInfo>(entity =>
            {
                entity.ToTable("ISSI_info");

                entity.HasIndex(e => e.Issi)
                    .HasName("IX_ISSI_info_issi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bz)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gssis)
                    .HasColumnName("GSSIS")
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ipAddress")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.0.0.0')");

                entity.Property(e => e.IsOnline).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUnderGround).HasDefaultValueSql("((0))");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnlineSec).HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalIssi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductModel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TETRA')");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessUnitsAndUsertype)
                    .HasColumnName("accessUnitsAndUsertype")
                    .IsUnicode(false);

                entity.Property(e => e.DispatcherPermissionEntites).HasColumnName("dispatcherPermissionEntites");

                entity.Property(e => e.DispatcherSelfPermissionEntites).HasColumnName("dispatcherSelfPermissionEntites");

                entity.Property(e => e.EncType).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hdissi)
                    .IsRequired()
                    .HasColumnName("HDISSI")
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lastinlinetime)
                    .HasColumnName("lastinlinetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Loginintime)
                    .HasColumnName("loginintime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Power).HasColumnType("text");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Usename)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usertype)
                    .HasColumnName("usertype")
                    .HasDefaultValueSql("((1))")
                    .HasComment(@"
1£ºdispatch user£»
2£ºconfigure user£»");
            });

            modelBuilder.Entity<NavigationLine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coordinates)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnlineStatistics>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EntityId).HasColumnName("Entity_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OperationLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.IdentityDeviceId)
                    .HasColumnName("IdentityDeviceID")
                    .HasMaxLength(10);

                entity.Property(e => e.IdentityDeviceName).HasMaxLength(200);

                entity.Property(e => e.IdentityDeviceType).HasMaxLength(10);

                entity.Property(e => e.IdentityDeviceUnit).HasMaxLength(20);

                entity.Property(e => e.IdentityId)
                    .HasColumnName("IdentityID")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityName).HasMaxLength(200);

                entity.Property(e => e.IdentityType).HasMaxLength(10);

                entity.Property(e => e.IdentityUnit).HasMaxLength(100);

                entity.Property(e => e.La).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Lo).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.ModelName).HasMaxLength(20);

                entity.Property(e => e.SDate)
                    .HasColumnName("sDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SchedulIp)
                    .HasColumnName("SchedulIP")
                    .HasMaxLength(15);

                entity.Property(e => e.SchedulIssi).HasColumnName("SchedulISSI");

                entity.Property(e => e.SchedulLoginUser).HasMaxLength(10);

                entity.Property(e => e.SchedulUnit).HasMaxLength(20);

                entity.Property(e => e.SchedulUserName).HasMaxLength(20);

                entity.Property(e => e.SchedulUserUnit).HasMaxLength(20);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<PdtRule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pdtrule1)
                    .HasColumnName("pdtrule")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliceStrengthPlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnalysisTimeId).HasColumnName("AnalysisTimeID");

                entity.Property(e => e.TimePlanId).HasColumnName("TimePlanID");

                entity.Property(e => e.TrafficControlBoxId).HasColumnName("TrafficControlBoxID");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Remark).HasMaxLength(256);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.HasIndex(e => e.BlogId);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId);
            });

            modelBuilder.Entity<PowerFunction>(entity =>
            {
                entity.HasKey(e => e.PowerKey);

                entity.Property(e => e.PowerKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EnPowerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PowerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrePlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrePlanType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.ToTable("_procedure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LifeTime).HasColumnName("lifeTime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PType)
                    .HasColumnName("pType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcedureType>(entity =>
            {
                entity.ToTable("procedure_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve1)
                    .HasColumnName("reserve1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve10)
                    .HasColumnName("reserve10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve2)
                    .HasColumnName("reserve2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve3)
                    .HasColumnName("reserve3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve4)
                    .HasColumnName("reserve4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve5)
                    .HasColumnName("reserve5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve6)
                    .HasColumnName("reserve6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve7)
                    .HasColumnName("reserve7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve8)
                    .HasColumnName("reserve8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve9)
                    .HasColumnName("reserve9")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EnRoleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Power).HasColumnType("text");

                entity.Property(e => e.RoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<SendMsg>(entity =>
            {
                entity.ToTable("SendMSG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Consume)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DestSsi)
                    .HasColumnName("DestSSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSsi)
                    .HasColumnName("SourceSSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SendMsgreceipt>(entity =>
            {
                entity.ToTable("SendMSGReceipt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DestSsi)
                    .HasColumnName("DestSSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSsi)
                    .HasColumnName("SourceSSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsInfo>(entity =>
            {
                entity.ToTable("SMS_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DispatcherId).HasColumnName("DispatcherID");

                entity.Property(e => e.IsGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReturn).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSend).HasDefaultValueSql("((0))");

                entity.Property(e => e.La).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Lo).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId)
                    .HasColumnName("ReturnID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RevIssi)
                    .IsRequired()
                    .HasColumnName("RevISSI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevTime).HasColumnType("datetime");

                entity.Property(e => e.SendIssi)
                    .IsRequired()
                    .HasColumnName("SendISSI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Smscontent)
                    .HasColumnName("SMSContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Smsid)
                    .HasColumnName("SMSID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Smsmsg)
                    .HasColumnName("SMSMsg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smstype).HasColumnName("SMSType");
            });

            modelBuilder.Entity<Smslog>(entity =>
            {
                entity.ToTable("SMSLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasMaxLength(140);

                entity.Property(e => e.La).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Lo).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.ReturnMsg).HasMaxLength(10);

                entity.Property(e => e.RevDeviceUnit).HasMaxLength(20);

                entity.Property(e => e.RevSsi).HasColumnName("RevSSI");

                entity.Property(e => e.RevType).HasMaxLength(10);

                entity.Property(e => e.RevUnit).HasMaxLength(20);

                entity.Property(e => e.RevUser).HasMaxLength(10);

                entity.Property(e => e.SDate)
                    .HasColumnName("sDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SchedulIp)
                    .HasColumnName("SchedulIP")
                    .HasMaxLength(15);

                entity.Property(e => e.SchedulIssi).HasColumnName("SchedulISSI");

                entity.Property(e => e.SchedulLoginUser).HasMaxLength(10);

                entity.Property(e => e.SchedulUnit).HasMaxLength(20);

                entity.Property(e => e.SchedulUserName).HasMaxLength(20);

                entity.Property(e => e.SchedulUserUnit).HasMaxLength(20);

                entity.Property(e => e.SendDeviceUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendSsi).HasColumnName("SendSSI");

                entity.Property(e => e.SendType).HasMaxLength(10);

                entity.Property(e => e.SendUnit).HasMaxLength(20);

                entity.Property(e => e.SendUser).HasMaxLength(10);

                entity.Property(e => e.Smsid).HasColumnName("SMSId");

                entity.Property(e => e.Smstype).HasColumnName("SMSType");
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.ToTable("step");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Command)
                    .HasColumnName("command")
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.MarkId).HasColumnName("markId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stockade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DivId)
                    .HasColumnName("DivID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DivStyle).IsUnicode(false);

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasColumnName("isShow")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PointArray).IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SwitchInfo>(entity =>
            {
                entity.ToTable("Switch_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocalMsc).HasColumnName("localMsc");

                entity.Property(e => e.SwitchId).HasColumnName("switchID");

                entity.Property(e => e.SwitchIp)
                    .HasColumnName("switchIp")
                    .HasMaxLength(20);

                entity.Property(e => e.SwitchName)
                    .IsRequired()
                    .HasColumnName("switchName")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TerminalType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimePlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<TrafficControlBox>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coordinates).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<UsePramater>(entity =>
            {
                entity.ToTable("use_pramater");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Concernids)
                    .HasColumnName("concernids")
                    .HasMaxLength(500)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeviceTimeout)
                    .HasColumnName("device_timeout")
                    .HasDefaultValueSql("((15))");

                entity.Property(e => e.Displayinfo)
                    .HasColumnName("displayinfo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HeaderInfoStatusMode)
                    .HasColumnName("headerInfo_status_mode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HideTimeoutDevice).HasColumnName("hide_timeout_device");

                entity.Property(e => e.IsHideOfflineUserBySelect)
                    .IsRequired()
                    .HasColumnName("isHideOfflineUserBySelect")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("(N'True')");

                entity.Property(e => e.IsOpenuserHeadInfo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('close')");

                entity.Property(e => e.LastLa)
                    .HasColumnName("last_la")
                    .HasMaxLength(20);

                entity.Property(e => e.LastLo)
                    .HasColumnName("last_lo")
                    .HasMaxLength(20);

                entity.Property(e => e.Lockid)
                    .HasColumnName("lockid")
                    .HasMaxLength(500);

                entity.Property(e => e.RefreshMapInterval)
                    .HasColumnName("refresh_map_interval")
                    .HasMaxLength(20);

                entity.Property(e => e.UserHeadInfo)
                    .HasColumnName("userHeadInfo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('name')");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20);

                entity.Property(e => e.Voicetype)
                    .HasColumnName("voicetype")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1=TETRA 2=LTE 3=PDT");
            });

            modelBuilder.Entity<UserChangeLog>(entity =>
            {
                entity.Property(e => e.AfterParentId)
                    .IsRequired()
                    .HasColumnName("AfterParentID")
                    .IsUnicode(false);

                entity.Property(e => e.ContentChanged)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FromEntity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRecover).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recovertime)
                    .HasColumnName("recovertime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceParentId)
                    .HasColumnName("SourceParentID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ToEntity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDuty>(entity =>
            {
                entity.ToTable("user_duty");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("entityID");

                entity.Property(e => e.Issi)
                    .HasColumnName("issi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve1)
                    .HasColumnName("reserve1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve10)
                    .HasColumnName("reserve10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve2)
                    .HasColumnName("reserve2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve3)
                    .HasColumnName("reserve3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve4)
                    .HasColumnName("reserve4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve5)
                    .HasColumnName("reserve5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve6)
                    .HasColumnName("reserve6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve7)
                    .HasColumnName("reserve7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve8)
                    .HasColumnName("reserve8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve9)
                    .HasColumnName("reserve9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserInStockade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Distance).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.La).HasColumnType("decimal(9, 7)");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lo).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.StockadeId)
                    .HasColumnName("StockadeID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.ToTable("User_info");

                entity.HasIndex(e => e.Issi)
                    .HasName("IX_User_info_issi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bz)
                    .HasColumnName("bz")
                    .HasMaxLength(250);

                entity.Property(e => e.EntityId)
                    .HasColumnName("Entity_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.IsDisplay).HasDefaultValueSql("((1))");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(20);

                entity.Property(e => e.Nam).HasMaxLength(20);

                entity.Property(e => e.Num).HasMaxLength(30);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UserIcons)
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserIssiView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserISSI_View");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Nam).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIssi)
                    .HasColumnName("UserISSI")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<UserOnlines>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_onlines");

                entity.Property(e => e.Useid).HasColumnName("useid");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanvasIcons)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.NormalIcons)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.TypeIcons)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('类型图片地址')");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('类型名称')");

                entity.Property(e => e.UnNormalIcons)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.UrgencyIcons)
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VideoInfo>(entity =>
            {
                entity.ToTable("Video_Info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DivId)
                    .HasColumnName("DivID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.La).HasColumnType("decimal(9, 7)");

                entity.Property(e => e.Lo).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.PicUrl)
                    .HasColumnName("PicURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VideoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoPlayUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
