using EMLib;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace EMIntegrationTests
{
    [TestClass]
    public class EMIntegrationTests
    {

        [TestMethod]
        public void IntegrationOutputTestForDailyMetrics()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\daily service worksheet.xls");
            var oneDay = new SingleDayMetrics(path);

            oneDay.RunMetrics();

            string expectedEmployee = "Woods,Rick Adam";
            double expectedSPH = 9.38;



            Assert.IsTrue(oneDay.Employees.Contains(expectedEmployee));
            Assert.AreEqual(expectedSPH, oneDay.Metrics.Where(x => x.Name == expectedEmployee).Select(x=>x.StopsPerHour).FirstOrDefault());
            
        }

        [TestMethod]
        public void IntegrationInputTestForDailyMetricsUsingDailyServiceWorksheet()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\daily service worksheet.xls");
            var oneDay = new SingleDayMetrics(path);

            string expectedEmployee = "Woods,Rick Adam";
            int expectedWorkArea = 250;
            int expectedStops = 48;
            double expectedOnRoadHours = 4.5;
            int expectedMiles = 103;



            Assert.IsTrue(oneDay.Employees.Contains(expectedEmployee));
            Assert.AreEqual(expectedWorkArea, oneDay.Metrics.Where(x => x.Name == expectedEmployee).Select(x => x.WorkAreaNumber).First());
            Assert.AreEqual(expectedStops, oneDay.Metrics.Where(x => x.Name == expectedEmployee).Select(x => x.TotalStops).First());
            Assert.AreEqual(expectedOnRoadHours, oneDay.Metrics.Where(x => x.Name == expectedEmployee).Select(x => x.OnRoadTime).First());
            Assert.AreEqual(expectedMiles, oneDay.Metrics.Where(x => x.Name == expectedEmployee).Select(x => x.MilesDriven).First());


            // Get Excel File
            // Pass to Library to Convert to CSV, and store data in an iCollection
            // Test that the EmpMetrics Object has the data, and that it has everything it needs.

        }

        private SingleDayMetrics GenerateFakeData()
        {
            var Metrics = new SingleDayMetrics();

            Metrics.Employees.Add("Goh, Anthony T.");
            var dailyData = new SingleEmployeeMetrics()
            {
                Name = "Goh, Anthony T.",
                OnRoadTime = 7.12,
                WorkAreaNumber = 227,
                TotalStops = 82

            };


            return Metrics;
        }
    }
}
