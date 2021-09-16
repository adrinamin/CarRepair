using System;
using CarRepair.Core.Aggregates;
using CarRepair.Core.Entities;
using CarRepair.Infrastructure;
using CarRepair.TestingApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRepair.Test.UseCaseTests
{
    [TestClass]
    public class AppointmentTest
    {
        [TestMethod]
        public void CreatingAppointmentShouldSaveIntoDb()
        {
            // Arrange
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Address = "Münsterpl. 9, 4051 Basel",
                Email = "jon.doe@mymail.com",
                FirstName = "Jon",
                LastName = "Doe"
            };

            var expected = new Appointment
            {
                Id = Guid.NewGuid(),
                Customer = customer,
                DateTime = DateTime.Now,
                Title = "car repair"
            };

            var customerAppointment = new CustomerAppointment(new AppointmentRepository());
            
            // Act
            customerAppointment.Create(expected);
            var result = customerAppointment.GetSingleById(expected.Id);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
