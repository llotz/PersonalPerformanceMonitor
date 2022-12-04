namespace PersonalPerformanceMonitor
{
    partial class SettingsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_DataPointStoragePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Minutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_AutomaticPopup = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(280, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_DataPointStoragePath
            // 
            this.txt_DataPointStoragePath.Location = new System.Drawing.Point(15, 35);
            this.txt_DataPointStoragePath.Name = "txt_DataPointStoragePath";
            this.txt_DataPointStoragePath.ReadOnly = true;
            this.txt_DataPointStoragePath.Size = new System.Drawing.Size(364, 23);
            this.txt_DataPointStoragePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data File";
            // 
            // nud_Minutes
            // 
            this.nud_Minutes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_Minutes.Location = new System.Drawing.Point(15, 115);
            this.nud_Minutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nud_Minutes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_Minutes.Name = "nud_Minutes";
            this.nud_Minutes.Size = new System.Drawing.Size(89, 33);
            this.nud_Minutes.TabIndex = 4;
            this.nud_Minutes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minutes";
            // 
            // cb_AutomaticPopup
            // 
            this.cb_AutomaticPopup.AutoSize = true;
            this.cb_AutomaticPopup.Location = new System.Drawing.Point(15, 75);
            this.cb_AutomaticPopup.Name = "cb_AutomaticPopup";
            this.cb_AutomaticPopup.Size = new System.Drawing.Size(120, 19);
            this.cb_AutomaticPopup.TabIndex = 7;
            this.cb_AutomaticPopup.Text = "Automatic Popup";
            this.cb_AutomaticPopup.UseVisualStyleBackColor = true;
            this.cb_AutomaticPopup.CheckedChanged += new System.EventHandler(this.cb_AutomaticPopup_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 279);
            this.Controls.Add(this.cb_AutomaticPopup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_Minutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DataPointStoragePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_DataPointStoragePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Minutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_AutomaticPopup;
    }
}