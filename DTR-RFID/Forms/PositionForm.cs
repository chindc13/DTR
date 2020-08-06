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
    public partial class PositionForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        int a = 0;

        public void cleardata()
        {
            pid.Clear();
            pname.Clear();
            pdesc.Clear();
        }


        public PositionForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

        private void query_position(String status)
        {
            try
            {
                connection.Open();
                cmd = new MySqlCommand();
                cmd.Connection = connection;
                if (status == "new_position")
                {
                    cmd.CommandText = "INSERT INTO `tbl_position` (`position_name`,`position_desc`,`department_id`,`creation`,`is_deleted`) VALUES('"+ pname.Text +"','"+pdesc.Text+"','"+passign.SelectedValue + "', NOW(), '0'); ";
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("New department successfully added", "Message:");
                        cleardata();
                    }
                    else {
                        MessageBox.Show("Error on adding new department please check your fields. thank you", "Message:");
                    }
                }
                else if (status == "edit_position")
                {
                    cmd.CommandText = "UPDATE `tbl_position` SET `position_name` = '"+ pname.Text +"',`position_desc` = '"+pdesc.Text+"',`department_id` = '"+passign.SelectedValue+"' WHERE  `position_id` = '"+ pid.Text +"'; ";
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Edit successfully in department", "Message:");
                        cleardata();
                    }
                    else {
                        MessageBox.Show("Error on editing the department please check your fields. thank you", "Message:");
                    }
                }
                else if (status == "remove_position")
                {
                    cmd.CommandText = "UPDATE  `tbl_position` SET is_deleted = 1 WHERE  `position_id` = '" + pid.Text + "';";
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to remove this department ??", "Removing", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                cleardata();
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
                Class.MySqlQueryEngine.LoadGrid("SELECT * FROM `tbl_position`", dataGridView1);
            }
        }


        private void PositionForm_Load(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.loadComboBox("select department_id,department_name from tbl_department2 where is_deleted = 0;",passign, "department_id", "department_name");
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM `tbl_position`", dataGridView1);
            this.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class.MySqlQueryEngine.LoadGrid("SELECT * FROM `tbl_position`",dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query_position("new_position");  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            pdesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query_position("edit_position");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            query_position("remove_position");
        }

        private void txt_searchgrid_TextChanged(object sender, EventArgs e)
        {
            Class.SearchEngineClass.SearchGridView(txt_searchgrid.Text,cmb_search_crit.Text,dataGridView1);
        }

    }
}
