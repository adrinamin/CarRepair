using System;
using System.Threading.Tasks;
using CarRepair.Application.Interfaces;
using CarRepair.Core;
using CarRepair.Core.Entities;

namespace CarRepair.Application
{
    public class MonitoringNotificationSender : INotificationSender
    {
        public Task Send(string title, string message, DateTime dateTime)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"{title}, {message}, {dateTime}");
            });
        }
    }
}