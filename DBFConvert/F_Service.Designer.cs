namespace DBFConvert
{
    partial class F_Service
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_jg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_zdzx = new System.Windows.Forms.CheckBox();
            this.cbox_kjqd = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cbox_jg);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.cbox_zdzx);
            this.GroupBox1.Controls.Add(this.cbox_kjqd);
            this.GroupBox1.Location = new System.Drawing.Point(12, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(260, 108);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "服务配置";
            // 
            // cbox_jg
            // 
            this.cbox_jg.FormattingEnabled = true;
            this.cbox_jg.Location = new System.Drawing.Point(138, 68);
            this.cbox_jg.Name = "cbox_jg";
            this.cbox_jg.Size = new System.Drawing.Size(69, 20);
            this.cbox_jg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "扫描间隔时间：";
            // 
            // cbox_zdzx
            // 
            this.cbox_zdzx.AutoSize = true;
            this.cbox_zdzx.Location = new System.Drawing.Point(138, 33);
            this.cbox_zdzx.Name = "cbox_zdzx";
            this.cbox_zdzx.Size = new System.Drawing.Size(96, 16);
            this.cbox_zdzx.TabIndex = 3;
            this.cbox_zdzx.Text = "是否自动执行";
            this.cbox_zdzx.UseVisualStyleBackColor = true;
            // 
            // cbox_kjqd
            // 
            this.cbox_kjqd.AutoSize = true;
            this.cbox_kjqd.Location = new System.Drawing.Point(17, 33);
            this.cbox_kjqd.Name = "cbox_kjqd";
            this.cbox_kjqd.Size = new System.Drawing.Size(96, 16);
            this.cbox_kjqd.TabIndex = 3;
            this.cbox_kjqd.Text = "是否开机启动";
            this.cbox_kjqd.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(34, 142);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(167, 142);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // F_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_Service";
            this.Load += new System.EventHandler(this.F_Service_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox cbox_jg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbox_zdzx;
        private System.Windows.Forms.CheckBox cbox_kjqd;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}