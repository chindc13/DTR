namespace DTR_RFID.Forms
{
    partial class MainMenu
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_report = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.db = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.stime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_tools = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btnmenu_position = new System.Windows.Forms.Button();
            this.btnmenu_department = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.fbtn_student = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.s_student = new System.Windows.Forms.ToolStripMenuItem();
            this.s_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.s_department = new System.Windows.Forms.ToolStripMenuItem();
            this.s_position = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_student = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_dept = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_position = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moduleToolStripMenuItem,
            this.ms_report,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(892, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_student,
            this.ms_employee,
            this.ms_dept,
            this.ms_position});
            this.moduleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // ms_report
            // 
            this.ms_report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ms_report.Name = "ms_report";
            this.ms_report.Size = new System.Drawing.Size(54, 19);
            this.ms_report.Text = "Report";
            this.ms_report.Click += new System.EventHandler(this.ms_report_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_tools});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.s_student,
            this.s_employee,
            this.s_department,
            this.s_position});
            this.menuStrip2.Location = new System.Drawing.Point(0, 25);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(892, 29);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user,
            this.toolStripSeparator1,
            this.db});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(892, 23);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(434, 18);
            this.user.Spring = true;
            this.user.Text = "user";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // db
            // 
            this.db.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.db.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(434, 18);
            this.db.Spring = true;
            this.db.Text = "database";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.statusStrip2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stime,
            this.toolStripSeparator2,
            this.sdate});
            this.statusStrip2.Location = new System.Drawing.Point(0, 547);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip2.Size = new System.Drawing.Size(892, 23);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.Stretch = false;
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // stime
            // 
            this.stime.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.stime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stime.Name = "stime";
            this.stime.Size = new System.Drawing.Size(434, 18);
            this.stime.Spring = true;
            this.stime.Text = "time";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // sdate
            // 
            this.sdate.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.sdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(434, 18);
            this.sdate.Spring = true;
            this.sdate.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(207, 493);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 193);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(187, 290);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_tools);
            this.tabPage1.Controls.Add(this.btn_report);
            this.tabPage1.Controls.Add(this.btnmenu_position);
            this.tabPage1.Controls.Add(this.btnmenu_department);
            this.tabPage1.Controls.Add(this.btn_employee);
            this.tabPage1.Controls.Add(this.btn_student);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(179, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fbtn_student);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(179, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Maintenance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(207, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 493);
            this.panel2.TabIndex = 6;
            // 
            // btn_tools
            // 
            this.btn_tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btn_tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tools.Enabled = false;
            this.btn_tools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tools.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tools.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tools.Image = global::DTR_RFID.Properties.Resources.cog;
            this.btn_tools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tools.Location = new System.Drawing.Point(3, 198);
            this.btn_tools.Name = "btn_tools";
            this.btn_tools.Size = new System.Drawing.Size(173, 39);
            this.btn_tools.TabIndex = 5;
            this.btn_tools.Text = "Tools";
            this.btn_tools.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tools.UseVisualStyleBackColor = false;
            this.btn_tools.Click += new System.EventHandler(this.btn_tools_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_report.Enabled = false;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_report.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_report.Image = global::DTR_RFID.Properties.Resources.report;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(3, 159);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(173, 39);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btnmenu_position
            // 
            this.btnmenu_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnmenu_position.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu_position.Enabled = false;
            this.btnmenu_position.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmenu_position.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu_position.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmenu_position.Image = global::DTR_RFID.Properties.Resources.user_silhouette;
            this.btnmenu_position.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu_position.Location = new System.Drawing.Point(3, 120);
            this.btnmenu_position.Name = "btnmenu_position";
            this.btnmenu_position.Size = new System.Drawing.Size(173, 39);
            this.btnmenu_position.TabIndex = 3;
            this.btnmenu_position.Text = "Position";
            this.btnmenu_position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmenu_position.UseVisualStyleBackColor = false;
            this.btnmenu_position.Click += new System.EventHandler(this.btnmenu_position_Click);
            // 
            // btnmenu_department
            // 
            this.btnmenu_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnmenu_department.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu_department.Enabled = false;
            this.btnmenu_department.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmenu_department.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu_department.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmenu_department.Image = global::DTR_RFID.Properties.Resources.application_tile_horizontal;
            this.btnmenu_department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu_department.Location = new System.Drawing.Point(3, 81);
            this.btnmenu_department.Name = "btnmenu_department";
            this.btnmenu_department.Size = new System.Drawing.Size(173, 39);
            this.btnmenu_department.TabIndex = 2;
            this.btnmenu_department.Text = "Department";
            this.btnmenu_department.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmenu_department.UseVisualStyleBackColor = false;
            this.btnmenu_department.Click += new System.EventHandler(this.btnmenu_department_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btn_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employee.Enabled = false;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_employee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_employee.Image = global::DTR_RFID.Properties.Resources.user_business_boss;
            this.btn_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee.Location = new System.Drawing.Point(3, 42);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(173, 39);
            this.btn_employee.TabIndex = 1;
            this.btn_employee.Text = "Employee";
            this.btn_employee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btn_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_student.Enabled = false;
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_student.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_student.Image = global::DTR_RFID.Properties.Resources.user;
            this.btn_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_student.Location = new System.Drawing.Point(3, 3);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(173, 39);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "Student";
            this.btn_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // fbtn_student
            // 
            this.fbtn_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.fbtn_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbtn_student.Enabled = false;
            this.fbtn_student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fbtn_student.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtn_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fbtn_student.Image = global::DTR_RFID.Properties.Resources.user;
            this.fbtn_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtn_student.Location = new System.Drawing.Point(3, 3);
            this.fbtn_student.Name = "fbtn_student";
            this.fbtn_student.Size = new System.Drawing.Size(173, 39);
            this.fbtn_student.TabIndex = 3;
            this.fbtn_student.Text = "Student";
            this.fbtn_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fbtn_student.UseVisualStyleBackColor = false;
            this.fbtn_student.Click += new System.EventHandler(this.fbtn_student_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Image = global::DTR_RFID.Properties.Resources.printer;
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DTR_RFID.Properties.Resources.page_white_text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 23);
            // 
            // s_student
            // 
            this.s_student.Enabled = false;
            this.s_student.Image = global::DTR_RFID.Properties.Resources.user;
            this.s_student.Name = "s_student";
            this.s_student.Size = new System.Drawing.Size(28, 23);
            this.s_student.Click += new System.EventHandler(this.s_student_Click);
            // 
            // s_employee
            // 
            this.s_employee.Enabled = false;
            this.s_employee.Image = global::DTR_RFID.Properties.Resources.user_business;
            this.s_employee.Name = "s_employee";
            this.s_employee.Size = new System.Drawing.Size(28, 23);
            this.s_employee.Click += new System.EventHandler(this.s_employee_Click);
            // 
            // s_department
            // 
            this.s_department.Enabled = false;
            this.s_department.Image = global::DTR_RFID.Properties.Resources.application_tile_horizontal;
            this.s_department.Name = "s_department";
            this.s_department.Size = new System.Drawing.Size(28, 23);
            this.s_department.Click += new System.EventHandler(this.s_department_Click);
            // 
            // s_position
            // 
            this.s_position.Enabled = false;
            this.s_position.Image = global::DTR_RFID.Properties.Resources.user_silhouette;
            this.s_position.Name = "s_position";
            this.s_position.Size = new System.Drawing.Size(28, 23);
            this.s_position.Click += new System.EventHandler(this.s_position_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DTR_RFID.Properties.Resources.group;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Change User";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::DTR_RFID.Properties.Resources.cross_octagon;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // ms_student
            // 
            this.ms_student.Enabled = false;
            this.ms_student.Image = global::DTR_RFID.Properties.Resources.user;
            this.ms_student.Name = "ms_student";
            this.ms_student.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D1)));
            this.ms_student.Size = new System.Drawing.Size(200, 22);
            this.ms_student.Text = "Student";
            this.ms_student.Click += new System.EventHandler(this.ms_student_Click);
            // 
            // ms_employee
            // 
            this.ms_employee.Enabled = false;
            this.ms_employee.Image = global::DTR_RFID.Properties.Resources.user_business;
            this.ms_employee.Name = "ms_employee";
            this.ms_employee.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D2)));
            this.ms_employee.Size = new System.Drawing.Size(200, 22);
            this.ms_employee.Text = "Employee";
            // 
            // ms_dept
            // 
            this.ms_dept.Enabled = false;
            this.ms_dept.Image = global::DTR_RFID.Properties.Resources.application_tile_horizontal;
            this.ms_dept.Name = "ms_dept";
            this.ms_dept.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D3)));
            this.ms_dept.Size = new System.Drawing.Size(200, 22);
            this.ms_dept.Text = "Department";
            this.ms_dept.Click += new System.EventHandler(this.ms_dept_Click);
            // 
            // ms_position
            // 
            this.ms_position.Enabled = false;
            this.ms_position.Image = global::DTR_RFID.Properties.Resources.user_silhouette;
            this.ms_position.Name = "ms_position";
            this.ms_position.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D4)));
            this.ms_position.Size = new System.Drawing.Size(200, 22);
            this.ms_position.Text = "Position";
            this.ms_position.Click += new System.EventHandler(this.ms_position_Click);
            // 
            // ms_tools
            // 
            this.ms_tools.Image = global::DTR_RFID.Properties.Resources.cog;
            this.ms_tools.Name = "ms_tools";
            this.ms_tools.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ms_tools.Size = new System.Drawing.Size(143, 22);
            this.ms_tools.Text = "Tools";
            this.ms_tools.Click += new System.EventHandler(this.ms_tools_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Time Record - Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel user;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel db;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel stime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel sdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_student;
        private System.Windows.Forms.ToolStripMenuItem ms_employee;
        private System.Windows.Forms.ToolStripMenuItem ms_dept;
        private System.Windows.Forms.ToolStripMenuItem ms_position;
        private System.Windows.Forms.ToolStripMenuItem ms_report;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btn_tools;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btnmenu_position;
        private System.Windows.Forms.Button btnmenu_department;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem ms_tools;
        private System.Windows.Forms.Button fbtn_student;
        private System.Windows.Forms.ToolStripMenuItem s_student;
        private System.Windows.Forms.ToolStripMenuItem s_employee;
        private System.Windows.Forms.ToolStripMenuItem s_department;
        private System.Windows.Forms.ToolStripMenuItem s_position;
    }
}