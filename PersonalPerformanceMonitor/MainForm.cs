using PersonalPerformanceMonitor.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalPerformanceMonitor
{
    public partial class MainForm : Form
    {
        private DateTime nextAggregationTime = DateTime.Now;

        DataPointAggregationForm aggregationForm = null;

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
            RecalculateStats();
        }

        private void RecalculateStats()
        {
            var hourlyStats = new Evaluator(DataManager.DataPoints.ToList()).GetAverageByHour();
            dataGridView2.DataSource = hourlyStats.ToList();
        }

        private void btn_New_Click(object sender, System.EventArgs e)
        {
            aggregationForm = new DataPointAggregationForm();
            aggregationForm.Show();
        }

        private void timer_Aggregation_Tick(object sender, System.EventArgs e)
        {
            if (!Settings.AutomaticAggregation) return;

            if (nextAggregationTime < DateTime.Now)
            {
                aggregationForm = new DataPointAggregationForm();
                aggregationForm.Show();
                aggregationForm.BringToFront();
                aggregationForm.TopMost = true;
                aggregationForm.Focus();
                aggregationForm.WindowState = FormWindowState.Normal;
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.ShowDialog();
        }
    }
}