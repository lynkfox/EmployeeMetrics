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
            var expectedRouteTravelTimes = new Dictionary<int, double>
            {
                { 227, .75 },
                { 458, 1 }
            };

            singleEmpData.EstimatedTimeFromTerminal = expectedRouteTravelTimes[singleEmpData.RouteNumber];
            singleEmpData.TotalTimeDriving = Math.Round((singleEmpData.EndTime-singleEmpData.StartTime) - singleEmpData.EstimatedTimeFromTerminal * 2, 2);

            return singleEmpData.TotalTimeDriving;
        }
    }
}
