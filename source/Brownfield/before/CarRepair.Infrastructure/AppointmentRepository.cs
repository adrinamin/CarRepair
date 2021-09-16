using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Aggregates;

namespace CarRepair.Infrastructure
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Appointment> GetAppointmentByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppointmentAsync(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointmentByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}