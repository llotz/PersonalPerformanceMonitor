using PersonalPerformanceMonitor.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonalPerformanceMonitor
{
    public class Evaluator
    {
        private readonly List<DataPoint> dataPoints;

        public Evaluator(List<DataPoint> dataPoints)
        {
            this.dataPoints = dataPoints;
        }

        private Dictionary<int, List<DataPoint>> GetByHour()
        {
            Dictionary<int, List<DataPoint>> dic = new Dictionary<int, List<DataPoint>>();
            foreach (var dp in dataPoints)
            {
                int hour = dp.RecordedTime.Hour;
                if (!dic.ContainsKey(hour))
                    dic.Add(hour, new List<DataPoint>());
                dic[hour].Add(dp);
            }
            return dic;
        }

        public List<HourlyStat> GetAverageByHour()
        {
            var list = new List<HourlyStat>();
            var byHour = GetByHour();
            foreach (KeyValuePair<int, List<DataPoint>> hourSet in byHour)
            {
                int avg = (int)hourSet.Value.Select(x => x.Performance).Average();
                list.Add(new HourlyStat(hourSet.Key, avg));
            }
            list = list.OrderBy(x => x.Hour).ToList();
            return list;
        }

    }
}
