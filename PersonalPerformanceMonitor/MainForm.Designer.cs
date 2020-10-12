namespace PersonalPerformanceMonitor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_DeleteDatapoint = new System.Windows.Forms.Button();
            this.btn_EditDatapoint = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_Aggregation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_DeleteDatapoint);
            this.splitContainer1.Panel1.Controls.Add(this.btn_EditDatapoint);
            this.splitContainer1.Panel1.Controls.Add(this.btn_New);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(734, 463);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // btn_DeleteDatapoint
            // 
            this.btn_DeleteDatapoint.Location = new System.Drawing.Point(5, 261);
            this.btn_DeleteDatapoint.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteDatapoint.Name = "btn_DeleteDatapoint";
            this.btn_DeleteDatapoint.Size = new System.Drawing.Size(205, 43);
            this.btn_DeleteDatapoint.TabIndex = 0;
            this.btn_DeleteDatapoint.Text = "Delete Datapoint";
            this.btn_DeleteDatapoint.UseVisualStyleBackColor = true;
            this.btn_DeleteDatapoint.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_EditDatapoint
            // 
            this.btn_EditDatapoint.Location = new System.Drawing.Point(5, 210);
            this.btn_EditDatapoint.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditDatapoint.Name = "btn_EditDatapoint";
            this.btn_EditDatapoint.Size = new System.Drawing.Size(205, 43);
            this.btn_EditDatapoint.TabIndex = 0;
            this.btn_EditDatapoint.Text = "Edit Datapoint";
            this.btn_EditDatapoint.UseVisualStyleBackColor = true;
            this.btn_EditDatapoint.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(4, 4);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(205, 43);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New Datapoint";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(515, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // cPercent
            // 
            this.cPercent.DataPropertyName = "Percent";
            this.cPercent.HeaderText = "Percent";
            this.cPercent.Name = "cPercent";
            this.cPercent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // timer_Aggregation
            // 
            this.timer_Aggregation.Enabled = true;
            this.timer_Aggregation.Interval = 10000;
            this.timer_Aggregation.Tick += new System.EventHandler(this.timer_Aggregation_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 463);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Personal Performance Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPercent;
        private System.Windows.Forms.Timer timer_Aggregation;
        private System.Windows.Forms.Button btn_DeleteDatapoint;
        private System.Windows.Forms.Button btn_EditDatapoint;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

