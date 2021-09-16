﻿using System;
using CarRepair.Core.Entities;
using CarRepair.TestingApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRepair.Test.UseCaseTests
{
    [TestClass]
    public class MonitoringTests
    {
        [TestMethod]
        public void SendingUpdatedRepairStatusNotification()
        {
            // Arrange
            var monitoringStatus = new MonitoringStatus
            {
                CurrentDateTime = DateTime.Now,
                Description = "",
                Title = "Check-up of car"
            };

            var monitoring = new Monitoring();

            monitoring.Notify(monitoringStatus);

            // Act
            var currentRepairState = monitoring.GetCurrentRepairState();

            // Assert
            Assert.AreEqual(RepairStatus.InProgress, currentRepairState);
        }
    }
}