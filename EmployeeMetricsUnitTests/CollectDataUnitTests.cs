using System;
using System.IO;
using System.Reflection;
using EMLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EMUnitTests
{
    [TestClass]
    public class CollectDataUnitTests
    {
        [TestMethod]
        public void CanSeeFileIfGivenAPath()
        {
            string path = "C:/Temp/daily service worksheet.xls";
            var oneDay = new SingleDayMetrics(path);

            Assert.IsTrue(File.Exists(oneDay.path));
        }

        [TestMethod]
        public void RejectsFileIfNotXLS()
        {
            string path = "C:/Temp/fake bad document.txt";
            string expectedMessage = "Not an Excel File";
            string actualMessage = null;

            try
            {
                var oneDay = new SingleDayMetrics(path);
                
            } catch(Exception e)
            {
                actualMessage = e.Message;
            }

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }
    }
}
