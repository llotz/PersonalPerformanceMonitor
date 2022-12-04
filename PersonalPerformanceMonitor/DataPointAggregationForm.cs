using PersonalPerformanceMonitor.Models;
using System;
using System.Windows.Forms;

namespace PersonalPerformanceMonitor
{
	public partial class DataPointAggregationForm : Form
	{
		private DataPoint dataPoint;
		private bool edit = false;

		public DataPointAggregationForm(DataPoint dp = null)
		{
			InitializeComponent();
			dataPoint = new DataPoint();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";

			dataPoint.RecordedTime = DateTime.Now;
			if (dp != null)
			{
				dataPoint = dp;
				edit = true;
				HighlightButton(dp);
			}

			string add = dp != null ? "Edit" : "New";
			Text = $"{add} Datapoint {dataPoint.RecordedTime.ToShortDateString()} {dataPoint.RecordedTime.ToShortTimeString()}";

			BindDataToControls();

		}

		private void HighlightButton(DataPoint dp)
		{
			this.GetType().GetProperty($"btn{dp.Performance}")?.SetValue("FlatStyle", FlatStyle.Standard);
		}

		private void BindDataToControls()
		{
			//textbox.DataBindings.Add("Text",sourceObject,"FirstName");
			dateTimePicker1.DataBindings.Add("Value", dataPoint, nameof(dataPoint.RecordedTime));
			cb_Motivation.DataBindings.Add("Checked", dataPoint, nameof(dataPoint.Motivation));
			cb_Procrastination.DataBindings.Add("Checked", dataPoint, nameof(dataPoint.Procrastinating));
		}

		private void SaveDataPoint()
		{
			if (!edit)
				DataManager.AddDataPoint(dataPoint);
			DataManager.SaveToStorage();
			this.Close();
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Click(object sender, EventArgs e)
		{
			dataPoint.Performance = Convert.ToInt32(((Control)sender).Name.Replace("btn", ""));
			SaveDataPoint();
		}
	}
}