using PersonalPerformanceMonitor.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalPerformanceMonitor
{
	public partial class MainForm : Form
	{
		private DateTime nextAggregationTime = DateTime.Now;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			DataManager.LoadDataFromStorage();
			dataGridView1.DataSource = DataManager.DataPoints;
			dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			if (DataManager.DataPoints.Count > 0)
				nextAggregationTime = DataManager.DataPoints.Max(x => x.RecordedTime).AddMinutes(Settings.MinutesBetweenDataAggregation);
		}

		private void btn_New_Click(object sender, System.EventArgs e)
		{
			DataPointAggregationForm f = new DataPointAggregationForm();
			f.Show();
		}

		private void timer_Aggregation_Tick(object sender, System.EventArgs e)
		{
			if (nextAggregationTime < DateTime.Now)
			{
				var f = new DataPointAggregationForm();
				f.Show();
				f.TopMost = true;
				f.WindowState = FormWindowState.Normal;
				f.BringToFront();
				f.Focus();
				nextAggregationTime = DateTime.Now.AddMinutes(Settings.MinutesBetweenDataAggregation);
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("U sure?", "Are you sure to delete this thing?", MessageBoxButtons.YesNo) != DialogResult.Yes)
				return;

			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				DataManager.RemoveDataPoint((DataPoint)row.DataBoundItem);
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				new DataPointAggregationForm((DataPoint)row.DataBoundItem).Show();
		}
	}
}