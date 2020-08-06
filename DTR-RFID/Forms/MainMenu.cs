using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DTR_RFID.Forms
{
    public partial class MainMenu : Form
    {
        MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MainMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            stime.Text = DateTime.Now.ToLongTimeString();
            sdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            user.Text = "ACCT-" + Class.UserClass.user_id + " : " + Class.UserClass.account_name;
            db.Text = "Database / Server Name: " + Server.DatabaseSever.databasename;
        }

        //Access Level
        public void loadAccess()
        {
            try
            {
                cmd = new MySqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT tbl_accesslevel.* FROM tbl_accesslevel INNER JOIN tbl_accounts ON tbl_accounts.account_id = tbl_accesslevel.account_id  WHERE tbl_accounts.account_id=" + Class.UserClass.user_id;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //department access
                    if (dr[4].ToString() == "1"){
                        btnmenu_department.Enabled = true;
                        ms_dept.Enabled = true;
                        s_department.Enabled = true;
                    }
                    //position
                    if (dr[5].ToString() == "1") {
                        ms_position.Enabled = true;
                        btnmenu_position.Enabled = true;
                        s_position.Enabled = true;
                    }
                    //Employee
                    if (dr[6].ToString() == "1")
                    {
                        ms_employee.Enabled = true;
                        btn_employee.Enabled = true;
                        s_employee.Enabled = true;
                    }
                    //tools
                    if (dr[7].ToString() == "1")
                    {
                        btn_tools.Enabled = true;
                        ms_tools.Enabled = true;
                    }
                    //student
                    if (dr[8].ToString() == "1")
                    {
                        btn_student.Enabled = true;
                        ms_student.Enabled = true;
                        s_student.Enabled = true;
                        fbtn_student.Enabled = true;
                    }
                    //report
                    if (dr[9].ToString() == "1")
                    {
                        btn_report.Enabled = true;
                        ms_report.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No User Found !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            loadAccess();
            Class.SearchEngineClass.searchImage("SELECT image FROM tbl_accounts WHERE account_id =" + int.Parse(Class.UserClass.user_id.ToString()), pictureBox1, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stime.Text = DateTime.Now.ToLongTimeString();
            sdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application ?", "Message : ", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change user ?", "Message : ", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Login l = new Login();
                l.Show();
            }
        }

        private void btnmenu_department_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void ms_dept_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void ms_position_Click(object sender, EventArgs e)
        {
            PositionForm df = new PositionForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void btnmenu_position_Click(object sender, EventArgs e)
        {
            PositionForm df = new PositionForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            EmployeeDataSheet df = new EmployeeDataSheet();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void btn_tools_Click(object sender, EventArgs e)
        {
            ToolsForm df = new ToolsForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void ms_tools_Click(object sender, EventArgs e)
        {
            ToolsForm df = new ToolsForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentForm df = new StudentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void fbtn_student_Click(object sender, EventArgs e)
        {
            StudentForm df = new StudentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void ms_student_Click(object sender, EventArgs e)
        {
            StudentForm df = new StudentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void s_student_Click(object sender, EventArgs e)
        {
            StudentForm df = new StudentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void s_employee_Click(object sender, EventArgs e)
        {
            EmployeeDataSheet df = new EmployeeDataSheet();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void s_department_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void s_position_Click(object sender, EventArgs e)
        {
            PositionForm df = new PositionForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void ms_report_Click(object sender, EventArgs e)
        {
            ReportData df = new ReportData();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportData df = new ReportData();
            df.TopLevel = false;
            df.AutoScroll = true;
            this.panel2.Controls.Add(df);
            df.Show();
        }
    }
}
