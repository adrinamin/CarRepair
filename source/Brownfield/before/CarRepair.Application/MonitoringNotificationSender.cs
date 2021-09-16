using System;
using System.Threading.Tasks;
using CarRepair.Application.Interfaces;

namespace CarRepair.Application
{
    public class MonitoringNotificationSender : INotificationSender
    {
        public Task Send(string title, string message, DateTime dateTime)
        {
            // dummy implementation
            return Task.Run(() =>
            {
                Console.WriteLine($"{title}, {message}, {dateTime}");
            });
        }
    }
}