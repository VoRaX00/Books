using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace books
{
    internal class DBConnection
    {
        static string DBConnect = "server = localhost; user=root; password=1324; database=books_db";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myConnect;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                myConnect = new MySqlConnection(DBConnect);
                myConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void CloseDB()
        {
            myConnect.Close();
        }

        public static MySqlConnection GetConnection()
        {
            return myConnect;
        }
    }
}
