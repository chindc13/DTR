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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        public void clear_data()
        {
            ss_course.Clear();
            ss_section.Clear();
            s_year.Clear();
            s_rfid.Clear();
            sl_rfid.Text = "";
            s_name.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_section",dataGridView1);
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_course", dataGridView2);
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_student", dataGridView3);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_section", dataGridView1);
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_course", dataGridView2);
            Class.MySqlQueryEngine.loadComboBox("SELECT section_id,section_name FROM tbl_section", s_section, "section_id", "section_name");
            Class.MySqlQueryEngine.loadComboBox("SELECT course_id,course_name FROM tbl_course", s_course, "course_id", "course_name");
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_student", dataGridView3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.QueryManager("INSERT INTO tbl_section (section_name) VALUES ('" + ss_section.Text +"')","Add");
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_section", dataGridView1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.QueryManager("INSERT INTO tbl_course (course_name) VALUES ('" + ss_course.Text
               + "')", "Add");
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_course", dataGridView2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.QueryManager("DELETE FROM tbl_section WHERE section_id="+int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), "Delete");
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_section", dataGridView1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.QueryManager("DELETE FROM tbl_course WHERE course_id=" + int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), "Delete");
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM tbl_section", dataGridView2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class.SearchEngineClass.SearchGridView(textBox1.Text,comboBox1.Text,dataGridView3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txt_path.Text = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
            if (s_rfid.TextLength == 10)
            {
                sl_rfid.Text = s_rfid.Text;
                s_rfid.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sl_rfid.Text))
            {
                MessageBox.Show("RFID is null please insert proper RFID CODE thank you","Message");
            }
            else
            {
                Class.MySqlQueryEngine.queryWithImage("INSERT INTO tbl_student (student_name,section,section_id,course,course_id,year,image,rfidCode) VALUES ('" + s_name.Text +"','"+ s_section.Text +"','"+ s_section.SelectedValue +"','"+ s_course.Text +"','"+ s_course.SelectedValue +"','"+ s_year.Text +"',@img,'"+ sl_rfid.Text + "')", pictureBox1, "Add");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s_code.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            s_name.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            s_year.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            sl_rfid.Text = dataGridView3.CurrentRow.Cells[8].Value.ToString();

            Class.SearchEngineClass.searchImage("SELECT image FROM tbl_student WHERE is_deleted=0 student_id=" + int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString()),pictureBox1,0,0);

            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sl_rfid.Text) || String.IsNullOrEmpty(s_code.Text))
            {
                MessageBox.Show("RFID & Student Code is null please insert proper RFID CODE & Student Code thank you", "Message");
            }
            else
            {
                Class.MySqlQueryEngine.queryWithImage("UPDATE tbl_student SET student_name='"+ s_name.Text +"',section='"+ s_section.Text +"',section_id='"+ s_section.SelectedValue +"',course='"+ s_course.Text +"',course_id='"+ s_course.SelectedValue + "',year='"+ s_year.Text +"',image=@img,rfidCode='"+ sl_rfid.Text +"' WHERE student_id=" + int.Parse(s_code.Text), pictureBox1, "Edit");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sl_rfid.Text) || String.IsNullOrEmpty(s_code.Text))
            {
                MessageBox.Show("RFID & Student Code is null please insert proper RFID CODE & Student Code thank you", "Message");
            }
            else
            {
                Class.MySqlQueryEngine.queryWithImage("UPDATE tbl_student SET is_deleted = 1 WHERE student_id=" + int.Parse(s_code.Text), pictureBox1, "Delete");
            }
        }
    }
}
