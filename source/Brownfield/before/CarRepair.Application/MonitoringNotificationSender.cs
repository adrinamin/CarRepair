using System;
using System.Threading.Tasks;
using CarRepair.Core;

namespace CarRepair.Application
{
    public class MonitoringNotificationSender : INotificationSender, IRepairStatusObserver
    {
        public Task Send(string title, string message, DateTime dateTime)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"{title}, {RepairStatus}, {message}, {dateTime}");
            });
        }

        public RepairStatus RepairStatus { get; set; }

        public void UpdateStatus()
        {
            throw new NotImplementedException();
        }
    }
}