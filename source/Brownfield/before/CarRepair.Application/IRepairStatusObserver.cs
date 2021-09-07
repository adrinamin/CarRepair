using CarRepair.Core;

namespace CarRepair.Application
{
    public interface IRepairStatusObserver
    {
        public RepairStatus RepairStatus { get; set; }

        void UpdateStatus();
    }
}