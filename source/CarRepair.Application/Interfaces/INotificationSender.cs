using System;
using System.Threading.Tasks;

namespace CarRepair.Application.Interfaces
{
    public interface INotificationSender
    {
        Task Send(string title, string message, DateTime dateTime);
    }
}