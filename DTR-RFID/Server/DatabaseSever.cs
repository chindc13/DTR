using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTR_RFID.Server
{
    class DatabaseSever
    {
        public static string path = "localhost";
        public static string port = "3306";
        public static string databasename = "dailytimerecord";
        public static string username = "root";
        public static string password = "";

        public static string mysql_server_connection = "datasource=" + path.ToString() + ";port=" + port.ToString() + ";Initial Catalog='" + databasename.ToString() + "';username=" + username.ToString() + ";password=" + password.ToString() + "";

        public static string mysql_server_report_connection = @"Server="+path+";Database="+databasename+";Uid="+username+";Password="+password+";charset=utf8";
    }
}
