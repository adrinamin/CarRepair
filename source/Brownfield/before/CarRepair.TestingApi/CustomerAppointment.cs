using System;
using CarRepair.Application;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Aggregates;

namespace CarRepair.TestingApi
{
    public class CustomerAppointment
    {
        private readonly IAppointmentRepository appointmentRepository;

        public CustomerAppointment(IAppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository ?? throw new ArgumentNullException(nameof(appointmentRepository));
        }

        public void Create(Appointment appointment)
        {
            var appointmentNotificationSender = new AppointmentNotificationSender();
            var appointmentCreationService = new AppointmentCreationService(appointmentRepository, appointmentNotificationSender);

            appointmentCreationService.Create(appointment);
        }

        public Appointment GetSingleById(Guid id)
        {
            return appointmentRepository.GetAppointmentByIdAsync(id).AsTask().Result;
        }
    }
}