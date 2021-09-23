using CarRepair.Core.Entities;

namespace CarRepair.Application
{
    public static class DescriptionToRepairStateParser
    {
        public static RepairStatus ParseTo(string description)
        {
            if (description == "InProgress")
            {
                return RepairStatus.InProgress;
            }

            return RepairStatus.NotStarted;
        }
    }
}