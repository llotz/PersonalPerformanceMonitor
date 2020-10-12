using PersonalPerformanceMonitor.Models;
using System;
using System.Windows.Forms;

namespace PersonalPerformanceMonitor
{
    public partial class DataPointAggregationForm : Form
    {
        public DataPointAggregationForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            var dataPoint = new DataPoint();
            dataPoint.Motivation = cb_Motivation.Checked;
            dataPoint.Performance = (int)numericUpDown1.Value;
            dataPoint.Procrastinating = cb_Procrastination.Checked;
            dataPoint.RecordedTime = DateTime.Now;

            DataManager.AddDataPoint(dataPoint);
            this.Close();
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
