using System;
using System.Windows.Forms;

namespace PersonalPerformanceMonitor
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            txt_DataPointStoragePath.Text = Models.Settings.DataPointStorage;
            cb_AutomaticPopup.Checked = Models.Settings.AutomaticAggregation;
            nud_Minutes.Value = Models.Settings.MinutesBetweenDataAggregation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Settings.AutomaticAggregation = cb_AutomaticPopup.Checked;
            Models.Settings.MinutesBetweenDataAggregation = Convert.ToInt32(nud_Minutes.Value);
            this.Close();
        }

        private void cb_AutomaticPopup_CheckedChanged(object sender, EventArgs e)
        {
            nud_Minutes.Enabled = cb_AutomaticPopup.Checked;
        }
    }
}
