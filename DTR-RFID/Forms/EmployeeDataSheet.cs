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
    public partial class EmployeeDataSheet : Form
    {
        public EmployeeDataSheet()
        {
            InitializeComponent();
        }
        String rfidString = "";

        public void clear_text() {
            e_name.Clear();
            e_add1.Clear();
            e_add2.Clear();
            e_tel2.Clear();
            e_cp2.Clear();
            school_c2.Clear();
            school_h2.Clear();
            e_emp2.Clear();
            e_email.Clear();
            rfid.Clear();
            rfid_label.Text = "Cleared";
        }

        private void school_h1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(school_h1.Text == "Graduate")
            {
                school_c1.Enabled = true;
                school_c2.Enabled = true;
            }
            else
            {
                school_c1.Text = "";
                school_c2.Text = "";
                school_c1.Enabled = false;
                school_c2.Enabled = false;
            }
        }

        private void EmployeeDataSheet_Load(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_accounts",dataGridView1);
            Class.MySqlQueryEngine.loadComboBox("SELECT position_id,position_name FROM tbl_position WHERE is_deleted = 0",e_position,"position_id","position_name");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Class.SearchEngineClass.SearchGridView(textBox10.Text,comboBox5.Text,dataGridView1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmployeeCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            e_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            e_add1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            e_add2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            e_tel2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            e_cp2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            school_h2.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            school_c2.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            e_emp2.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();

            String a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Class.SearchEngineClass.searchImage("SELECT image FROM tbl_accounts WHERE account_id =" + int.Parse(a.ToString()) ,pictureBox1,0,0);

            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.queryWithImage("INSERT INTO `tbl_accounts` (`name`,`birth`,`gender`,`address1`,`address2`,`tel`,`phone`,`email`,`civilstatus`,`highschool`,`college`,`degree`,`position`,`position_id`,`is_active`,`is_deleted`,`image`) VALUES ('" + e_name.Text + "'," + e_birth.Text + ",'" + e_gender.Text + "','" + e_add1.Text + "', '" + e_add2.Text + "', '" + e_tel1.Text + e_tel2.Text + "','" + e_cp1.Text + e_cp2.Text + "','" + e_email.Text + "','" + e_civilstatus.Text + "','" + school_h1.Text + " - " + school_h2.Text + "','" + school_c1 + " - " + school_c2 + "','" + school_c1.Text + "','" + e_position.Text + "','" + e_position.SelectedValue + "','1','0',@img)", pictureBox1, "Add");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox8.Text = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void stringCheck(int a)
        {
            Class.SearchEngineClass.searchString("SELECT authority FROM tbl_accounts WHERE account_id=" + a, "authority");
            
            if (Class.SearchEngineClass.getDataFromString.ToString() == "0")
            {
                checkBox1.Checked = false;
                Class.SearchEngineClass.getDataFromString = "0";
            }
            else if (Class.SearchEngineClass.getDataFromString.ToString() == "1")
            {
                checkBox1.Checked = true;
                Class.SearchEngineClass.getDataFromString = "1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rfid.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
            auser.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            apass.Text = Class.Base64Encryption.DecodeFrom64(dataGridView1.CurrentRow.Cells[23].Value.ToString());
            arpass.Text = Class.Base64Encryption.DecodeFrom64(dataGridView1.CurrentRow.Cells[23].Value.ToString());
            
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            EmployeeCode.Text = a.ToString();
            
            Class.SearchEngineClass.searchImage("SELECT image FROM tbl_accounts WHERE account_id =" + int.Parse(a.ToString()), pictureBox1, 0, 0);
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];

            stringCheck(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_accounts", dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void e_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class.SearchEngineClass.searchComboBox("SELECT tbl_position.*,tbl_department2.* FROM tbl_position,tbl_department2 WHERE tbl_position.department_id=tbl_department2.department_id AND tbl_position.position_id=" + int.Parse(e_position.SelectedValue.ToString()), "POSITION","position_desc",e_positiondesc);

            Class.SearchEngineClass.searchComboBox("SELECT tbl_position.*,tbl_department2.* FROM tbl_position,tbl_department2 WHERE tbl_position.department_id=tbl_department2.department_id AND tbl_position.position_id=" + int.Parse(e_position.SelectedValue.ToString()), "POSITION", "department_name", e_department);
        }

        private void e_tel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EmployeeCode.Text))
            {
                MessageBox.Show("Please select data.", "Message");
            }
            else
            {
                Class.MySqlQueryEngine.queryWithImage("UPDATE `tbl_accounts` SET `name`='" + e_name.Text + "',`birth`='" + e_birth.Text + "',`gender`='" + e_gender.Text + "',`address1`='" + e_add1.Text + "',`address2`='" + e_add2.Text + "',`tel`='" + e_tel2.Text + "',`phone`='" + e_cp2.Text + "',`email`='" + e_email.Text + "',`civilstatus`='" + e_civilstatus.Text + "',`highschool`='" + school_h1.Text + " - " + school_h2.Text + "',`college`='" + school_c1.Text + " - " + school_c2.Text + "',`degree`='" + school_c1.Text + "',`position`='" + e_position.Text + "',`position_id`='" + e_position.SelectedValue + "',`image`=@img WHERE account_id='" + EmployeeCode.Text + "'", pictureBox1, "Edit");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EmployeeCode.Text))
            {
                MessageBox.Show("Please select data.", "Message");
            }
            else
            {
                Class.MySqlQueryEngine.queryWithImage("UPDATE `tbl_accounts` SET `is_deleted`='1' WHERE account_id='" + EmployeeCode.Text + "'", pictureBox1, "Delete");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EmployeeCode.Text))
            {
                MessageBox.Show("* Please select data \n* Please check authorization \n*Please check pass if empty", "Message");
            }
            else if (checkBox1.Checked == false && auser.Enabled == false && apass.Enabled == false)
            {
                Class.MySqlQueryEngine.QueryManager("UPDATE tbl_accounts SET auser='" + auser.Text + "', apass='" + Class.Base64Encryption.EncodeTo64(apass.Text) + "',authority='" + Class.SearchEngineClass.getDataFromString.ToString() + "', RFIDCode='" + rfid_label.Text + "' WHERE account_id=" + int.Parse(EmployeeCode.Text), "Edit");
            }
            else
            {
                if (String.IsNullOrEmpty(apass.Text) || String.IsNullOrEmpty(arpass.Text))
                {
                    MessageBox.Show("* Please select data \n* Please check authorization \n*Please check pass if empty", "Message");
                }
                else
                {
                    if (auser.Text != "" && apass.Text == arpass.Text)
                    {
                        Class.MySqlQueryEngine.QueryManager("UPDATE tbl_accounts SET auser='" + auser.Text + "', apass='" + Class.Base64Encryption.EncodeTo64(apass.Text) + "',authority='" + Class.SearchEngineClass.getDataFromString.ToString() + "', RFIDCode='" + rfid_label.Text + "' WHERE account_id=" + int.Parse(EmployeeCode.Text), "Edit");
                    }
                    else
                    {
                        MessageBox.Show("Password did not match", "Message");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Class.SearchEngineClass.getDataFromString = "0";
                auser.Enabled = false;
                auser.Clear();
                apass.Enabled = false;
                apass.Clear();
                arpass.Enabled = false;
                arpass.Clear();
            }
            else if (checkBox1.Checked == true)
            {
                auser.Enabled = true;
                apass.Enabled = true;
                arpass.Enabled = true;
                Class.SearchEngineClass.getDataFromString = "1";
            }
        }


        private void rfid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rfid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
            if(rfid.TextLength == 10)
            {
                rfid_label.Text = rfid.Text;
                rfidString = rfid.Text;
                rfid.Clear();
            }
        }
    }
}
