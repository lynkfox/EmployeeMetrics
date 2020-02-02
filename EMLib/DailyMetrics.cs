using System;
using System.Collections;
using System.Collections.Generic;

namespace EMLib
{
    public class DailyMetrics
    {
        public List<string> Employees { get; set; }
        public ICollection<EmployeeMetrics> Metrics { get; set; }

        public void RunMetrics()
        {
            throw new NotImplementedException();
        }
    }
}
