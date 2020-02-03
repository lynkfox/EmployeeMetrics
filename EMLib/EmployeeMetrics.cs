namespace EMLib
{
    public class SingleEmployeeMetrics
    {
        public string Name { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public double TotalTimeDriving { get; set; }
        public double EstimatedTimeFromTerminal { get; set; }
        public int RouteNumber { get; set; }
        public double StopsPerHour { get; set; }
        public int TotalStops { get; set; }

        public double MilesDriven { get; set; }
        public double AdjustedDeliveryTime { get; set; }
    }
}