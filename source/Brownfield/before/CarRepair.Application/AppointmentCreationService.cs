using System;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Aggregates;

namespace CarRepair.Application
{
    public class AppointmentCreationService
    {
        private const string AppointmentHasBeenSaved = "Appointment has been saved!";
        private readonly IAppointmentRepository appointmentRepository;
        private readonly INotificationSender notificationSender;

        public AppointmentCreationService(IAppointmentRepository appointmentRepository, INotificationSender notificationSender)
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