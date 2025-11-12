using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollÚtdíj
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txbusername;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder { Server = "localhost", UserID = "root", Password = "uj_jelszo", Database = "tollutdijadatbazis" };
            MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString);
            kapcsolat.Open();
            string username = txbusername.Text;
            var parancs = kapcsolat.CreateCommand();
            parancs.CommandText = $"SELECT jelszo_hash FROM felhasznalok WHERE email = '{username}';";
            var read = parancs.ExecuteReader();
            while (read.Read())
            {
                if (txbpass.Text == read.GetString(0))
                {
                    userinterface userinterface = new userinterface();
                    userinterface.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("nem ok");

            }

            kapcsolat.Close();
            /*
            if (txbusername.Text != "" && txbpass.Text == "")
            {
                txbpass.Focus();
                return;
            }
            
            }
            else MessageBox.Show("nem ok");
            */
        }
        private void txbusername_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
