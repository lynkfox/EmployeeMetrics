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
        public void IntegrationOutputTestForDailyMetrics()
        {
            DailyMetrics MetricsData = CollectData();

            MetricsData.RunMetrics();

            string expectedEmployee = "Goh, Anthony T.";
            double expectedSPH = 11.5;



            Assert.IsTrue(MetricsData.Employees.Contains(expectedEmployee));
            Assert.AreEqual(expectedSPH, MetricsData.Metrics.Where(x => x.Name == expectedEmployee).Select(x=>x.StopsPerHour).FirstOrDefault());
            
        }

        private DailyMetrics CollectData()
        {
            var Metrics = new DailyMetrics();

            Metrics.Employees.Add("Goh, Anthony T.");
            var dailyData = new EmployeeMetrics()
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
