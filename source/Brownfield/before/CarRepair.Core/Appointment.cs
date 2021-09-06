using System;

namespace CarRepair.Core
{
    public record Appointment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }  
    }
}