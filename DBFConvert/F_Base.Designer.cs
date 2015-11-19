namespace DBFConvert
{
    partial class F_Base
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
            this.lbl_ts_file = new System.Windows.Forms.Label();
            this.tbx_file = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_pwd = new System.Windows.Forms.TextBox();
            this.tbx_uid = new System.Windows.Forms.TextBox();
            this.tbx_table = new System.Windows.Forms.TextBox();
            this.tbx_dbs = new System.Windows.Forms.TextBox();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ts_file
            // 
            this.lbl_ts_file.AutoSize = true;
            this.lbl_ts_file.Location = new System.Drawing.Point(13, 23);
            this.lbl_ts_file.Name = "lbl_ts_file";
            this.lbl_ts_file.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_file.TabIndex = 0;
            this.lbl_ts_file.Text = "扫描目录文件：";
            // 
            // tbx_file
            // 
            this.tbx_file.Location = new System.Drawing.Point(108, 20);
            this.tbx_file.Name = "tbx_file";
            this.tbx_file.Size = new System.Drawing.Size(216, 21);
            this.tbx_file.TabIndex = 1;
            this.tbx_file.Click += new System.EventHandler(this.tbx_file_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(359, 18);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "校验";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "端口：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据库：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "表名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "用户名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "密码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_pwd);
            this.groupBox1.Controls.Add(this.tbx_uid);
            this.groupBox1.Controls.Add(this.tbx_table);
            this.groupBox1.Controls.Add(this.tbx_dbs);
            this.groupBox1.Controls.Add(this.tbx_ip);
            this.groupBox1.Controls.Add(this.tbx_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库信息";
            // 
            // tbx_pwd
            // 
            this.tbx_pwd.Location = new System.Drawing.Point(276, 99);
            this.tbx_pwd.Name = "tbx_pwd";
            this.tbx_pwd.Size = new System.Drawing.Size(127, 21);
            this.tbx_pwd.TabIndex = 4;
            // 
            // tbx_uid
            // 
            this.tbx_uid.Location = new System.Drawing.Point(73, 99);
            this.tbx_uid.Name = "tbx_uid";
            this.tbx_uid.Size = new System.Drawing.Size(123, 21);
            this.tbx_uid.TabIndex = 4;
            // 
            // tbx_table
            // 
            this.tbx_table.Location = new System.Drawing.Point(278, 58);
            this.tbx_table.Name = "tbx_table";
            this.tbx_table.Size = new System.Drawing.Size(127, 21);
            this.tbx_table.TabIndex = 4;
            // 
            // tbx_dbs
            // 
            this.tbx_dbs.Location = new System.Drawing.Point(73, 58);
            this.tbx_dbs.Name = "tbx_dbs";
            this.tbx_dbs.Size = new System.Drawing.Size(123, 21);
            this.tbx_dbs.TabIndex = 4;
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(73, 21);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(123, 21);
            this.tbx_ip.TabIndex = 4;
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(278, 22);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(127, 21);
            this.tbx_port.TabIndex = 4;
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(284, 219);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 5;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(88, 219);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // F_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 255);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tbx_file);
            this.Controls.Add(this.lbl_ts_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_Base";
            this.Load += new System.EventHandler(this.F_Base_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ts_file;
        private System.Windows.Forms.TextBox tbx_file;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_pwd;
        private System.Windows.Forms.TextBox tbx_uid;
        private System.Windows.Forms.TextBox tbx_table;
        private System.Windows.Forms.TextBox tbx_dbs;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_save;
    }
}