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

        public  DbSet<AnalysisTime> AnalysisTime { get; set; }
        public  DbSet<Authors> Authors { get; set; }
        public  DbSet<BaseStationInfo> BaseStationInfo { get; set; }
        public  DbSet<BeaconIdInfo> BeaconIdInfo { get; set; }
        public  DbSet<Books> Books { get; set; }
        public  DbSet<BsgroupInfo> BsgroupInfo { get; set; }
        public  DbSet<CallLog> CallLog { get; set; }
        public  DbSet<DiskAlert> DiskAlert { get; set; }
        public  DbSet<DispatchInfo> DispatchInfo { get; set; }
        public  DbSet<DispatchListView> DispatchListView { get; set; }
        public  DbSet<DispatchUserView> DispatchUserView { get; set; }
        public  DbSet<DtgMember> DtgMember { get; set; }
        public  DbSet<DtgroupInfo> DtgroupInfo { get; set; }
        public  DbSet<DutyRecord> DutyRecord { get; set; }
        public  DbSet<DutyStatus> DutyStatus { get; set; }
        public  DbSet<DxgroupInfo> DxgroupInfo { get; set; }
        public  DbSet<Efnewusers> Efnewusers { get; set; }
        public  DbSet<Entity> Entity { get; set; }
        public  DbSet<EntityDevice> EntityDevice { get; set; }
        public  DbSet<FrequentCalls> FrequentCalls { get; set; }
        public  DbSet<GisInfo> GisInfo { get; set; }
        public  DbSet<GisRecords> GisRecords { get; set; }
        public  DbSet<GpscontrolStatues> GpscontrolStatues { get; set; }
        public  DbSet<GpspullRecords> GpspullRecords { get; set; }
        public  DbSet<GroupInfo> GroupInfo { get; set; }
        public  DbSet<HistoryGisInfo> HistoryGisInfo { get; set; }
        public  DbSet<HistoryOnlineStatistics> HistoryOnlineStatistics { get; set; }
        public  DbSet<HistoryRssiInfo> HistoryRssiInfo { get; set; }
        public  DbSet<HistoryUserInStockade> HistoryUserInStockade { get; set; }
        public  DbSet<Images> Images { get; set; }
        public  DbSet<IsInStockadeView> IsInStockadeView { get; set; }
        public  DbSet<IssiInfo> IssiInfo { get; set; }
        public  DbSet<Login> Login { get; set; }
        public  DbSet<NavigationLine> NavigationLine { get; set; }
        public  DbSet<OnlineStatistics> OnlineStatistics { get; set; }
        public  DbSet<OperationLog> OperationLog { get; set; }
        public  DbSet<PdtRule> PdtRule { get; set; }
        public  DbSet<PoliceStrengthPlan> PoliceStrengthPlan { get; set; }
        public  DbSet<Position> Position { get; set; }
        public  DbSet<Posts> Posts { get; set; }
        public  DbSet<PowerFunction> PowerFunction { get; set; }
        public  DbSet<PrePlan> PrePlan { get; set; }
        public  DbSet<PrePlanType> PrePlanType { get; set; }
        public  DbSet<Procedure> Procedure { get; set; }
        public  DbSet<ProcedureType> ProcedureType { get; set; }
        public  DbSet<Role> Role { get; set; }
        public  DbSet<SendMsg> SendMsg { get; set; }
        public  DbSet<SendMsgreceipt> SendMsgreceipt { get; set; }
        public  DbSet<SmsInfo> SmsInfo { get; set; }
        public  DbSet<Smslog> Smslog { get; set; }
        public  DbSet<Step> Step { get; set; }
        public  DbSet<Stockade> Stockade { get; set; }
        public  DbSet<SwitchInfo> SwitchInfo { get; set; }
        public  DbSet<TerminalType> TerminalType { get; set; }
        public  DbSet<TimePlan> TimePlan { get; set; }
        public  DbSet<TrafficControlBox> TrafficControlBox { get; set; }
        public  DbSet<UsePramater> UsePramater { get; set; }
        public  DbSet<UserChangeLog> UserChangeLog { get; set; }
        public  DbSet<UserDuty> UserDuty { get; set; }
        public  DbSet<UserInStockade> UserInStockade { get; set; }
        public  DbSet<UserInfo> UserInfo { get; set; }
        public  DbSet<UserIssiView> UserIssiView { get; set; }
        public  DbSet<UserOnlines> UserOnlines { get; set; }
        public  DbSet<UserType> UserType { get; set; }
        public  DbSet<Users> Users { get; set; }
        public  DbSet<VideoInfo> VideoInfo { get; set; }

    }
}
