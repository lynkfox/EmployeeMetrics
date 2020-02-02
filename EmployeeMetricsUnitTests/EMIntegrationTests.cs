using EMLib;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EMIntegrationTests
{
    [TestClass]
    public class EMIntegrationTests
    {
        [TestMethod]
        public void InputDataFromDailyServiceWorksheetAsCSVfile()
        {
            // To Be Written

            //Test That is a .csv filre
            //Test that it contains an employee, starttime,endtime, stopcount, miles, and routenumber
        }

        [TestMethod]
        public void IntegrationOutputTestForDailyMetrics()
        {
            SingleDayMetrics MetricsData = CollectData();

            MetricsData.RunMetrics();

            string expectedEmployee = "Goh, Anthony T.";
            double expectedSPH = 11.5;



            Assert.IsTrue(MetricsData.Employees.Contains(expectedEmployee));
            Assert.AreEqual(expectedSPH, MetricsData.Metrics.Where(x => x.Name == expectedEmployee).Select(x=>x.StopsPerHour).FirstOrDefault());
            
        }

        private SingleDayMetrics CollectData()
        {
            var Metrics = new SingleDayMetrics();

            Metrics.Employees.Add("Goh, Anthony T.");
            var dailyData = new SingleEmployeeMetrics()
            {
                Name = "Goh, Anthony T.",
                StartTime = 10,
                EndTime = 18.62,
                RouteNumber = 227,
                TotalStops = 82

            };


            return Metrics;
        }
    }
}
