using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTR_RFID.Forms
{
    public partial class ToolsForm : Form
    {

        String sMainmenu = "0";
        String sDepartment = "0";
        String sPosition = "0";
        String sEmployee = "0";
        String sTools = "0";
        String sReport = "0";
        String sStudent = "0";

        String Status = "";


        public ToolsForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class.SearchEngineClass.SearchGridView(textBox1.Text, "employee",dataGridView1);
        }

        private void ToolsForm_Load(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_accounts WHERE authority = 1", dataGridView1);
            Class.MySqlQueryEngine.LoadGrid("Select tbl_accounts.account_id,tbl_accounts.name,tbl_accesslevel.* from `tbl_accesslevel`,`tbl_accounts` WHERE authority = 1 and tbl_accounts.account_id=tbl_accesslevel.account_id", dataGridView2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_accounts WHERE authority = 1", dataGridView1);
            Class.MySqlQueryEngine.LoadGrid("Select tbl_accounts.account_id,tbl_accounts.name,tbl_accesslevel.* from `tbl_accesslevel`,`tbl_accounts` WHERE authority = 1 and tbl_accounts.account_id=tbl_accesslevel.account_id", dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_accountcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_accountname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            button2.Text = "Add";
            Status = "Add";
        }

        private void c_Main_CheckedChanged(object sender, EventArgs e)
        {
            if(c_Main.Checked == true)
            {
                sMainmenu = "1";
            }
            else
            {
                sMainmenu = "0";
            }
        }

        private void c_dept_CheckedChanged(object sender, EventArgs e)
        {
            if (c_dept.Checked == true)
            {
                sDepartment = "1";
            }
            else
            {
                sDepartment = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                sPosition = "1";
            }
            else
            {
                sPosition = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                sEmployee = "1";
            }
            else
            {
                sEmployee = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                sTools = "1";
            }
            else
            {
                sTools = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                sReport = "1";
            }
            else
            {
                sReport = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Status == "Add")
            {
                if (String.IsNullOrEmpty(txt_accountcode.Text) || String.IsNullOrEmpty(txt_accountname.Text))
                {
                    MessageBox.Show("Select data to give access", "Message");
                }
                else
                {
                    Class.MySqlQueryEngine.QueryManager("INSERT INTO tbl_accesslevel (account_id,account_name,main_menu,department,position,employee_maintenance,tools,student,report) VALUES ('" + txt_accountcode.Text +"','"+ txt_accountname.Text +"','"+ sMainmenu +"','"+ sDepartment +"','"+ sPosition +"','"+ sEmployee +"','"+ sTools +"','"+ sStudent +"', '"+ sReport +"')", "Add");
                }
            }
            else if (Status == "Edit")
            {
                if (String.IsNullOrEmpty(txt_accountcode.Text) || String.IsNullOrEmpty(txt_accountname.Text))
                {
                    MessageBox.Show("Select data to give access", "Message");
                }
                else
                {
                    Class.MySqlQueryEngine.QueryManager("UPDATE tbl_accesslevel SET main_menu='"+ sMainmenu +"',department='"+ sDepartment +"',position='"+ sPosition +"',employee_maintenance='"+ sEmployee +"',tools='"+ sTools +"',student='"+ sStudent +"',report='"+ sReport +"' WHERE account_id="+ int.Parse(txt_accountcode.Text),"Edit");
                }
            }
            else
            {
                MessageBox.Show("Error", "");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            txt_accountcode.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_accountname.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            button2.Text = "Edit";
            Status = "Edit";

            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sStudent = "1";
            }
            else
            {
                sStudent = "0";
            }
        }
    }
}
