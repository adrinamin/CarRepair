using CarRepair.Application;
using CarRepair.Core.Entities;

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
            return DescriptionToRepairStateParser.ParseTo(monitoringStatus.Description);
        }

        public void Notify(MonitoringStatus monitoringStatus)
        {
            var repairStatusObserver = new RepairStatusObserver(new MonitoringNotificationSender());
            repairStatusObserver.UpdateStatus(monitoringStatus);
        }

        public double GetRemainingTime()
        {
            // get remaining time until check-up is finished...
            // dummy implementation
            return 0.0;
        }
    }
}