namespace DBFConvert
{
    partial class F_ShowLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_notice = new System.Windows.Forms.Label();
            this._RecTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RecStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RecEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RecCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RecFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._RecTime,
            this._RecStartTime,
            this._RecEndTime,
            this._RecCount,
            this._RecFlag,
            this._RecName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(559, 352);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lab_notice);
            this.groupBox1.Location = new System.Drawing.Point(0, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注意事项:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "2.只保留一周的数据处理日志，如果有错误，请及时关闭自动导入模式并联系软件提供商。";
            // 
            // lab_notice
            // 
            this.lab_notice.AutoSize = true;
            this.lab_notice.Location = new System.Drawing.Point(29, 30);
            this.lab_notice.Name = "lab_notice";
            this.lab_notice.Size = new System.Drawing.Size(311, 12);
            this.lab_notice.TabIndex = 0;
            this.lab_notice.Text = "1.本日志文件记录由DBF导入到Oracle数据库的到处日志。";
            // 
            // _RecTime
            // 
            this._RecTime.DataPropertyName = "_RecTime";
            this._RecTime.HeaderText = "追加时间";
            this._RecTime.Name = "_RecTime";
            this._RecTime.ReadOnly = true;
            this._RecTime.Width = 130;
            // 
            // _RecStartTime
            // 
            this._RecStartTime.DataPropertyName = "_RecStartTime";
            this._RecStartTime.HeaderText = "数据开始时间";
            this._RecStartTime.Name = "_RecStartTime";
            this._RecStartTime.ReadOnly = true;
            // 
            // _RecEndTime
            // 
            this._RecEndTime.DataPropertyName = "_RecEndTime";
            this._RecEndTime.HeaderText = "数据结束时间";
            this._RecEndTime.Name = "_RecEndTime";
            this._RecEndTime.ReadOnly = true;
            // 
            // _RecCount
            // 
            this._RecCount.DataPropertyName = "_RecCount";
            this._RecCount.HeaderText = "条数";
            this._RecCount.Name = "_RecCount";
            this._RecCount.ReadOnly = true;
            // 
            // _RecFlag
            // 
            this._RecFlag.DataPropertyName = "_RecFlag";
            this._RecFlag.HeaderText = "标志";
            this._RecFlag.Name = "_RecFlag";
            this._RecFlag.ReadOnly = true;
            // 
            // _RecName
            // 
            this._RecName.DataPropertyName = "_RecName";
            this._RecName.HeaderText = "_RecName";
            this._RecName.Name = "_RecName";
            this._RecName.ReadOnly = true;
            this._RecName.Visible = false;
            // 
            // F_ShowLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ShowLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_ShowLog";
            this.Load += new System.EventHandler(this.F_ShowLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_notice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RecTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RecStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RecEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RecCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RecFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RecName;
    }
}