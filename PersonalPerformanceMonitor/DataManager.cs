using PersonalPerformanceMonitor.Models;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;

namespace PersonalPerformanceMonitor
{
	public static class DataManager
	{
		public static BindingList<DataPoint> DataPoints { get; set; } = new BindingList<DataPoint>();

		public static void LoadDataFromStorage()
		{
			if (File.Exists(Settings.DataPointStorage))
				using (StreamReader sr = new StreamReader(Settings.DataPointStorage))
				{
					string jsonText = sr.ReadToEnd();
					sr.Close();
					DataPoints = (BindingList<DataPoint>)JsonSerializer.Deserialize(jsonText, typeof(BindingList<DataPoint>));
				}
		}

		public static void SaveToStorage()
		{
			string jsonData = JsonSerializer.Serialize(DataPoints);
			using (StreamWriter sw = new StreamWriter(Settings.DataPointStorage, false, Encoding.UTF8))
			{
				sw.Write(jsonData);
				sw.Close();
			}
		}

		public static void AddDataPoint(DataPoint dataPoint)
		{
			DataPoints.Add(dataPoint);
		}

		public static void RemoveDataPoint(DataPoint dataPoint)
		{
			DataPoints.Remove(dataPoint);
			SaveToStorage();
		}
	}
}