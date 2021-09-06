using System;
using System.Threading.Tasks;

namespace CarRepair.Application
{
    public class AppointmentNotificationSender : INotificationSender
    {
        public Task Send(string title, string message, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}