using CarRepair.Core.Entities;

namespace CarRepair.Core.Aggregates
{
    public class MonitoringNotification
    {
        public RepairStatus RepairStatus { get; set; }
        public string Description { get; set; }
    }
}