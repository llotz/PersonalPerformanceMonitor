namespace PersonalPerformanceMonitor
{
	partial class DataPointAggregationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.cb_Procrastination = new System.Windows.Forms.CheckBox();
			this.cb_Motivation = new System.Windows.Forms.CheckBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(118, 45);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(122, 33);
			this.numericUpDown1.TabIndex = 1;
			// 
			// cb_Procrastination
			// 
			this.cb_Procrastination.AutoSize = true;
			this.cb_Procrastination.Location = new System.Drawing.Point(118, 80);
			this.cb_Procrastination.Margin = new System.Windows.Forms.Padding(5);
			this.cb_Procrastination.Name = "cb_Procrastination";
			this.cb_Procrastination.Size = new System.Drawing.Size(159, 29);
			this.cb_Procrastination.TabIndex = 2;
			this.cb_Procrastination.Text = "Procrastination";
			this.cb_Procrastination.UseVisualStyleBackColor = true;
			// 
			// cb_Motivation
			// 
			this.cb_Motivation.AutoSize = true;
			this.cb_Motivation.Location = new System.Drawing.Point(118, 117);
			this.cb_Motivation.Margin = new System.Windows.Forms.Padding(5);
			this.cb_Motivation.Name = "cb_Motivation";
			this.cb_Motivation.Size = new System.Drawing.Size(122, 29);
			this.cb_Motivation.TabIndex = 3;
			this.cb_Motivation.Text = "Motivation";
			this.cb_Motivation.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.BackColor = System.Drawing.Color.LightGreen;
			this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_Save.Location = new System.Drawing.Point(190, 163);
			this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(149, 90);
			this.btn_Save.TabIndex = 4;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = false;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
			this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_Close.Location = new System.Drawing.Point(19, 163);
			this.btn_Close.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(149, 90);
			this.btn_Close.TabIndex = 5;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = false;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(19, 6);
			this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(328, 33);
			this.dateTimePicker1.TabIndex = 6;
			this.dateTimePicker1.TabStop = false;
			// 
			// DataPointAggregationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 273);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.cb_Motivation);
			this.Controls.Add(this.cb_Procrastination);
			this.Controls.Add(this.numericUpDown1);
			this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "DataPointAggregationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataPointAggregationForm";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cb_Procrastination;
        private System.Windows.Forms.CheckBox cb_Motivation;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}