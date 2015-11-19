namespace DBFConvert
{
    partial class F_Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激活ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_ts_dqsmzt = new System.Windows.Forms.Label();
            this.lbl_ts_scsmsj = new System.Windows.Forms.Label();
            this.lbl_ts_zjts = new System.Windows.Forms.Label();
            this.lbl_ts_zts = new System.Windows.Forms.Label();
            this.llab_show_log = new System.Windows.Forms.LinkLabel();
            this.lbl_dqsmzt = new System.Windows.Forms.Label();
            this.lbl_scsmsj = new System.Windows.Forms.Label();
            this.lbl_zjts = new System.Windows.Forms.Label();
            this.lbl_zts = new System.Windows.Forms.Label();
            this.lbl_ts_auto = new System.Windows.Forms.Label();
            this.lbl_auto = new System.Windows.Forms.Label();
            this.lbl_ts_smjgsj = new System.Windows.Forms.Label();
            this.lbl_smjgsj = new System.Windows.Forms.Label();
            this.lbl_kjqd = new System.Windows.Forms.Label();
            this.lbl_ts_kjqd = new System.Windows.Forms.Label();
            this.btn_sdzx = new System.Windows.Forms.Button();
            this.lbl_smwj = new System.Windows.Forms.Label();
            this.lbl_ts_smwj = new System.Windows.Forms.Label();
            this.lbl_dbs = new System.Windows.Forms.Label();
            this.lbl_ts_dbs = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ts_error = new System.Windows.Forms.Label();
            this.btn_cwcl = new System.Windows.Forms.Button();
            this.llbl_show_errorlog = new System.Windows.Forms.LinkLabel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_tablename = new System.Windows.Forms.Label();
            this.lbl_dbsname = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ts_tablename = new System.Windows.Forms.Label();
            this.lbl_ts_dbsname = new System.Windows.Forms.Label();
            this.lbl_ts_port = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本设置ToolStripMenuItem,
            this.服务配置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // 基本设置ToolStripMenuItem
            // 
            this.基本设置ToolStripMenuItem.Name = "基本设置ToolStripMenuItem";
            this.基本设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.基本设置ToolStripMenuItem.Text = "基本配置";
            this.基本设置ToolStripMenuItem.Click += new System.EventHandler(this.基本设置ToolStripMenuItem_Click);
            // 
            // 服务配置ToolStripMenuItem
            // 
            this.服务配置ToolStripMenuItem.Name = "服务配置ToolStripMenuItem";
            this.服务配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.服务配置ToolStripMenuItem.Text = "服务配置";
            this.服务配置ToolStripMenuItem.Click += new System.EventHandler(this.服务配置ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem,
            this.激活ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.说明ToolStripMenuItem.Text = "说明";
            // 
            // 激活ToolStripMenuItem
            // 
            this.激活ToolStripMenuItem.Name = "激活ToolStripMenuItem";
            this.激活ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.激活ToolStripMenuItem.Text = "激活";
            this.激活ToolStripMenuItem.Click += new System.EventHandler(this.激活ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_status
            // 
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(32, 17);
            this.tssl_status.Text = "状态";
            // 
            // lbl_ts_dqsmzt
            // 
            this.lbl_ts_dqsmzt.AutoSize = true;
            this.lbl_ts_dqsmzt.Location = new System.Drawing.Point(16, 29);
            this.lbl_ts_dqsmzt.Name = "lbl_ts_dqsmzt";
            this.lbl_ts_dqsmzt.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_dqsmzt.TabIndex = 2;
            this.lbl_ts_dqsmzt.Text = "当前扫描状态：";
            // 
            // lbl_ts_scsmsj
            // 
            this.lbl_ts_scsmsj.AutoSize = true;
            this.lbl_ts_scsmsj.Location = new System.Drawing.Point(16, 66);
            this.lbl_ts_scsmsj.Name = "lbl_ts_scsmsj";
            this.lbl_ts_scsmsj.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_scsmsj.TabIndex = 3;
            this.lbl_ts_scsmsj.Text = "上次扫描时间：";
            // 
            // lbl_ts_zjts
            // 
            this.lbl_ts_zjts.AutoSize = true;
            this.lbl_ts_zjts.Location = new System.Drawing.Point(245, 66);
            this.lbl_ts_zjts.Name = "lbl_ts_zjts";
            this.lbl_ts_zjts.Size = new System.Drawing.Size(65, 12);
            this.lbl_ts_zjts.TabIndex = 5;
            this.lbl_ts_zjts.Text = "追加条数：";
            // 
            // lbl_ts_zts
            // 
            this.lbl_ts_zts.AutoSize = true;
            this.lbl_ts_zts.Location = new System.Drawing.Point(358, 66);
            this.lbl_ts_zts.Name = "lbl_ts_zts";
            this.lbl_ts_zts.Size = new System.Drawing.Size(53, 12);
            this.lbl_ts_zts.TabIndex = 6;
            this.lbl_ts_zts.Text = "总条数：";
            // 
            // llab_show_log
            // 
            this.llab_show_log.AutoSize = true;
            this.llab_show_log.Location = new System.Drawing.Point(480, 66);
            this.llab_show_log.Name = "llab_show_log";
            this.llab_show_log.Size = new System.Drawing.Size(53, 12);
            this.llab_show_log.TabIndex = 7;
            this.llab_show_log.TabStop = true;
            this.llab_show_log.Text = "查看日志";
            this.llab_show_log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llab_show_log_LinkClicked);
            // 
            // lbl_dqsmzt
            // 
            this.lbl_dqsmzt.AutoSize = true;
            this.lbl_dqsmzt.ForeColor = System.Drawing.Color.Red;
            this.lbl_dqsmzt.Location = new System.Drawing.Point(111, 29);
            this.lbl_dqsmzt.Name = "lbl_dqsmzt";
            this.lbl_dqsmzt.Size = new System.Drawing.Size(233, 12);
            this.lbl_dqsmzt.TabIndex = 8;
            this.lbl_dqsmzt.Text = "正在扫描 开始时间：2015-10-14 21:02:37";
            // 
            // lbl_scsmsj
            // 
            this.lbl_scsmsj.AutoSize = true;
            this.lbl_scsmsj.ForeColor = System.Drawing.Color.Red;
            this.lbl_scsmsj.Location = new System.Drawing.Point(111, 66);
            this.lbl_scsmsj.Name = "lbl_scsmsj";
            this.lbl_scsmsj.Size = new System.Drawing.Size(119, 12);
            this.lbl_scsmsj.TabIndex = 8;
            this.lbl_scsmsj.Text = "2015-10-15 20:02:37";
            // 
            // lbl_zjts
            // 
            this.lbl_zjts.AutoSize = true;
            this.lbl_zjts.ForeColor = System.Drawing.Color.Red;
            this.lbl_zjts.Location = new System.Drawing.Point(316, 66);
            this.lbl_zjts.Name = "lbl_zjts";
            this.lbl_zjts.Size = new System.Drawing.Size(23, 12);
            this.lbl_zjts.TabIndex = 8;
            this.lbl_zjts.Text = "100";
            // 
            // lbl_zts
            // 
            this.lbl_zts.AutoSize = true;
            this.lbl_zts.ForeColor = System.Drawing.Color.Red;
            this.lbl_zts.Location = new System.Drawing.Point(417, 66);
            this.lbl_zts.Name = "lbl_zts";
            this.lbl_zts.Size = new System.Drawing.Size(41, 12);
            this.lbl_zts.TabIndex = 8;
            this.lbl_zts.Text = "123456";
            // 
            // lbl_ts_auto
            // 
            this.lbl_ts_auto.AutoSize = true;
            this.lbl_ts_auto.Location = new System.Drawing.Point(147, 23);
            this.lbl_ts_auto.Name = "lbl_ts_auto";
            this.lbl_ts_auto.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_auto.TabIndex = 9;
            this.lbl_ts_auto.Text = "是否自动执行：";
            // 
            // lbl_auto
            // 
            this.lbl_auto.AutoSize = true;
            this.lbl_auto.ForeColor = System.Drawing.Color.Red;
            this.lbl_auto.Location = new System.Drawing.Point(242, 23);
            this.lbl_auto.Name = "lbl_auto";
            this.lbl_auto.Size = new System.Drawing.Size(17, 12);
            this.lbl_auto.TabIndex = 8;
            this.lbl_auto.Text = "是";
            // 
            // lbl_ts_smjgsj
            // 
            this.lbl_ts_smjgsj.AutoSize = true;
            this.lbl_ts_smjgsj.Location = new System.Drawing.Point(280, 23);
            this.lbl_ts_smjgsj.Name = "lbl_ts_smjgsj";
            this.lbl_ts_smjgsj.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_smjgsj.TabIndex = 9;
            this.lbl_ts_smjgsj.Text = "扫描间隔时间：";
            // 
            // lbl_smjgsj
            // 
            this.lbl_smjgsj.AutoSize = true;
            this.lbl_smjgsj.ForeColor = System.Drawing.Color.Red;
            this.lbl_smjgsj.Location = new System.Drawing.Point(375, 23);
            this.lbl_smjgsj.Name = "lbl_smjgsj";
            this.lbl_smjgsj.Size = new System.Drawing.Size(17, 12);
            this.lbl_smjgsj.TabIndex = 8;
            this.lbl_smjgsj.Text = "高";
            // 
            // lbl_kjqd
            // 
            this.lbl_kjqd.AutoSize = true;
            this.lbl_kjqd.ForeColor = System.Drawing.Color.Red;
            this.lbl_kjqd.Location = new System.Drawing.Point(108, 23);
            this.lbl_kjqd.Name = "lbl_kjqd";
            this.lbl_kjqd.Size = new System.Drawing.Size(17, 12);
            this.lbl_kjqd.TabIndex = 8;
            this.lbl_kjqd.Text = "否";
            // 
            // lbl_ts_kjqd
            // 
            this.lbl_ts_kjqd.AutoSize = true;
            this.lbl_ts_kjqd.Location = new System.Drawing.Point(13, 23);
            this.lbl_ts_kjqd.Name = "lbl_ts_kjqd";
            this.lbl_ts_kjqd.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_kjqd.TabIndex = 9;
            this.lbl_ts_kjqd.Text = "是否开机启动：";
            // 
            // btn_sdzx
            // 
            this.btn_sdzx.Location = new System.Drawing.Point(360, 24);
            this.btn_sdzx.Name = "btn_sdzx";
            this.btn_sdzx.Size = new System.Drawing.Size(75, 23);
            this.btn_sdzx.TabIndex = 10;
            this.btn_sdzx.Text = "手动执行";
            this.btn_sdzx.UseVisualStyleBackColor = true;
            this.btn_sdzx.Click += new System.EventHandler(this.btn_sdzx_Click);
            // 
            // lbl_smwj
            // 
            this.lbl_smwj.AutoSize = true;
            this.lbl_smwj.ForeColor = System.Drawing.Color.Red;
            this.lbl_smwj.Location = new System.Drawing.Point(109, 24);
            this.lbl_smwj.Name = "lbl_smwj";
            this.lbl_smwj.Size = new System.Drawing.Size(101, 12);
            this.lbl_smwj.TabIndex = 8;
            this.lbl_smwj.Text = "D://file/123.dbf";
            // 
            // lbl_ts_smwj
            // 
            this.lbl_ts_smwj.AutoSize = true;
            this.lbl_ts_smwj.Location = new System.Drawing.Point(13, 24);
            this.lbl_ts_smwj.Name = "lbl_ts_smwj";
            this.lbl_ts_smwj.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_smwj.TabIndex = 9;
            this.lbl_ts_smwj.Text = "扫描目录文件：";
            // 
            // lbl_dbs
            // 
            this.lbl_dbs.AutoSize = true;
            this.lbl_dbs.ForeColor = System.Drawing.Color.Red;
            this.lbl_dbs.Location = new System.Drawing.Point(108, 56);
            this.lbl_dbs.Name = "lbl_dbs";
            this.lbl_dbs.Size = new System.Drawing.Size(59, 12);
            this.lbl_dbs.TabIndex = 8;
            this.lbl_dbs.Text = "127.0.0.1";
            // 
            // lbl_ts_dbs
            // 
            this.lbl_ts_dbs.AutoSize = true;
            this.lbl_ts_dbs.Location = new System.Drawing.Point(13, 56);
            this.lbl_ts_dbs.Name = "lbl_ts_dbs";
            this.lbl_ts_dbs.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_dbs.TabIndex = 9;
            this.lbl_ts_dbs.Text = "上传数据库IP：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ts_error);
            this.groupBox1.Controls.Add(this.btn_cwcl);
            this.groupBox1.Controls.Add(this.llbl_show_errorlog);
            this.groupBox1.Controls.Add(this.lbl_error);
            this.groupBox1.Controls.Add(this.lbl_dqsmzt);
            this.groupBox1.Controls.Add(this.lbl_ts_dqsmzt);
            this.groupBox1.Controls.Add(this.btn_sdzx);
            this.groupBox1.Controls.Add(this.lbl_ts_scsmsj);
            this.groupBox1.Controls.Add(this.lbl_ts_zjts);
            this.groupBox1.Controls.Add(this.lbl_ts_zts);
            this.groupBox1.Controls.Add(this.llab_show_log);
            this.groupBox1.Controls.Add(this.lbl_scsmsj);
            this.groupBox1.Controls.Add(this.lbl_zjts);
            this.groupBox1.Controls.Add(this.lbl_zts);
            this.groupBox1.Location = new System.Drawing.Point(23, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 137);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描状态";
            // 
            // lbl_ts_error
            // 
            this.lbl_ts_error.AutoSize = true;
            this.lbl_ts_error.Location = new System.Drawing.Point(16, 103);
            this.lbl_ts_error.Name = "lbl_ts_error";
            this.lbl_ts_error.Size = new System.Drawing.Size(89, 12);
            this.lbl_ts_error.TabIndex = 12;
            this.lbl_ts_error.Text = "是否发生错误：";
            // 
            // btn_cwcl
            // 
            this.btn_cwcl.Location = new System.Drawing.Point(247, 98);
            this.btn_cwcl.Name = "btn_cwcl";
            this.btn_cwcl.Size = new System.Drawing.Size(75, 23);
            this.btn_cwcl.TabIndex = 15;
            this.btn_cwcl.Text = "错误处理";
            this.btn_cwcl.UseVisualStyleBackColor = true;
            // 
            // llbl_show_errorlog
            // 
            this.llbl_show_errorlog.AutoSize = true;
            this.llbl_show_errorlog.Location = new System.Drawing.Point(147, 103);
            this.llbl_show_errorlog.Name = "llbl_show_errorlog";
            this.llbl_show_errorlog.Size = new System.Drawing.Size(77, 12);
            this.llbl_show_errorlog.TabIndex = 13;
            this.llbl_show_errorlog.TabStop = true;
            this.llbl_show_errorlog.Text = "查看错误日志";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(111, 103);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(17, 12);
            this.lbl_error.TabIndex = 14;
            this.lbl_error.Text = "否";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_smwj);
            this.groupBox2.Controls.Add(this.lbl_tablename);
            this.groupBox2.Controls.Add(this.lbl_dbsname);
            this.groupBox2.Controls.Add(this.lbl_port);
            this.groupBox2.Controls.Add(this.lbl_dbs);
            this.groupBox2.Controls.Add(this.lbl_ts_smwj);
            this.groupBox2.Controls.Add(this.lbl_ts_tablename);
            this.groupBox2.Controls.Add(this.lbl_ts_dbsname);
            this.groupBox2.Controls.Add(this.lbl_ts_port);
            this.groupBox2.Controls.Add(this.lbl_ts_dbs);
            this.groupBox2.Location = new System.Drawing.Point(23, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 80);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本配置";
            // 
            // lbl_tablename
            // 
            this.lbl_tablename.AutoSize = true;
            this.lbl_tablename.ForeColor = System.Drawing.Color.Red;
            this.lbl_tablename.Location = new System.Drawing.Point(475, 56);
            this.lbl_tablename.Name = "lbl_tablename";
            this.lbl_tablename.Size = new System.Drawing.Size(41, 12);
            this.lbl_tablename.TabIndex = 8;
            this.lbl_tablename.Text = "Result";
            // 
            // lbl_dbsname
            // 
            this.lbl_dbsname.AutoSize = true;
            this.lbl_dbsname.ForeColor = System.Drawing.Color.Red;
            this.lbl_dbsname.Location = new System.Drawing.Point(369, 56);
            this.lbl_dbsname.Name = "lbl_dbsname";
            this.lbl_dbsname.Size = new System.Drawing.Size(23, 12);
            this.lbl_dbsname.TabIndex = 8;
            this.lbl_dbsname.Text = "DBF";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.ForeColor = System.Drawing.Color.Red;
            this.lbl_port.Location = new System.Drawing.Point(242, 56);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(29, 12);
            this.lbl_port.TabIndex = 8;
            this.lbl_port.Text = "1521";
            // 
            // lbl_ts_tablename
            // 
            this.lbl_ts_tablename.AutoSize = true;
            this.lbl_ts_tablename.Location = new System.Drawing.Point(428, 56);
            this.lbl_ts_tablename.Name = "lbl_ts_tablename";
            this.lbl_ts_tablename.Size = new System.Drawing.Size(41, 12);
            this.lbl_ts_tablename.TabIndex = 9;
            this.lbl_ts_tablename.Text = "表名：";
            // 
            // lbl_ts_dbsname
            // 
            this.lbl_ts_dbsname.AutoSize = true;
            this.lbl_ts_dbsname.Location = new System.Drawing.Point(303, 56);
            this.lbl_ts_dbsname.Name = "lbl_ts_dbsname";
            this.lbl_ts_dbsname.Size = new System.Drawing.Size(65, 12);
            this.lbl_ts_dbsname.TabIndex = 9;
            this.lbl_ts_dbsname.Text = "数据库名：";
            // 
            // lbl_ts_port
            // 
            this.lbl_ts_port.AutoSize = true;
            this.lbl_ts_port.Location = new System.Drawing.Point(195, 56);
            this.lbl_ts_port.Name = "lbl_ts_port";
            this.lbl_ts_port.Size = new System.Drawing.Size(41, 12);
            this.lbl_ts_port.TabIndex = 9;
            this.lbl_ts_port.Text = "端口：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_ts_auto);
            this.groupBox3.Controls.Add(this.lbl_ts_kjqd);
            this.groupBox3.Controls.Add(this.lbl_ts_smjgsj);
            this.groupBox3.Controls.Add(this.lbl_auto);
            this.groupBox3.Controls.Add(this.lbl_smjgsj);
            this.groupBox3.Controls.Add(this.lbl_kjqd);
            this.groupBox3.Location = new System.Drawing.Point(23, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 51);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "服务配置";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 377);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Main";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激活ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
        private System.Windows.Forms.Label lbl_ts_dqsmzt;
        private System.Windows.Forms.Label lbl_ts_scsmsj;
        private System.Windows.Forms.Label lbl_ts_zjts;
        private System.Windows.Forms.Label lbl_ts_zts;
        private System.Windows.Forms.LinkLabel llab_show_log;
        private System.Windows.Forms.Label lbl_dqsmzt;
        private System.Windows.Forms.Label lbl_scsmsj;
        private System.Windows.Forms.Label lbl_zjts;
        private System.Windows.Forms.Label lbl_zts;
        private System.Windows.Forms.Label lbl_ts_auto;
        private System.Windows.Forms.Label lbl_auto;
        private System.Windows.Forms.Label lbl_ts_smjgsj;
        private System.Windows.Forms.Label lbl_smjgsj;
        private System.Windows.Forms.Label lbl_kjqd;
        private System.Windows.Forms.Label lbl_ts_kjqd;
        private System.Windows.Forms.Button btn_sdzx;
        private System.Windows.Forms.Label lbl_smwj;
        private System.Windows.Forms.Label lbl_ts_smwj;
        private System.Windows.Forms.Label lbl_dbs;
        private System.Windows.Forms.Label lbl_ts_dbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_ts_error;
        private System.Windows.Forms.Button btn_cwcl;
        private System.Windows.Forms.LinkLabel llbl_show_errorlog;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_tablename;
        private System.Windows.Forms.Label lbl_dbsname;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ts_tablename;
        private System.Windows.Forms.Label lbl_ts_dbsname;
        private System.Windows.Forms.Label lbl_ts_port;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}