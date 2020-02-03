using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EMLib
{
    public class SingleDayMetrics
    {
        public List<string> Employees { get; set; }
        public ICollection<SingleEmployeeMetrics> Metrics { get; set; }
        public DateTime DateOfMetrics { get; set; }


        public readonly string path;

        public SingleDayMetrics(string path)
        {
           
            if(Path.GetExtension(path) != ".xls")
            {
                throw new Exception("Not an Excel File");
            }
            else
            {
                this.path = path;
            }
        }

        public SingleDayMetrics()
        {
        }

        public void RunMetrics()
        {
            throw new NotImplementedException();
        }


        public double EstimatedStopsPerHour(SingleEmployeeMetrics employeeMetrics)
        {
            return Math.Round(employeeMetrics.OnRoadTime / employeeMetrics.TotalStops * 100, 2);
        }
    }
}
