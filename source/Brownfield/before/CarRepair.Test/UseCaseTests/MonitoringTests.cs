using System;
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
            var monitoringStatus = new MonitoringStatus
            {
                CurrentDateTime = DateTime.Now,
                Description = "",
                Title = "Check-up of car"
            };

            var monitoring = new Monitoring();

            monitoring.Notify(monitoringStatus);

            var currentRepairState = monitoring.GetCurrentRepairState();

            Assert.AreEqual(RepairStatus.InProgress, currentRepairState);
        }
    }
}