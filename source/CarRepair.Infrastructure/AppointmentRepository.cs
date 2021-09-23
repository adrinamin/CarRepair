using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Aggregates;

namespace CarRepair.Infrastructure
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private List<Appointment> appointments;
        
        public AppointmentRepository()
        {
            // dummy implementation
            this.appointments = new List<Appointment>();
        }

        public Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            return new Task<List<Appointment>>(() => this.appointments);
        }

        public ValueTask<Appointment> GetAppointmentByIdAsync(Guid id)
        {
            // dummy implementation
            return new ValueTask<Appointment>(this.appointments.Single(a => a.Id == id));
        }

        public Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            // dummy implementation
            this.appointments.Add(appointment);
            return new Task<Appointment>(() => appointment);
        }

        public Task UpdateAppointmentAsync(Appointment appointment)
        {
            // dummy implementation
            var oldAppointment = this.appointments.Single(a => a.Id == appointment.Id);
            this.appointments.Remove(oldAppointment);
            this.appointments.Add(appointment);
            return new Task(() => Console.WriteLine($"{appointment} updated!"));
        }

        public Task DeleteAppointmentByIdAsync(Guid id)
        {
            // dummy implementation
            var oldAppointment = this.appointments.Single(a => a.Id == id);
            this.appointments.Remove(oldAppointment);
            return new Task(() => Console.WriteLine($"appointment with id {id} removed!"));
        }
    }
}