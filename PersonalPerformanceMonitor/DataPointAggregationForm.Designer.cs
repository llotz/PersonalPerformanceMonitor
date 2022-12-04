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
            this.cb_Procrastination = new System.Windows.Forms.CheckBox();
            this.cb_Motivation = new System.Windows.Forms.CheckBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btn80 = new System.Windows.Forms.Button();
            this.btn70 = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Procrastination
            // 
            this.cb_Procrastination.AutoSize = true;
            this.cb_Procrastination.Location = new System.Drawing.Point(30, 47);
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
            this.cb_Motivation.Location = new System.Drawing.Point(208, 47);
            this.cb_Motivation.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Motivation.Name = "cb_Motivation";
            this.cb_Motivation.Size = new System.Drawing.Size(122, 29);
            this.cb_Motivation.TabIndex = 3;
            this.cb_Motivation.Text = "Motivation";
            this.cb_Motivation.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(14, 224);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(372, 33);
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
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.GreenYellow;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn100.Location = new System.Drawing.Point(22, 87);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(66, 34);
            this.btn100.TabIndex = 7;
            this.btn100.Text = "100%";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn90
            // 
            this.btn90.BackColor = System.Drawing.Color.GreenYellow;
            this.btn90.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn90.Location = new System.Drawing.Point(94, 87);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(66, 34);
            this.btn90.TabIndex = 8;
            this.btn90.Text = "90%";
            this.btn90.UseVisualStyleBackColor = false;
            this.btn90.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn80
            // 
            this.btn80.BackColor = System.Drawing.Color.GreenYellow;
            this.btn80.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn80.Location = new System.Drawing.Point(166, 87);
            this.btn80.Name = "btn80";
            this.btn80.Size = new System.Drawing.Size(66, 34);
            this.btn80.TabIndex = 9;
            this.btn80.Text = "80%";
            this.btn80.UseVisualStyleBackColor = false;
            this.btn80.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn70
            // 
            this.btn70.BackColor = System.Drawing.Color.Gold;
            this.btn70.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn70.Location = new System.Drawing.Point(238, 87);
            this.btn70.Name = "btn70";
            this.btn70.Size = new System.Drawing.Size(66, 34);
            this.btn70.TabIndex = 10;
            this.btn70.Text = "70%";
            this.btn70.UseVisualStyleBackColor = false;
            this.btn70.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn60
            // 
            this.btn60.BackColor = System.Drawing.Color.Gold;
            this.btn60.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn60.Location = new System.Drawing.Point(310, 87);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(66, 34);
            this.btn60.TabIndex = 11;
            this.btn60.Text = "60%";
            this.btn60.UseVisualStyleBackColor = false;
            this.btn60.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Thistle;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10.Location = new System.Drawing.Point(310, 130);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(66, 34);
            this.btn10.TabIndex = 16;
            this.btn10.Text = "10%";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn20.Location = new System.Drawing.Point(238, 130);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(66, 34);
            this.btn20.TabIndex = 15;
            this.btn20.Text = "20%";
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn30
            // 
            this.btn30.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn30.Location = new System.Drawing.Point(166, 130);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(66, 34);
            this.btn30.TabIndex = 14;
            this.btn30.Text = "30%";
            this.btn30.UseVisualStyleBackColor = false;
            this.btn30.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn40
            // 
            this.btn40.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn40.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn40.Location = new System.Drawing.Point(94, 130);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(66, 34);
            this.btn40.TabIndex = 13;
            this.btn40.Text = "40%";
            this.btn40.UseVisualStyleBackColor = false;
            this.btn40.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.Gold;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn50.Location = new System.Drawing.Point(22, 130);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(66, 34);
            this.btn50.TabIndex = 12;
            this.btn50.Text = "50%";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Thistle;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Location = new System.Drawing.Point(166, 171);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(66, 34);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0%";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // DataPointAggregationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 271);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn60);
            this.Controls.Add(this.btn70);
            this.Controls.Add(this.btn80);
            this.Controls.Add(this.btn90);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.cb_Motivation);
            this.Controls.Add(this.cb_Procrastination);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DataPointAggregationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPointAggregationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.CheckBox cb_Procrastination;
        private System.Windows.Forms.CheckBox cb_Motivation;
        private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button btn80;
        private System.Windows.Forms.Button btn70;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn0;
    }
}