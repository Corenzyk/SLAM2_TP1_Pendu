using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace SLAM2_TP1_Pendu.Model
{
    public class Connexion
    {
        private MySqlConnection connection;
        public MySqlConnection Connection
        {get { return connection; }}
        private string server;
        private string database;
        private string uid;
        private string password;

        #region Initialisation connexion
        private void Initialise()
        {
            server = "192.168.10.16";
            database = "kuczyk_corentin_BDD_pendu";
            uid = "TP_PENDU";
            password = "mdp_UTILISATEUR_TP";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        #endregion

        #region Connexion
        public Connexion() 
        {
            Initialise();
        }
        #endregion
    }
}
