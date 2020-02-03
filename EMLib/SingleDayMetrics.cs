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

        private Dictionary<int, double> expectedRouteTravelTimes = new Dictionary<int, double>
            {
                { 210, .5 },
                { 234, .5 },
                { 242, .75 },
                { 258, .75 },
                { 266, .75 },
                { 274, .5 },
                { 282, .5 },
                { 218, .5 },
                { 227, .75 },
                { 243, .5 },
                { 251, .5 },
                { 259, .5 },
                { 410, .75 },
                { 418, .5 },
                { 426, .5 },
                { 442, .5 },
                { 458, 1 },
                { 466, .75 },
                { 474, .75 },
                { 482, .75 },
                { 490, .5 },
                { 419, .5 },
                { 427, .75 },
                { 435, .5 },
                { 443, .5 },
                { 459, 5 },
                { 467, .75 }
            };

        public void RunMetrics()
        {
            throw new NotImplementedException();
        }

        public double AdjustDeliveryHourForTravelTime(SingleEmployeeMetrics singleEmpData)
        {
            

            singleEmpData.EstimatedTimeFromTerminal = expectedRouteTravelTimes[singleEmpData.RouteNumber];
            singleEmpData.TotalTimeDriving = Math.Round((singleEmpData.EndTime-singleEmpData.StartTime) - singleEmpData.EstimatedTimeFromTerminal * 2, 2);

            return singleEmpData.TotalTimeDriving;
        }
    }
}
