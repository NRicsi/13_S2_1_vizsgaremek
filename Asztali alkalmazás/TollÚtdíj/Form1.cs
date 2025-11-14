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
using BCrypt.Net;

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
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();

                string username = txbusername.Text;
                string password = txbpass.Text;

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = "SELECT jelszo_hash FROM felhasznalok WHERE email = @email";
                parancs.Parameters.AddWithValue("@email", username);

                var read = parancs.ExecuteReader();

                if (!read.HasRows)
                {
                    
                    MessageBox.Show("Hibás E-mail cím vagy jelszó!");
                    return;
                }

                read.Read();
                string JelszoHash = read.GetString(0);
                bool validjelszo = BCrypt.Net.BCrypt.Verify(password, JelszoHash);

                if (validjelszo)
                {
                    userinterface ui = new userinterface();
                    ui.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hibás E-mail cím vagy jelszó!");
                }
            }
        }

       
            /*
            if (txbusername.Text != "" && txbpass.Text == "")
            {
                txbpass.Focus();
                return;
            }
            
            }
            else MessageBox.Show("nem ok");
            */
        
        private void txbusername_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
