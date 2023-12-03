namespace BaiTapChuong2
{
    partial class SJFform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNumOfProcess = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxBurstTime = new System.Windows.Forms.TextBox();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.textBoxProcessID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridViewStart = new System.Windows.Forms.DataGridView();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSFJ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSortByBurstTime = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelResult = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSortByArrivalTime = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSFJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortByBurstTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortByArrivalTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lbNumOfProcess);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxBurstTime);
            this.groupBox1.Controls.Add(this.textBoxArrivalTime);
            this.groupBox1.Controls.Add(this.textBoxProcessID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // lbNumOfProcess
            // 
            this.lbNumOfProcess.AutoSize = true;
            this.lbNumOfProcess.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfProcess.Location = new System.Drawing.Point(16, 181);
            this.lbNumOfProcess.Name = "lbNumOfProcess";
            this.lbNumOfProcess.Size = new System.Drawing.Size(191, 23);
            this.lbNumOfProcess.TabIndex = 9;
            this.lbNumOfProcess.Text = "Number of processes: 0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(288, 168);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 36);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBurstTime
            // 
            this.textBoxBurstTime.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBurstTime.Location = new System.Drawing.Point(217, 125);
            this.textBoxBurstTime.Name = "textBoxBurstTime";
            this.textBoxBurstTime.Size = new System.Drawing.Size(266, 30);
            this.textBoxBurstTime.TabIndex = 3;
            this.textBoxBurstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxArrivalTime
            // 
            this.textBoxArrivalTime.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArrivalTime.Location = new System.Drawing.Point(217, 80);
            this.textBoxArrivalTime.Name = "textBoxArrivalTime";
            this.textBoxArrivalTime.Size = new System.Drawing.Size(266, 30);
            this.textBoxArrivalTime.TabIndex = 2;
            this.textBoxArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxProcessID
            // 
            this.textBoxProcessID.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcessID.Location = new System.Drawing.Point(217, 38);
            this.textBoxProcessID.Name = "textBoxProcessID";
            this.textBoxProcessID.Size = new System.Drawing.Size(266, 30);
            this.textBoxProcessID.TabIndex = 1;
            this.textBoxProcessID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Burst Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrival Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process ID";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Red;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReset.Location = new System.Drawing.Point(1000, 613);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(129, 36);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridViewStart
            // 
            this.dataGridViewStart.AllowUserToDeleteRows = false;
            this.dataGridViewStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStart.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessID,
            this.ArrivalTime,
            this.BurstTime});
            this.dataGridViewStart.Location = new System.Drawing.Point(597, 45);
            this.dataGridViewStart.Name = "dataGridViewStart";
            this.dataGridViewStart.ReadOnly = true;
            this.dataGridViewStart.Size = new System.Drawing.Size(532, 205);
            this.dataGridViewStart.StandardTab = true;
            this.dataGridViewStart.TabIndex = 1;
            this.dataGridViewStart.TabStop = false;
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcessID.HeaderText = "Process ID";
            this.ProcessID.MinimumWidth = 10;
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.MinimumWidth = 10;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // BurstTime
            // 
            this.BurstTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BurstTime.HeaderText = "Burst Time";
            this.BurstTime.Name = "BurstTime";
            this.BurstTime.ReadOnly = true;
            // 
            // dataGridViewSFJ
            // 
            this.dataGridViewSFJ.AllowUserToDeleteRows = false;
            this.dataGridViewSFJ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewSFJ.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewSFJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSFJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.SystemTime,
            this.WaitingTime});
            this.dataGridViewSFJ.Location = new System.Drawing.Point(32, 494);
            this.dataGridViewSFJ.Name = "dataGridViewSFJ";
            this.dataGridViewSFJ.ReadOnly = true;
            this.dataGridViewSFJ.Size = new System.Drawing.Size(540, 155);
            this.dataGridViewSFJ.StandardTab = true;
            this.dataGridViewSFJ.TabIndex = 1;
            this.dataGridViewSFJ.TabStop = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // SystemTime
            // 
            this.SystemTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SystemTime.HeaderText = "System Time";
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.ReadOnly = true;
            // 
            // WaitingTime
            // 
            this.WaitingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WaitingTime.HeaderText = "Waiting Time";
            this.WaitingTime.Name = "WaitingTime";
            this.WaitingTime.ReadOnly = true;
            // 
            // dataGridViewSortByBurstTime
            // 
            this.dataGridViewSortByBurstTime.AllowUserToDeleteRows = false;
            this.dataGridViewSortByBurstTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewSortByBurstTime.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewSortByBurstTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSortByBurstTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewSortByBurstTime.Location = new System.Drawing.Point(597, 291);
            this.dataGridViewSortByBurstTime.Name = "dataGridViewSortByBurstTime";
            this.dataGridViewSortByBurstTime.ReadOnly = true;
            this.dataGridViewSortByBurstTime.Size = new System.Drawing.Size(532, 164);
            this.dataGridViewSortByBurstTime.StandardTab = true;
            this.dataGridViewSortByBurstTime.TabIndex = 1;
            this.dataGridViewSortByBurstTime.TabStop = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Arrival Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Burst Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(593, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "List Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sort by arrival time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(593, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sort by burst time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Result";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 698);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(593, 626);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(180, 23);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Average waiting time =";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Burst Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Arrival Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewSortByArrivalTime
            // 
            this.dataGridViewSortByArrivalTime.AllowUserToDeleteRows = false;
            this.dataGridViewSortByArrivalTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewSortByArrivalTime.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewSortByArrivalTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSortByArrivalTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewSortByArrivalTime.Location = new System.Drawing.Point(32, 291);
            this.dataGridViewSortByArrivalTime.Name = "dataGridViewSortByArrivalTime";
            this.dataGridViewSortByArrivalTime.ReadOnly = true;
            this.dataGridViewSortByArrivalTime.Size = new System.Drawing.Size(540, 164);
            this.dataGridViewSortByArrivalTime.StandardTab = true;
            this.dataGridViewSortByArrivalTime.TabIndex = 1;
            this.dataGridViewSortByArrivalTime.TabStop = false;
            this.dataGridViewSortByArrivalTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSortByArrivalTime_CellContentClick);
            // 
            // SJFform
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1142, 698);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewSFJ);
            this.Controls.Add(this.dataGridViewSortByBurstTime);
            this.Controls.Add(this.dataGridViewSortByArrivalTime);
            this.Controls.Add(this.dataGridViewStart);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1158, 737);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1158, 718);
            this.Name = "SJFform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortest Job First";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSFJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortByBurstTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortByArrivalTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxBurstTime;
        private System.Windows.Forms.TextBox textBoxArrivalTime;
        private System.Windows.Forms.TextBox textBoxProcessID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumOfProcess;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridViewStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridView dataGridViewSFJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
        private System.Windows.Forms.DataGridView dataGridViewSortByBurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewSortByArrivalTime;
    }
}