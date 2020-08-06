using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTR_RFID.Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();

        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            path.Text = DatabaseSever.path.ToString();
            port.Text = DatabaseSever.port.ToString();
            dbname.Text = DatabaseSever.databasename.ToString();
            user.Text = DatabaseSever.username.ToString();
            pass.Text = DatabaseSever.password.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseSever.path = path.Text;
            DatabaseSever.port = port.Text;
            DatabaseSever.databasename = dbname.Text;
            DatabaseSever.username = user.Text;
            DatabaseSever.password = pass.Text;
            MessageBox.Show("Server change successfuly", "Message:");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
