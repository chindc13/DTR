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
    class SearchEngineClass
    {
       
        //DATAGRID SEARCH
        public static void SearchGridView(String textBoxSearch, String cmb_search_crit, DataGridView gridView)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd;

            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                switch (cmb_search_crit)
                {

                    //DEPARTMENT SEARCH GRID ENGINE 

                    case "Department Code":
                        cmd.CommandText = "Select * from `tbl_department2` Where department_id LIKE @searchKey";
                        break;

                    case "Department Name":
                        cmd.CommandText = "Select * from `tbl_department2` Where department_name LIKE @searchKey";
                        break;

                    case "Department Description":
                        cmd.CommandText = "Select * from `tbl_department2` Where department_desc LIKE @searchKey";
                        break;

                    case "Deleted":
                        cmd.CommandText = "Select * from `tbl_department2` Where is_deleted LIKE @searchKey";
                        break;

                    //DEPARTMENT SEARCH GRID ENGINE 

                    //POSITION SEARCH GRID ENGINE 

                    case "Position Code":
                        cmd.CommandText = "Select * from `tbl_position` Where position_id LIKE @searchKey";
                        break;

                    case "Position Name":
                        cmd.CommandText = "Select * from `tbl_position` Where position_name LIKE @searchKey";
                        break;

                    case "Position Description":
                        cmd.CommandText = "Select * from `tbl_position` Where position_desc LIKE @searchKey";
                        break;

                    case "Department":
                        cmd.CommandText = "Select tbl_position.*,tbl_department2.department_name from `tbl_position`,tbl_department2 Where tbl_department2.department_id =  tbl_position.department_id and tbl_position.position_desc LIKE @searchKey";
                        break;

                    case "Position Deleted":
                        cmd.CommandText = "Select * from `tbl_position` Where is_deleted LIKE @searchKey";
                        break;

                    //POSITION SEARCH GRID ENGINE 

                    //EMPLOYEE
                    case "Employee Code":
                        cmd.CommandText = "Select * from `tbl_accounts` Where account_id LIKE @searchKey";
                        break;

                    case "Name":
                        cmd.CommandText = "Select * from `tbl_accounts` Where name LIKE @searchKey";
                        break;

                    case "Gender":
                        cmd.CommandText = "Select * from `tbl_accounts` Where gender LIKE @searchKey";
                        break;

                    case "Cellphone":
                        cmd.CommandText = "Select * from `tbl_accounts` Where phone LIKE @searchKey";
                        break;

                    case "Position":
                        cmd.CommandText = "Select * from `tbl_accounts` Where position LIKE @searchKey";
                        break;

                    case "User":
                        cmd.CommandText = "Select * from `tbl_accounts` Where auser LIKE @searchKey";
                        break;

                     //EMPLOYEE

                    //Student
                    case "student_name":
                        cmd.CommandText = "Select * from `tbl_student` Where student_name LIKE @searchKey";
                        break;

                    case "section":
                        cmd.CommandText = "Select * from `tbl_student` Where section LIKE @searchKey";
                        break;

                    case "course":
                        cmd.CommandText = "Select * from `tbl_student` Where course LIKE @searchKey";
                        break;

                    case "year":
                        cmd.CommandText = "Select * from `tbl_student` Where year LIKE @searchKey";
                        break;
                    //Student

                    //tools
                    case "employee":
                        cmd.CommandText = "Select * from `tbl_accounts` Where authority = 1 and name LIKE @searchKey";
                        break;

                    case "access":
                        cmd.CommandText = "Select tbl_accounts.account_id,tbl_accounts,tbl_accounts.name,tbl_accesslevel.* from `tbl_accesslevel`,`tbl_accounts` WHERE authority = 1 and tbl_accounts.account_id=tbl_accesslevel.account_id and name LIKE @searchKey";
                        break;
                    //tools

                }
                cmd.Parameters.AddWithValue("@searchKey", "%" + textBoxSearch + "%");
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                gridView.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error MySql");
            }
            finally
            {
                connection.Close();
            }

        }


        //SEARCH ONE FOR TEXTBOX ONLY 
        public static void searchComboBox(String Query, String Status, String data, TextBox txtBox)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd;
            MySqlDataReader dr;
            try
            {
                connection.Open();
                cmd = new MySqlCommand(Query, connection);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtBox.Text = dr.GetString(data);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            finally
            {
                connection.Close();
            }
        }
        //SEARCH ONE FOR TEXTBOX ONLY END

        //SEARCH ONE FOR STRING ONLY
        public static string getDataFromString = "";
        public static void searchString(String Query, String data)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                connection.Open();
                cmd = new MySqlCommand(Query, connection);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    getDataFromString = dr.GetString(data);
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
        //SEARCH ONE FOR STRING ONLY END


        //SEARCH ONE FOR IMAGE ONLY 
        public static void searchImage(String Query, PictureBox pic, int numberColumn, int numberRow)
        {
            MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                da.Fill(dt);

                byte[] byteImage = (byte[])dt.Rows[numberColumn][numberRow];
                MemoryStream ms = new MemoryStream(byteImage);
                pic.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                connection.Close();
                da.Dispose();
            }
        }
        //SEARCH ONE FOR IMAGE ONLY END
    }
}
