using System;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Entities;

namespace CarRepair.Application
{
    public class MonitoringNotificationReader : INotificationReader<MonitoringStatus>
    {
        public MonitoringStatus Read()
        {
            // dummy implementation for reading notification
            return new MonitoringStatus
            {
                CurrentDateTime = DateTime.Now,
                Description = "InProgress",
                Title = "Monitoring changed!"
            };
        }
    }
}