using System;

namespace PersonalPerformanceMonitor.Models
{
    [Serializable]
    public class Settings
    {
        public string DataPointStorage { get; set; } = "datapoints.json";
        public int MinutesBetweenDataAggregation { get; set; } = 30;

        public bool AutomaticAggregation { get; set; } = true;
    }
}
