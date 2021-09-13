using System;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Entities;

namespace CarRepair.Application
{
    public class RepairStatusObserver : IRepairStatusObserver
    {
        private readonly INotificationSender notificationSender;

        public RepairStatusObserver(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender ?? throw new ArgumentNullException(nameof(notificationSender));
        }
        public RepairStatus RepairStatus { get; set; }

        public void UpdateStatus(MonitoringStatus monitoringStatus)
        {
            // more complex logic...
            this.notificationSender.Send(monitoringStatus.Title, this.RepairStatus.ToString(), DateTime.Now);
        }
    }
}