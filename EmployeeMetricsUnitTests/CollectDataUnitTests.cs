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
        public void GetFileFromDataFolder()
        {
            string path = "C:/Temp/daily service worksheet.xls";
            var oneDay = new SingleDayMetrics(path);

            Assert.IsTrue(File.Exists(oneDay.path));
        }
    }
}
