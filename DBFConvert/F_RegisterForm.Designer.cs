namespace DBFConvert
{
    partial class F_RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gb_noregister = new System.Windows.Forms.GroupBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_close1 = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_requeststr = new System.Windows.Forms.RichTextBox();
            this.lab_installtime = new System.Windows.Forms.Label();
            this.lab_machinecode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_registersuccess = new System.Windows.Forms.GroupBox();
            this.btn_close2 = new System.Windows.Forms.Button();
            this.lab_registertime = new System.Windows.Forms.Label();
            this.lab_installtime2 = new System.Windows.Forms.Label();
            this.lab_machinecode2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lab_note = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_status = new System.Windows.Forms.Label();
            this.lab_note2 = new System.Windows.Forms.Label();
            this.gb_noregister.SuspendLayout();
            this.gb_registersuccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册状态：";
            // 
            // gb_noregister
            // 
            this.gb_noregister.Controls.Add(this.txt_key);
            this.gb_noregister.Controls.Add(this.label5);
            this.gb_noregister.Controls.Add(this.btn_close1);
            this.gb_noregister.Controls.Add(this.btn_register);
            this.gb_noregister.Controls.Add(this.txt_requeststr);
            this.gb_noregister.Controls.Add(this.lab_installtime);
            this.gb_noregister.Controls.Add(this.lab_machinecode);
            this.gb_noregister.Controls.Add(this.label6);
            this.gb_noregister.Controls.Add(this.label4);
            this.gb_noregister.Controls.Add(this.label2);
            this.gb_noregister.Location = new System.Drawing.Point(28, 62);
            this.gb_noregister.Name = "gb_noregister";
            this.gb_noregister.Size = new System.Drawing.Size(470, 210);
            this.gb_noregister.TabIndex = 1;
            this.gb_noregister.TabStop = false;
            this.gb_noregister.Text = "注册信息";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(125, 114);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(280, 21);
            this.txt_key.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "秘钥：";
            // 
            // btn_close1
            // 
            this.btn_close1.Location = new System.Drawing.Point(233, 151);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Size = new System.Drawing.Size(80, 40);
            this.btn_close1.TabIndex = 4;
            this.btn_close1.Text = "关闭";
            this.btn_close1.UseVisualStyleBackColor = true;
            this.btn_close1.Click += new System.EventHandler(this.btn_close1_Click);
            // 
            // btn_register
            // 
            this.btn_register.ForeColor = System.Drawing.Color.Red;
            this.btn_register.Location = new System.Drawing.Point(125, 151);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(80, 40);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "激活";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_requeststr
            // 
            this.txt_requeststr.Location = new System.Drawing.Point(125, 83);
            this.txt_requeststr.Name = "txt_requeststr";
            this.txt_requeststr.Size = new System.Drawing.Size(280, 21);
            this.txt_requeststr.TabIndex = 2;
            this.txt_requeststr.Text = "";
            // 
            // lab_installtime
            // 
            this.lab_installtime.AutoSize = true;
            this.lab_installtime.Location = new System.Drawing.Point(123, 60);
            this.lab_installtime.Name = "lab_installtime";
            this.lab_installtime.Size = new System.Drawing.Size(65, 12);
            this.lab_installtime.TabIndex = 1;
            this.lab_installtime.Text = "2015-11-16";
            // 
            // lab_machinecode
            // 
            this.lab_machinecode.AutoSize = true;
            this.lab_machinecode.ForeColor = System.Drawing.Color.Red;
            this.lab_machinecode.Location = new System.Drawing.Point(123, 32);
            this.lab_machinecode.Name = "lab_machinecode";
            this.lab_machinecode.Size = new System.Drawing.Size(71, 12);
            this.lab_machinecode.TabIndex = 1;
            this.lab_machinecode.Text = "ZXF12345678";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "请求字符串：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "安装时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "您的机器码：";
            // 
            // gb_registersuccess
            // 
            this.gb_registersuccess.Controls.Add(this.btn_close2);
            this.gb_registersuccess.Controls.Add(this.lab_registertime);
            this.gb_registersuccess.Controls.Add(this.lab_installtime2);
            this.gb_registersuccess.Controls.Add(this.lab_machinecode2);
            this.gb_registersuccess.Controls.Add(this.label10);
            this.gb_registersuccess.Controls.Add(this.label11);
            this.gb_registersuccess.Controls.Add(this.label12);
            this.gb_registersuccess.Location = new System.Drawing.Point(535, 62);
            this.gb_registersuccess.Name = "gb_registersuccess";
            this.gb_registersuccess.Size = new System.Drawing.Size(470, 210);
            this.gb_registersuccess.TabIndex = 1;
            this.gb_registersuccess.TabStop = false;
            this.gb_registersuccess.Text = "注册信息";
            // 
            // btn_close2
            // 
            this.btn_close2.Location = new System.Drawing.Point(126, 134);
            this.btn_close2.Name = "btn_close2";
            this.btn_close2.Size = new System.Drawing.Size(80, 40);
            this.btn_close2.TabIndex = 4;
            this.btn_close2.Text = "关闭";
            this.btn_close2.UseVisualStyleBackColor = true;
            this.btn_close2.Click += new System.EventHandler(this.btn_close1_Click);
            // 
            // lab_registertime
            // 
            this.lab_registertime.AutoSize = true;
            this.lab_registertime.Location = new System.Drawing.Point(124, 92);
            this.lab_registertime.Name = "lab_registertime";
            this.lab_registertime.Size = new System.Drawing.Size(65, 12);
            this.lab_registertime.TabIndex = 1;
            this.lab_registertime.Text = "2015-11-16";
            // 
            // lab_installtime2
            // 
            this.lab_installtime2.AutoSize = true;
            this.lab_installtime2.Location = new System.Drawing.Point(124, 60);
            this.lab_installtime2.Name = "lab_installtime2";
            this.lab_installtime2.Size = new System.Drawing.Size(65, 12);
            this.lab_installtime2.TabIndex = 1;
            this.lab_installtime2.Text = "2015-11-16";
            // 
            // lab_machinecode2
            // 
            this.lab_machinecode2.AutoSize = true;
            this.lab_machinecode2.ForeColor = System.Drawing.Color.Red;
            this.lab_machinecode2.Location = new System.Drawing.Point(124, 32);
            this.lab_machinecode2.Name = "lab_machinecode2";
            this.lab_machinecode2.Size = new System.Drawing.Size(71, 12);
            this.lab_machinecode2.TabIndex = 1;
            this.lab_machinecode2.Text = "ZXF12345678";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "注册时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "安装时间：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "您的机器码：";
            // 
            // lab_note
            // 
            this.lab_note.AutoSize = true;
            this.lab_note.Location = new System.Drawing.Point(59, 300);
            this.lab_note.Name = "lab_note";
            this.lab_note.Size = new System.Drawing.Size(461, 12);
            this.lab_note.TabIndex = 3;
            this.lab_note.Text = "1.若您的产品未注册，请您将【请求字符串】通过邮件或者其他途径发送给软件提供商";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "说明：";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.ForeColor = System.Drawing.Color.Red;
            this.lab_status.Location = new System.Drawing.Point(157, 28);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(41, 12);
            this.lab_status.TabIndex = 2;
            this.lab_status.Text = "未注册";
            // 
            // lab_note2
            // 
            this.lab_note2.AutoSize = true;
            this.lab_note2.Location = new System.Drawing.Point(71, 323);
            this.lab_note2.Name = "lab_note2";
            this.lab_note2.Size = new System.Drawing.Size(233, 12);
            this.lab_note2.TabIndex = 3;
            this.lab_note2.Text = "由软件提供商提供秘钥，输入后激活软件。";
            // 
            // F_RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 352);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.gb_registersuccess);
            this.Controls.Add(this.gb_noregister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_note2);
            this.Controls.Add(this.lab_note);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.F_RegisterForm_Load);
            this.gb_noregister.ResumeLayout(false);
            this.gb_noregister.PerformLayout();
            this.gb_registersuccess.ResumeLayout(false);
            this.gb_registersuccess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_noregister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_requeststr;
        private System.Windows.Forms.Label lab_installtime;
        private System.Windows.Forms.Label lab_machinecode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.Button btn_close1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lab_note;
        private System.Windows.Forms.GroupBox gb_registersuccess;
        private System.Windows.Forms.Button btn_close2;
        private System.Windows.Forms.Label lab_installtime2;
        private System.Windows.Forms.Label lab_machinecode2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lab_registertime;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_note2;
    }
}