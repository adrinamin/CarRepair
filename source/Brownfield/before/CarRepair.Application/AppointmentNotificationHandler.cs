using System;
using System.Threading;
using System.Threading.Tasks;
using CarRepair.Core;
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

        public async Task Handle(AppointmentNotification notification, CancellationToken cancellationToken)
        {
            var appointment = notification.Appointment;
            Guard.IsNotNull(appointment, nameof(appointment));
            await this.appointmentRepository.AddAppointmentAsync(appointment);

            await this.notificationSender.Send(appointment.Title, "Your Appointment has been saved!",
                appointment.DateTime);
        }
    }
}