using CarRepair.Core.Entities;

namespace CarRepair.Application.Interfaces
{
    public interface IRepairStatusObserver
    {
        public RepairStatus RepairStatus { get; set; }

        void UpdateStatus(MonitoringStatus monitoringStatus);
    }
}