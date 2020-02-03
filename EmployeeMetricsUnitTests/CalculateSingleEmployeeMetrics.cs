using System;
using EMLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EMUnitTests
{
    [TestClass]
    public class CalculateMetricsUnitTests

    {
        private SingleEmployeeMetrics SetupSingleEmployeeData()
        {
            return new SingleEmployeeMetrics()
            {
                Name = "Goh, Anthony T.",
                OnRoadTime = 7.12,
                WorkAreaNumber = 227,
                TotalStops = 82
            };
        }

        private SingleEmployeeMetrics SetupSecondEmployeeData()
        {
            return new SingleEmployeeMetrics()
            {
                Name = "Goh, Anthony T.",
                OnRoadTime = 4,
                WorkAreaNumber = 458,
                TotalStops = 50
            };
        }




        [TestMethod]
        public void CalculateEstimatedStopsPerHour()
        {
            SingleEmployeeMetrics singleEmpData = SetupSingleEmployeeData();
            var oneTestingDay = new SingleDayMetrics();

            singleEmpData.StopsPerHour = oneTestingDay.EstimatedStopsPerHour(singleEmpData);

            double expectedSPH = 8.68;

            Assert.AreEqual(expectedSPH, singleEmpData.StopsPerHour);

        }


    }
}
