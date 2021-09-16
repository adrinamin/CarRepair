using System;
using System.Threading;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Aggregates;
using CarRepair.SharedKernel;

namespace CarRepair.Application
{
    public class AppointmentNotificationHandler : INotificationHandler<AppointmentNotification>
    {
        private readonly INotificationSender notificationSender;
        private readonly IAppointmentRepository appointmentRepository;

        public AppointmentNotificationHandler(INotificationSender notificationSender, IAppointmentRepository appointmentRepository)
        {
            this.notificationSender = notificationSender ?? throw new ArgumentNullException(nameof(notificationSender));
            this.appointmentRepository = appointmentRepository ?? throw new ArgumentNullException(nameof(appointmentRepository));
        }

        public void Handle(AppointmentNotification notification, CancellationToken cancellationToken)
        {
            Guard.IsNotNull(notification, nameof(notification));
            var task = this.appointmentRepository.GetAppointmentByIdAsync(notification.Appointment.Id).AsTask();
            Appointment appointment = null;
            if (task.IsCompleted)
            {
                appointment = task.Result;
            }

            this.notificationSender.Send(appointment?.Title, "Getting Appointment",
                appointment?.DateTime ?? DateTime.Now);
        }
    }
}