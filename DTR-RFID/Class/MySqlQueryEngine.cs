using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace DTR_RFID.Class
{
    class MySqlQueryEngine
    {
        //INSERT UPDATE DELETE FOR STRING ONLY
        public static void QueryManager(String Query, String Status)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd;
            int a = 0;

            try
            {
                connection.Open();
                cmd = new MySqlCommand();
                cmd.Connection = connection;

                if (Status == "Add")
                {
                    cmd.CommandText = Query;
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("New data successfully added", "Message:");
                    }
                    else {
                        MessageBox.Show("Error on adding, please check your fields. thank you", "Message:");
                    }
                }
                else if (Status == "Edit")
                {
                    cmd.CommandText = Query;
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Edit data successfully", "Message:");
                    }
                    else {
                        MessageBox.Show("Error on editing, please check your fields. thank you", "Message:");
                    }
                }
                else if (Status == "Delete")
                {
                    cmd.CommandText = Query;
                    a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        DialogResult a1 = MessageBox.Show("Are you sure you want to remove this ??", "Removing", MessageBoxButtons.YesNo);
                        switch (a1)
                        {
                            case DialogResult.Yes:
                                MessageBox.Show("Delete successfully.", "Message:");
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error on deleting, please check your fields. thank you", "Message:");
                    }
                }
                else if (Status == "Select")
                {
                    
                }
                else
                {
                    MessageBox.Show("Error", "Message : MySqlQuery Engine Error !!");
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
        //INSERT UPDATE DELETE FOR STRING ONLY END

        //LOAD DATAGRID 
        public static void LoadGrid(String QueryString, DataGridView datagrid)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd;

            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = QueryString;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                datagrid.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        //LOAD DATAGRID END


        //LOAD COMBOBOX DATA
        public static void loadComboBox(String mysqlQuery, ComboBox cmb_box, String valueMember, String displayMember)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd;
            MySqlDataReader reader;

            connection.Open();
            cmd = new MySqlCommand(mysqlQuery, connection);

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add(displayMember, typeof(string));
            dt.Columns.Add(valueMember,typeof(string));
            dt.Load(reader);

            cmb_box.DisplayMember = displayMember;
            cmb_box.ValueMember = valueMember;
            cmb_box.Refresh();
            cmb_box.DataSource = dt;

            connection.Close();
        }
        //LOAD COMBOBOX DATA END 


        //INSERT UPDATE DELETE WITH IMAGE
        public static void queryWithImage(String QueryWithImage, PictureBox Photo, String Status)
        {
            try
            {
                String query = QueryWithImage;

                MemoryStream ms = new MemoryStream();
                Photo.Image.Save(ms, Photo.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();

                //Alaways use @img for uploading image on your query
                if (Status == "Add")
                {
                    cmd.Parameters.Add("@img", MySqlDbType.LongBlob);
                    cmd.Parameters["@img"].Value = img;
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("New data added", "Message");
                    else
                        MessageBox.Show("Error on adding new employee", "Warning Message");
                }
                else if (Status == "Edit")
                {
                    cmd.Parameters.Add("@img", MySqlDbType.LongBlob);
                    cmd.Parameters["@img"].Value = img;
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Edit data successfully", "Message");
                    else
                        MessageBox.Show("Error on data Edit", "Warning Message");
                }
                else if (Status == "Delete")
                {
                    cmd.Parameters.Add("@img", MySqlDbType.LongBlob);
                    cmd.Parameters["@img"].Value = img;
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Delete data successfully", "Message");
                    else
                        MessageBox.Show("Error on data Delete", "Warning Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {

            }
        }
        //INSERT UPDATE DELETE WITH IMAGE END 

    }
}
