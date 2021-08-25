using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarRepair.Core;

namespace CarRepair.Application
{
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetAllAppointmentsAsync();

        ValueTask<Appointment> GetAppointmentByIdAsync(Guid id);

        Task<Appointment> AddAppointmentAsync(Appointment appointment);
        
        Task UpdateAppointmentAsync(Appointment appointment);

        Task DeleteAppointmentByIdAsync(Guid id);
    }
}