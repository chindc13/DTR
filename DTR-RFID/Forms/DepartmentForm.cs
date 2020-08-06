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
    public partial class DepartmentForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
        MySqlCommand cmd;
        MySqlDataReader dr;
        int a = 0;

        public DepartmentForm()
        {
            InitializeComponent();
        }

        public void clear_datasheet()
        {
            ddesc.Clear();
            dname.Clear();
            did.Clear();
        }

        private void query_department(String status)
        {
            try
            {
                connection.Open();
                cmd = new MySqlCommand();
                cmd.Connection = connection;
                if (status == "new_department")
                {
                    cmd.CommandText = "INSERT INTO `tbl_department2`(`department_name`,`department_desc`,`creation`,`is_deleted`) VALUES ('"+ dname.Text +"','"+ ddesc.Text +"', NOW(),'0'); ";
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("New department successfully added", "Message:");
                        clear_datasheet();
                    }
                    else {
                        MessageBox.Show("Error on adding new department please check your fields. thank you", "Message:");
                    }
                }
                else if (status == "edit_department")
                {
                    cmd.CommandText = "UPDATE tbl_department2 SET department_name = "+ dname.Text + ", department_desc = "+ ddesc.Text +" WHERE department_id=" + did.Text;
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Edit successfully in department", "Message:");
                        clear_datasheet();
                    }
                    else {
                        MessageBox.Show("Error on editing the department please check your fields. thank you", "Message:");
                    }
                }
                else if (status == "delete_department")
                {
                    cmd.CommandText = "UPDATE tbl_department2 SET is_deleted = 1 WHERE department_id=" + did.Text;
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to remove this department ??", "Removing", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                clear_datasheet();
                                MessageBox.Show("Delete successfully.", "Message:");
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                    else {
                        MessageBox.Show("Error on deleting the department please check your fields. thank you", "Message:");
                    }
                }
                else
                {
                    MessageBox.Show("Error on MySQL: Error 101.", "Message:");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Message MySQL Error: ");
            }
            finally
            {
                connection.Close();
                Class.MySqlQueryEngine.LoadGrid("SELECT * FROM `tbl_department2`",dataGridView1);
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM `tbl_department2`", dataGridView1);
            this.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear_datasheet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            did.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ddesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //department_search_grid();
            Class.SearchEngineClass.SearchGridView(txt_searchgrid.Text,cmb_search_crit.Text,dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            query_department("delete_department");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query_department("edit_department");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query_department("new_department");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM `tbl_department2`", dataGridView1);
        }
    }
}
