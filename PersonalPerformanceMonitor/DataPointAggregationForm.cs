using PersonalPerformanceMonitor.Models;
using System;
using System.Windows.Forms;

namespace PersonalPerformanceMonitor
{
	public partial class DataPointAggregationForm : Form
	{
		private DataPoint dataPoint = new DataPoint();

		public DataPointAggregationForm(DataPoint dp = null)
		{
			InitializeComponent();
			dataPoint.RecordedTime = DateTime.Now;
			if (dp != null)
				dataPoint = dp;

			string add = dp != null ? "Edit" : "New";
			Text = $"{add} Datapoint {dataPoint.RecordedTime.ToShortDateString()} {dataPoint.RecordedTime.ToShortTimeString()}";

			BindDataToControls();
		}

		private void BindDataToControls()
		{

		}

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			dataPoint.Motivation = cb_Motivation.Checked;
			dataPoint.Performance = (int)numericUpDown1.Value;
			dataPoint.Procrastinating = cb_Procrastination.Checked;

			DataManager.AddDataPoint(dataPoint);
			this.Close();
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}