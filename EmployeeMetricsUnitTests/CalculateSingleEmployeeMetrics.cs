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
                StartTime = 10,
                EndTime = 18.62,
                RouteNumber = 227,
                TotalStops = 82
            };
        }

        private SingleEmployeeMetrics SetupSecondEmployeeData()
        {
            return new SingleEmployeeMetrics()
            {
                Name = "Goh, Anthony T.",
                StartTime = 9.5,
                EndTime = 15.5,
                RouteNumber = 458,
                TotalStops = 50
            };
        }



        [TestMethod]
        public void DetermineExpectedOneWayTravelTimeFromRouteNumber()
        {
            SingleEmployeeMetrics singleEmpData = SetupSingleEmployeeData();

            singleEmpData.AdjustedDeliveryTime = SingleDayMetrics.AdjustDeliveryHourForTravelTime(singleEmpData);
            double expectedDeliveryTime = 7.12;

            Assert.AreEqual(expectedDeliveryTime, singleEmpData.AdjustedDeliveryTime);
        }

        [TestMethod]
        public void UsingDifferentRouteNumberToCalculateExpectTotalDeliveryTime()
        {
            SingleEmployeeMetrics singleEmpData = SetupSecondEmployeeData();

            singleEmpData.AdjustedDeliveryTime = SingleDayMetrics.AdjustDeliveryHourForTravelTime(singleEmpData);
            double expectedDeliveryTime = 4;

            Assert.AreEqual(expectedDeliveryTime, singleEmpData.AdjustedDeliveryTime);
        }

        
    }
}
