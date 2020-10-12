using System;

namespace PersonalPerformanceMonitor.Models
{
    public class DataPoint
    {
        public DateTime RecordedTime { get; set; }
        public int Performance { get; set; }
        public bool Procrastinating { get; set; }
        public bool Motivation { get; set; }
    }
}
