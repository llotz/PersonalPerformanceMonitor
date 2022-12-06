using PersonalPerformanceMonitor.Models;
using System.IO;
using System.Text;
using System.Text.Json;

namespace PersonalPerformanceMonitor
{
    public static class SettingsManager
    {
        private static string fileName = "settings.json";
        public static void LoadFromDisk()
        {
            if (File.Exists(fileName))
                using (StreamReader sr = new StreamReader(fileName))
                {
                    var text = sr.ReadToEnd();
                    sr.Close();
                    Settings s = (Settings)JsonSerializer.Deserialize(text, typeof(Settings));
                    Statics.Settings = s;
                }
        }

        public static void SaveToDisk()
        {
            string jsonData = JsonSerializer.Serialize(Statics.Settings);
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(jsonData);
                sw.Close();
            }
        }
    }
}
