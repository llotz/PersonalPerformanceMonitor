namespace PersonalPerformanceMonitor.Models
{
    public static class Settings
    {
        public static string DataPointStorage { get; set; } = "datapoints.json";
        public static int MinutesBetweenDataAggregation { get; set; } = 30;

        public static bool AutomaticAggregation { get; set; } = true;
    }
}
