using System;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Entities;
using CarRepair.SharedKernel;

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
            var title = StringManipulator.Manipulate(monitoringStatus.Title);
            var repairStatus = DescriptionToRepairStateParser.ParseTo(monitoringStatus.Description);
            this.notificationSender.Send(title, repairStatus.ToString(), DateTime.Now);
        }

        // non working sample code! just for demo purposes!
        //public void UpdateTitleStatus(MonitoringStatus monitoringStatus)
        //{
        //    var title = StringManipulator.Manipulate(monitoringStatus.Title);
        //    this.notificationSender.Send(title, monitoringStatus.Description, DateTime.Now);
        //}

        //public void UpdateRepairStatus(MonitoringStatus monitoringStatus)
        //{
        //    var repairStatus = DescriptionToRepairStateParser.ParseTo(monitoringStatus.Description);
        //    this.notificationSender.Send(monitoringStatus.Title, repairStatus.ToString(), DateTime.Now);
        //}
    }
}