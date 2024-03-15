using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace SLAM2_TP1_Pendu.Model
{
    internal class Connexion
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private void Initialise()
        {
            server = "localhost";
            database = "bdd_pendu";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public Connexion() 
        {
            this.Initialise();
        }
    }
}
