using System;
using CarRepair.Application;
using CarRepair.Application.Interfaces;
using CarRepair.Core.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CarRepair.Test.UnitTests
{
    [TestClass]
    public class RepairStatusObserverTests
    {
        [TestMethod]
        public void UpdateStatusShouldSendNotificationWithCorrectRepairState()
        {
            // Arrange
            var isCalled = false;
            var monitoringStatus = new MonitoringStatus
            {
                CurrentDateTime = DateTime.Now,
                Description = "",
                Title = "Check-up of car"
            };

            var notificationSender = new Mock<INotificationSender>();
            notificationSender.Setup(n => n.Send(
                It.IsAny<string>(), 
                It.IsAny<string>(), 
                It.IsAny<DateTime>()))
                .Callback(() => isCalled = true);
            
            var repairStatusObserver = new RepairStatusObserver(notificationSender.Object)
            {
                RepairStatus = RepairStatus.InProgress
            };

            // Act
            repairStatusObserver.UpdateStatus(monitoringStatus);

            // Assert
            Assert.IsTrue(isCalled);
        }
    }
}