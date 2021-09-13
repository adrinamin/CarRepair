using System;
using CarRepair.Application;
using CarRepair.Application.Interfaces;
using CarRepair.Core;
using CarRepair.Core.Entities;
using Moq;

namespace CarRepair.TestingApi
{
    public class Monitoring
    {
        public RepairStatus GetCurrentRepairState()
        {
            var authenticator = new Authenticator();
            var logInInfo = new LogInInfo();
            authenticator.Login(logInInfo);
            
            var notificationReader = new MonitoringNotificationReader();
            var monitoringStatus = notificationReader.Read();
            return DescriptionToRepairStatusParser.ParseTo(monitoringStatus.Description);
        }

        public DateTime GetReparationStartDate()
        {
            throw new NotImplementedException();
        }

        public DateTime GetAppointedEndDate()
        {
            throw new NotImplementedException();
        }

        public double GetRemainingTime()
        {
            throw new NotImplementedException();
        }

        public void Notify(MonitoringStatus monitoringStatus)
        {
            var repairStatusObserver = new RepairStatusObserver(new MonitoringNotificationSender());
            repairStatusObserver.UpdateStatus(monitoringStatus);
        }
    }
}