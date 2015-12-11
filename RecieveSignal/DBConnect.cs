using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecieveSignal
{
    class DBConnect
    {
        //connection variables//
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect() { initialize();  }//seting up constuctor
        public void initialize()
        {
            server = "localhost:3306";//change ip here********************************************
            database = "signal";
            uid = "root";
            password = "john12345";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }

        private bool OpenConnection() {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            { 
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact Administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void insert(int signal_power, int x, int y, int degrees)
        {
            string query = "INSERT INTO signal_list (signal_power,x,y,degrees) VALUES ("+signal_power+","+x+","+y+","+degrees+")";
            if (this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }

}
