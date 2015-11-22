namespace DBFConvert
{
    partial class T_ServiceTest
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
            this.lable1 = new System.Windows.Forms.Label();
            this.lab_serviceName = new System.Windows.Forms.Label();
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_startup = new System.Windows.Forms.Button();
            this.btn_getStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(30, 58);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(53, 12);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "服务名称";
            // 
            // lab_serviceName
            // 
            this.lab_serviceName.AutoSize = true;
            this.lab_serviceName.Location = new System.Drawing.Point(103, 58);
            this.lab_serviceName.Name = "lab_serviceName";
            this.lab_serviceName.Size = new System.Drawing.Size(71, 12);
            this.lab_serviceName.TabIndex = 0;
            this.lab_serviceName.Text = "ServiceName";
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(32, 106);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(84, 36);
            this.btn_install.TabIndex = 1;
            this.btn_install.Text = "安装服务";
            this.btn_install.UseVisualStyleBackColor = true;
            // 
            // btn_startup
            // 
            this.btn_startup.Location = new System.Drawing.Point(122, 106);
            this.btn_startup.Name = "btn_startup";
            this.btn_startup.Size = new System.Drawing.Size(84, 36);
            this.btn_startup.TabIndex = 1;
            this.btn_startup.Text = "启动服务";
            this.btn_startup.UseVisualStyleBackColor = true;
            // 
            // btn_getStatus
            // 
            this.btn_getStatus.Location = new System.Drawing.Point(212, 106);
            this.btn_getStatus.Name = "btn_getStatus";
            this.btn_getStatus.Size = new System.Drawing.Size(84, 36);
            this.btn_getStatus.TabIndex = 1;
            this.btn_getStatus.Text = "获取状态";
            this.btn_getStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "status";
            // 
            // T_ServiceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 207);
            this.Controls.Add(this.btn_getStatus);
            this.Controls.Add(this.btn_startup);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_serviceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable1);
            this.Name = "T_ServiceTest";
            this.Text = "T_ServiceTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lab_serviceName;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_startup;
        private System.Windows.Forms.Button btn_getStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}