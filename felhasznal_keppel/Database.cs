using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace felhasznal_keppel
{
    internal class Database
    {
        static public MySqlCommand command;
        static public MySqlConnection connection;

        public Database(string server = "localhost", string user = "root", string password = "", string db = "felhasznalokep")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (Kapcsolatok())
            {
                command = connection.CreateCommand();
            }
        }
        private bool Kapcsolatok()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<felhasznalo> getAllfelhasznalo()
        {
            List<felhasznalo> list = new List<felhasznalo>();
            command.CommandText = "SELECT * FROM adatok;";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    felhasznalo Felhasznalo = new felhasznalo(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("szuletesidatum"), dr.GetString("profilkep"));
                    list.Add(Felhasznalo);
                }
            }
            connection.Close();
            return list;
        }
        internal bool insertfelhasznalo(felhasznalo insertFelhasznalo)
        {
            command.CommandText = "INSERT INTO `adatok`(`id`, `nev`, `szuletesidatum`, `profilkep`) VALUES (null, @nev, @szuletesidatum, @profilkep);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", Program.mainform.textBox_nev.Text);
            command.Parameters.AddWithValue("@szuletesidatum", Program.mainform.dateTimePicker1.Text);
            command.Parameters.AddWithValue("@profilkep", Program.mainform.textBox_profilkep.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public bool updatefelhasznalo(felhasznalo updateFelhasznalo)
        {

            command.CommandText = "UPDATE `adatok` SET `nev`= @nev,`szuletesidatum`= @szuletesidatum,`profilkep`= @profilkep WHERE `id`=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.mainform.textBox_id.Text);
            command.Parameters.AddWithValue("@nev", Program.mainform.textBox_nev.Text);
            command.Parameters.AddWithValue("@szuletesidatum", Program.mainform.dateTimePicker1.Text);
            command.Parameters.AddWithValue("@profilkep", Program.mainform.textBox_profilkep.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool deletefelhasznalo(felhasznalo deleteFelhasznalo)
        {

            command.CommandText = "DELETE FROM `adatok` WHERE `id` = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.mainform.textBox_id.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
