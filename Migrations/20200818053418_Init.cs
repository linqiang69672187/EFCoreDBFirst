using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace EFCoreDBFirst.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalysisTime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TimePlanId = table.Column<int>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: true),
                    EndTime = table.Column<TimeSpan>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BirthData = table.Column<DateTimeOffset>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseStationInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StationName = table.Column<string>(nullable: true),
                    StationIssi = table.Column<string>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true),
                    DivId = table.Column<string>(nullable: true),
                    PicUrl = table.Column<string>(nullable: true),
                    IsUnderGround = table.Column<byte>(nullable: true),
                    SwitchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseStationInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeaconIdInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BeaconName = table.Column<string>(nullable: true),
                    BeaconId = table.Column<int>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    Bz = table.Column<string>(nullable: true),
                    FrequencyPoint = table.Column<decimal>(nullable: true),
                    RssiThreshold = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeaconIdInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BsgroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BsgroupName = table.Column<string>(nullable: true),
                    MemberIds = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Bsissi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BsgroupInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CallLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SDate = table.Column<DateTime>(nullable: true),
                    SchedulUnit = table.Column<string>(nullable: true),
                    SchedulIssi = table.Column<int>(nullable: true),
                    SchedulIp = table.Column<string>(nullable: true),
                    SchedulUser = table.Column<string>(nullable: true),
                    SchedulUserUnit = table.Column<string>(nullable: true),
                    SchedulUserName = table.Column<string>(nullable: true),
                    RevSsi = table.Column<int>(nullable: true),
                    RevUser = table.Column<string>(nullable: true),
                    RevType = table.Column<string>(nullable: true),
                    RevUnit = table.Column<string>(nullable: true),
                    RevDeviceUnit = table.Column<string>(nullable: true),
                    Apimsg = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    SendSsi = table.Column<int>(nullable: true),
                    SendUser = table.Column<string>(nullable: true),
                    SendType = table.Column<string>(nullable: true),
                    SendUnit = table.Column<string>(nullable: true),
                    SendDeviceUnit = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiskAlert",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiskAlert", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DispatchInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Ipaddress = table.Column<string>(nullable: true),
                    LoginId = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DispatchListView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Issi = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Ipaddress = table.Column<string>(nullable: true),
                    LoginId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchListView", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DispatchUserView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Ipaddress = table.Column<string>(nullable: true),
                    Usename = table.Column<string>(nullable: true),
                    Loginintime = table.Column<DateTime>(nullable: true),
                    LoginId = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchUserView", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtgMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DtgId = table.Column<int>(nullable: true),
                    MembIssi = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtgMember", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtgroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Gssi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtgroupInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DutyRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserDutyId = table.Column<int>(nullable: true),
                    BeginTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    StepName = table.Column<string>(nullable: true),
                    Cnt = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    StepChangeTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DutyStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DutyRecordId = table.Column<int>(nullable: true),
                    StepName = table.Column<string>(nullable: true),
                    ChangeTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DxgroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    GroupIndex = table.Column<string>(nullable: true),
                    Gssis = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Gtype = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DxgroupInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Efnewusers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Efnewusers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<string>(nullable: true),
                    Depth = table.Column<string>(nullable: true),
                    Bz = table.Column<string>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true),
                    DivId = table.Column<string>(nullable: true),
                    PicUrl = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    ItselfFleet = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityDevice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: true),
                    EntityName = table.Column<string>(nullable: true),
                    Online = table.Column<int>(nullable: true),
                    Total = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityDevice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrequentCalls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PdtRule = table.Column<int>(nullable: true),
                    TerminalType = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: true),
                    DispatchId = table.Column<int>(nullable: true),
                    DataType = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequentCalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GisInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    SendTime = table.Column<DateTime>(nullable: true),
                    InserttbTime = table.Column<DateTime>(nullable: true),
                    HorizontalVelocity = table.Column<string>(nullable: true),
                    DirectionTravel = table.Column<string>(nullable: true),
                    SendReason = table.Column<string>(nullable: true),
                    PositionErr = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    MsRssi = table.Column<string>(nullable: true),
                    UlRssi = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    BeaconId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GisInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GisRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Begtime = table.Column<DateTime>(nullable: true),
                    Endtime = table.Column<DateTime>(nullable: true),
                    Cnt = table.Column<int>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GisRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GpscontrolStatues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Runner = table.Column<string>(nullable: true),
                    OperatorTime = table.Column<DateTime>(nullable: true),
                    Gpsopen = table.Column<string>(nullable: true),
                    OpenStatues = table.Column<int>(nullable: true),
                    Gpscircle = table.Column<int>(nullable: true),
                    CircleStatues = table.Column<int>(nullable: true),
                    Gpsdestination = table.Column<string>(nullable: true),
                    DestinationStatues = table.Column<int>(nullable: true),
                    GpsorBeidou = table.Column<int>(nullable: true),
                    GpsorBeidoustatues = table.Column<int>(nullable: true),
                    Gpsdistance = table.Column<int>(nullable: true),
                    GpsdistanceStatues = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpscontrolStatues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GpspullRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    OperateTime = table.Column<DateTime>(nullable: true),
                    SrcIssi = table.Column<string>(nullable: true),
                    OperateType = table.Column<string>(nullable: true),
                    Expire = table.Column<string>(nullable: true),
                    Period = table.Column<string>(nullable: true),
                    Distance = table.Column<string>(nullable: true),
                    DstIssi = table.Column<string>(nullable: true),
                    GisIssi = table.Column<string>(nullable: true),
                    GisAddr = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    PullStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpspullRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    Gssi = table.Column<string>(nullable: true),
                    Gssis = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    IsExternal = table.Column<byte>(nullable: false),
                    OriginalGssi = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryGisInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    SendTime = table.Column<DateTime>(nullable: true),
                    InserttbTime = table.Column<DateTime>(nullable: true),
                    HorizontalVelocity = table.Column<string>(nullable: true),
                    DirectionTravel = table.Column<string>(nullable: true),
                    SendReason = table.Column<string>(nullable: true),
                    PositionErr = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryGisInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryOnlineStatistics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: true),
                    OnlineTime = table.Column<long>(nullable: true),
                    OnlineCnt = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryOnlineStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryRssiInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    MsRssi = table.Column<string>(nullable: true),
                    UlRssi = table.Column<string>(nullable: true),
                    InserttbTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryRssiInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryUserInStockade",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StockadeId = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    EntityId = table.Column<int>(nullable: true),
                    StockStatus = table.Column<string>(nullable: true),
                    InsertTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryUserInStockade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    ImageContentType = table.Column<string>(nullable: true),
                    ImageSize = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IsInStockadeView",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    PointArray = table.Column<string>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Nam = table.Column<string>(nullable: true),
                    IsShow = table.Column<bool>(nullable: false),
                    Issi = table.Column<string>(nullable: true),
                    DivStyle = table.Column<string>(nullable: true),
                    DivId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    LastStatus = table.Column<string>(nullable: true),
                    UserInStockId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsInStockadeView", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IssiInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Issi = table.Column<string>(nullable: true),
                    Gssis = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    Bz = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true),
                    Typename = table.Column<string>(nullable: true),
                    OriginalIssi = table.Column<string>(nullable: true),
                    ProductModel = table.Column<string>(nullable: true),
                    Manufacturers = table.Column<string>(nullable: true),
                    BsId = table.Column<int>(nullable: true),
                    IsExternal = table.Column<byte>(nullable: false),
                    IsUnderGround = table.Column<byte>(nullable: true),
                    IsOnline = table.Column<int>(nullable: true),
                    OnlineSec = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssiInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Usename = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Hdissi = table.Column<string>(nullable: true),
                    Loginintime = table.Column<DateTime>(nullable: true),
                    Lastinlinetime = table.Column<DateTime>(nullable: true),
                    Usertype = table.Column<int>(nullable: true),
                    AccessUnitsAndUsertype = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    DispatcherSelfPermissionEntites = table.Column<string>(nullable: true),
                    DispatcherPermissionEntites = table.Column<string>(nullable: true),
                    EncType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavigationLine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EntityId = table.Column<int>(nullable: true),
                    Coordinates = table.Column<string>(nullable: true),
                    Direction = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineStatistics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: true),
                    OnlineTime = table.Column<long>(nullable: true),
                    OnlineCnt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SDate = table.Column<DateTime>(nullable: true),
                    SchedulUnit = table.Column<string>(nullable: true),
                    SchedulIssi = table.Column<int>(nullable: true),
                    SchedulIp = table.Column<string>(nullable: true),
                    SchedulLoginUser = table.Column<string>(nullable: true),
                    SchedulUserUnit = table.Column<string>(nullable: true),
                    SchedulUserName = table.Column<string>(nullable: true),
                    IdentityDeviceId = table.Column<string>(nullable: true),
                    IdentityDeviceName = table.Column<string>(nullable: true),
                    IdentityDeviceType = table.Column<string>(nullable: true),
                    IdentityDeviceUnit = table.Column<string>(nullable: true),
                    IdentityId = table.Column<string>(nullable: true),
                    IdentityName = table.Column<string>(nullable: true),
                    IdentityType = table.Column<string>(nullable: true),
                    IdentityUnit = table.Column<string>(nullable: true),
                    ModelName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PdtRule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Pdtrule1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PdtRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoliceStrengthPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TrafficControlBoxId = table.Column<int>(nullable: false),
                    TimePlanId = table.Column<int>(nullable: false),
                    AnalysisTimeId = table.Column<int>(nullable: false),
                    PoliceStrengthPlanNum = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    InUse = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliceStrengthPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Title2 = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerFunction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PowerKey = table.Column<string>(nullable: true),
                    PowerName = table.Column<string>(nullable: true),
                    EnPowerName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerFunction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrePlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlanType = table.Column<string>(nullable: true),
                    Url = table.Column<byte[]>(nullable: true),
                    CreateDate = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrePlanType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TypeId = table.Column<int>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrePlanType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PType = table.Column<string>(nullable: true),
                    LifeTime = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcedureType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Reserve1 = table.Column<string>(nullable: true),
                    Reserve2 = table.Column<string>(nullable: true),
                    Reserve3 = table.Column<string>(nullable: true),
                    Reserve4 = table.Column<string>(nullable: true),
                    Reserve5 = table.Column<string>(nullable: true),
                    Reserve6 = table.Column<string>(nullable: true),
                    Reserve7 = table.Column<string>(nullable: true),
                    Reserve8 = table.Column<string>(nullable: true),
                    Reserve9 = table.Column<string>(nullable: true),
                    Reserve10 = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedureType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    EnRoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendMsg",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DestSsi = table.Column<string>(nullable: true),
                    SourceSsi = table.Column<string>(nullable: true),
                    Reference = table.Column<int>(nullable: true),
                    Consume = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMsg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendMsgreceipt",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DestSsi = table.Column<string>(nullable: true),
                    SourceSsi = table.Column<string>(nullable: true),
                    Reference = table.Column<int>(nullable: true),
                    Result = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMsgreceipt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Smstype = table.Column<int>(nullable: false),
                    SendIssi = table.Column<string>(nullable: true),
                    RevIssi = table.Column<string>(nullable: true),
                    IsRead = table.Column<bool>(nullable: true),
                    IsSend = table.Column<bool>(nullable: true),
                    Smscontent = table.Column<string>(nullable: true),
                    IsReturn = table.Column<bool>(nullable: true),
                    SendTime = table.Column<DateTime>(nullable: true),
                    RevTime = table.Column<DateTime>(nullable: true),
                    ReadTime = table.Column<DateTime>(nullable: true),
                    Smsmsg = table.Column<string>(nullable: true),
                    Smsid = table.Column<string>(nullable: true),
                    ReturnId = table.Column<int>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true),
                    DispatcherId = table.Column<int>(nullable: true),
                    IsGroup = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Smslog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SDate = table.Column<DateTime>(nullable: true),
                    SchedulUnit = table.Column<string>(nullable: true),
                    SchedulIssi = table.Column<int>(nullable: true),
                    SchedulIp = table.Column<string>(nullable: true),
                    SchedulLoginUser = table.Column<string>(nullable: true),
                    SchedulUserUnit = table.Column<string>(nullable: true),
                    SchedulUserName = table.Column<string>(nullable: true),
                    Smstype = table.Column<int>(nullable: true),
                    RevSsi = table.Column<int>(nullable: true),
                    RevType = table.Column<string>(nullable: true),
                    RevUser = table.Column<string>(nullable: true),
                    RevUnit = table.Column<string>(nullable: true),
                    RevDeviceUnit = table.Column<string>(nullable: true),
                    SendSsi = table.Column<int>(nullable: true),
                    SendType = table.Column<string>(nullable: true),
                    SendUser = table.Column<string>(nullable: true),
                    SendUnit = table.Column<string>(nullable: true),
                    SendDeviceUnit = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Smsid = table.Column<int>(nullable: true),
                    IsConsume = table.Column<bool>(nullable: true),
                    ReturnMsg = table.Column<string>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smslog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProcedureId = table.Column<int>(nullable: true),
                    Command = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MarkId = table.Column<byte>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stockade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LoginName = table.Column<string>(nullable: true),
                    PointArray = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    IsShow = table.Column<bool>(nullable: true),
                    DivId = table.Column<string>(nullable: true),
                    DivStyle = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stockade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SwitchInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SwitchId = table.Column<int>(nullable: false),
                    SwitchName = table.Column<string>(nullable: true),
                    SwitchIp = table.Column<string>(nullable: true),
                    LocalMsc = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwitchInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerminalType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Typename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimePlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrafficControlBox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BoxType = table.Column<int>(nullable: false),
                    Coordinates = table.Column<string>(nullable: true),
                    Radius = table.Column<double>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    EntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficControlBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsePramater",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Lockid = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    DeviceTimeout = table.Column<int>(nullable: true),
                    HideTimeoutDevice = table.Column<bool>(nullable: true),
                    RefreshMapInterval = table.Column<string>(nullable: true),
                    LastLo = table.Column<string>(nullable: true),
                    LastLa = table.Column<string>(nullable: true),
                    Displayinfo = table.Column<bool>(nullable: true),
                    Concernids = table.Column<string>(nullable: true),
                    IsHideOfflineUserBySelect = table.Column<string>(nullable: true),
                    UserHeadInfo = table.Column<string>(nullable: true),
                    HeaderInfoStatusMode = table.Column<string>(nullable: true),
                    Voicetype = table.Column<byte>(nullable: true),
                    IsOpenuserHeadInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsePramater", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserChangeLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FromEntity = table.Column<string>(nullable: true),
                    SourceParentId = table.Column<string>(nullable: true),
                    ToEntity = table.Column<string>(nullable: true),
                    IsSelf = table.Column<int>(nullable: false),
                    ContentChanged = table.Column<string>(nullable: true),
                    AfterParentId = table.Column<string>(nullable: true),
                    OperateUser = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    IsRecover = table.Column<int>(nullable: true),
                    Recovertime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChangeLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDuty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    ProcedureId = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    Issi = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Num = table.Column<string>(nullable: true),
                    EntityId = table.Column<int>(nullable: true),
                    Reserve1 = table.Column<string>(nullable: true),
                    Reserve2 = table.Column<string>(nullable: true),
                    Reserve3 = table.Column<string>(nullable: true),
                    Reserve4 = table.Column<string>(nullable: true),
                    Reserve5 = table.Column<string>(nullable: true),
                    Reserve6 = table.Column<string>(nullable: true),
                    Reserve7 = table.Column<string>(nullable: true),
                    Reserve8 = table.Column<string>(nullable: true),
                    Reserve9 = table.Column<string>(nullable: true),
                    Reserve10 = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDuty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nam = table.Column<string>(nullable: true),
                    Num = table.Column<string>(nullable: true),
                    Issi = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Bz = table.Column<string>(nullable: true),
                    IsDisplay = table.Column<bool>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    UserIcons = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: true),
                    Width = table.Column<double>(nullable: true),
                    ShipType = table.Column<int>(nullable: true),
                    BsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInStockade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StockadeId = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    LastStatus = table.Column<string>(nullable: true),
                    Distance = table.Column<decimal>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true),
                    InsertTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInStockade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserIssiView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nam = table.Column<string>(nullable: true),
                    UserIssi = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIssiView", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOnlines",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Useid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOnlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: true),
                    TypeIcons = table.Column<string>(nullable: true),
                    NormalIcons = table.Column<string>(nullable: true),
                    UrgencyIcons = table.Column<string>(nullable: true),
                    UnNormalIcons = table.Column<string>(nullable: true),
                    CanvasIcons = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VideoName = table.Column<string>(nullable: true),
                    VideoPlayUrl = table.Column<string>(nullable: true),
                    Lo = table.Column<decimal>(nullable: true),
                    La = table.Column<decimal>(nullable: true),
                    DivId = table.Column<string>(nullable: true),
                    PicUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Pages = table.Column<int>(nullable: false),
                    AuthorId = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalysisTime");

            migrationBuilder.DropTable(
                name: "BaseStationInfo");

            migrationBuilder.DropTable(
                name: "BeaconIdInfo");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BsgroupInfo");

            migrationBuilder.DropTable(
                name: "CallLog");

            migrationBuilder.DropTable(
                name: "DiskAlert");

            migrationBuilder.DropTable(
                name: "DispatchInfo");

            migrationBuilder.DropTable(
                name: "DispatchListView");

            migrationBuilder.DropTable(
                name: "DispatchUserView");

            migrationBuilder.DropTable(
                name: "DtgMember");

            migrationBuilder.DropTable(
                name: "DtgroupInfo");

            migrationBuilder.DropTable(
                name: "DutyRecord");

            migrationBuilder.DropTable(
                name: "DutyStatus");

            migrationBuilder.DropTable(
                name: "DxgroupInfo");

            migrationBuilder.DropTable(
                name: "Efnewusers");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "EntityDevice");

            migrationBuilder.DropTable(
                name: "FrequentCalls");

            migrationBuilder.DropTable(
                name: "GisInfo");

            migrationBuilder.DropTable(
                name: "GisRecords");

            migrationBuilder.DropTable(
                name: "GpscontrolStatues");

            migrationBuilder.DropTable(
                name: "GpspullRecords");

            migrationBuilder.DropTable(
                name: "GroupInfo");

            migrationBuilder.DropTable(
                name: "HistoryGisInfo");

            migrationBuilder.DropTable(
                name: "HistoryOnlineStatistics");

            migrationBuilder.DropTable(
                name: "HistoryRssiInfo");

            migrationBuilder.DropTable(
                name: "HistoryUserInStockade");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "IsInStockadeView");

            migrationBuilder.DropTable(
                name: "IssiInfo");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "NavigationLine");

            migrationBuilder.DropTable(
                name: "OnlineStatistics");

            migrationBuilder.DropTable(
                name: "OperationLog");

            migrationBuilder.DropTable(
                name: "PdtRule");

            migrationBuilder.DropTable(
                name: "PoliceStrengthPlan");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "PowerFunction");

            migrationBuilder.DropTable(
                name: "PrePlan");

            migrationBuilder.DropTable(
                name: "PrePlanType");

            migrationBuilder.DropTable(
                name: "Procedure");

            migrationBuilder.DropTable(
                name: "ProcedureType");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "SendMsg");

            migrationBuilder.DropTable(
                name: "SendMsgreceipt");

            migrationBuilder.DropTable(
                name: "SmsInfo");

            migrationBuilder.DropTable(
                name: "Smslog");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Stockade");

            migrationBuilder.DropTable(
                name: "SwitchInfo");

            migrationBuilder.DropTable(
                name: "TerminalType");

            migrationBuilder.DropTable(
                name: "TimePlan");

            migrationBuilder.DropTable(
                name: "TrafficControlBox");

            migrationBuilder.DropTable(
                name: "UsePramater");

            migrationBuilder.DropTable(
                name: "UserChangeLog");

            migrationBuilder.DropTable(
                name: "UserDuty");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "UserInStockade");

            migrationBuilder.DropTable(
                name: "UserIssiView");

            migrationBuilder.DropTable(
                name: "UserOnlines");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "VideoInfo");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
