using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTR_RFID
{
    public partial class Form1 : Form
    {
        String str_rfidcode = "";

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            stime.Text = DateTime.Now.ToLongTimeString();
            sdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stime.Text = DateTime.Now.ToLongTimeString();
            sdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.Alt && e.KeyCode ==  Keys.F1)
            {
                this.Hide();
                Login l = new Login();
                l.Show();
            }
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
            
            rfidCode.Text = txt_rfidcode.Text;
            str_rfidcode = txt_rfidcode.Text;

            if (txt_rfidcode.TextLength == 10)
            {
                Class.SearchEngineClass.searchComboBox("SELECT `name` AS 'NAME',`account_id` AS 'ACCOUNT_CODE' FROM tbl_accounts WHERE RFIDCode = '" + txt_rfidcode.Text + "' AND is_deleted = 0 UNION ALL SELECT `student_name` AS 'NAME' ,`student_id` AS 'ACCOUNT_CODE' FROM tbl_student WHERE RFIDCode = '" + txt_rfidcode.Text + "' AND is_deleted = 0", "RFID SCAN", "NAME", txt_name);

                Class.SearchEngineClass.searchComboBox("SELECT `name` AS 'NAME',`account_id` AS 'ACCOUNT_CODE' FROM tbl_accounts WHERE RFIDCode = '" + txt_rfidcode.Text + "' AND is_deleted = 0 UNION ALL SELECT `student_name` AS 'NAME' ,`student_id` AS 'ACCOUNT_CODE' FROM tbl_student WHERE RFIDCode = '" + txt_rfidcode.Text + "' AND is_deleted = 0", "RFID SCAN", "ACCOUNT_CODE", account_code);

                
                Class.MySqlQueryEngine.QueryManager("INSERT INTO tbl_dailytimerecord (account_id,time,date,rfidcode) VALUES ('" + account_code.Text + "',NOW(),NOW(),'"+ rfidCode.Text +"')", "Add");

                Class.SearchEngineClass.searchImage("SELECT image FROM tbl_accounts WHERE RFIDCode = '" + txt_rfidcode.Text + "' AND is_deleted = 0 UNION ALL SELECT image FROM tbl_student WHERE RFIDCode = '" + txt_rfidcode.Text + "' AND is_deleted = 0", pictureBox1, 0, 0);





                txt_rfidcode.Clear();
            }
        }
    }
}
