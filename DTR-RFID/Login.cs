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

namespace DTR_RFID
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection(Server.DatabaseSever.mysql_server_connection.ToString());
        MySqlCommand cmd;
        MySqlDataReader dr;

        int attempts = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Server.ServerForm sf = new Server.ServerForm();
            sf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit this application ?", "Message : ", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_user(String userid, String password)
        {
            if (attempts < 6)
            {
                if (String.IsNullOrEmpty(auser.Text) || String.IsNullOrEmpty(apass.Text))
                {
                    MessageBox.Show("Please enter username and password on the fields. your number of attempts is " + attempts + "/5", "Message : Exit");
                    attempts++;
                }
                else
                {
                    try
                    {
                        cmd = new MySqlCommand();
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT * FROM tbl_accounts WHERE auser = '" + userid + "' AND apass = '" + password + "' AND is_active = 1 AND is_deleted = 0";
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Class.UserClass.user_id = dr[0].ToString(); 
                            Class.UserClass.account_name = dr[1].ToString();

                            //open mainmenu
                            MessageBox.Show("Login success, Welcome " + dr[1].ToString(), "Message: Login");
                            Forms.MainMenu fmm = new Forms.MainMenu();
                            fmm.Show();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login please check Userid and password");
                            attempts++;
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
            }
            else
            {
                MessageBox.Show("Your number of attempts existed please try again later. your number of attemtps is " + attempts + "/5", "Message : Exit");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_user(auser.Text, Class.Base64Encryption.EncodeTo64(apass.Text));
        }

        private void auser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login_user(auser.Text, Class.Base64Encryption.EncodeTo64(apass.Text));
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
                Form f = new Form1();
                f.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            Form f = new Form1();
            f.Show();
        }
    }
}
