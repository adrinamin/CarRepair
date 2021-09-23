using System;
using CarRepair.Core.Entities;

namespace CarRepair.Core.Aggregates
{
    public record Appointment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }  
    }
}