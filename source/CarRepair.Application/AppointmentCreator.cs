using System;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Aggregates;

namespace CarRepair.Application
{
    public class AppointmentCreator
    {
        private const string AppointmentHasBeenSaved = "Appointment has been saved!";
        private readonly IAppointmentRepository appointmentRepository;
        private readonly INotificationSender notificationSender;

        public AppointmentCreator(IAppointmentRepository appointmentRepository, INotificationSender notificationSender)
        {
            this.appointmentRepository = appointmentRepository ?? throw new ArgumentNullException(nameof(appointmentRepository));
            this.notificationSender = notificationSender ?? throw new ArgumentNullException(nameof(notificationSender));
        }

        public void Create(Appointment appointment)
        {
            this.appointmentRepository.AddAppointmentAsync(appointment);
            this.notificationSender.Send(appointment.Title, AppointmentHasBeenSaved, DateTime.Now);
        }
    }
}