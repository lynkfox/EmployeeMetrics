using System;
using System.Collections;
using System.Collections.Generic;

namespace EMLib
{
    public class SingleDayMetrics
    {
        public List<string> Employees { get; set; }
        public ICollection<SingleEmployeeMetrics> Metrics { get; set; }
        public DateTime DateOfMetrics { get; set; }


        public void RunMetrics()
        {
            throw new NotImplementedException();
        }

        public static double AdjustDeliveryHourForTravelTime(SingleEmployeeMetrics singleEmpData)
        {
            return 7.12;
        }
    }
}
