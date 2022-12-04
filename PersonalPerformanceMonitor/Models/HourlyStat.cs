namespace PersonalPerformanceMonitor.Models
{
    public class HourlyStat
    {
        public HourlyStat()
        {

        }

        public HourlyStat(int hour, int value)
        {
            this.Hour = hour;
            this.AvgValue = value;
        }
        public int Hour { get; set; }
        public int AvgValue { get; set; }
    }
}
