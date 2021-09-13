using CarRepair.Core.Entities;

namespace CarRepair.Application
{
    public class DescriptionToRepairStatusParser
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