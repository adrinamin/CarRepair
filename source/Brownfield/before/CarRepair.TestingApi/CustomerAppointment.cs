using System;
using System.Collections.Generic;
using CarRepair.Core;
using CarRepair.Core.Aggregates;

namespace CarRepair.TestingApi
{
    public class CustomerAppointment
    {
        public void Create(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Appointment GetSingle()
        {
            return new Appointment();
        }

        public IList<Appointment> GetAll()
        {
            return new List<Appointment>();
        }

        public void Update(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}