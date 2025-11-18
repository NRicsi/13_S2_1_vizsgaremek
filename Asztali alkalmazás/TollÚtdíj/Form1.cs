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
            pbloading.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        
        private async void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (txbusername.Text != "" && txbpass.Text == "")
            {
                txbpass.Focus();
                return;
            }

            if (txbusername.Text == "" && txbpass.Text != "")
            {
                txbusername.Focus();
                return;
            }
            lblhibas.Visible = false;
            pictureBox1.Visible = false;
            lbluser.Visible = false;
            lblpass.Visible = false;
            lblhibas.Visible = false;
            txbpass.Visible = false;
            txbusername.Visible = false;
            lbl1.Visible = false;
            btnlogin.Visible = false;
            pbloading.Visible = true;
            await Task.Delay(3000);

            #region Backend
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };
            
            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {


                
                try
                {
                    kapcsolat.Open();
                }
                catch (Exception)
                {

                    lblhibas.Text = "Adatbetöltési hiba.\r\nEllenőrizze az internetkapcsolatot, majd próbálja újra.";
                    pbloading.Visible = false;
                    pictureBox1.Visible = true;
                    lbluser.Visible = true;
                    lblpass.Visible = true;
                    lblhibas.Visible = true;
                    txbpass.Visible = true;
                    txbusername.Visible = true;
                    lbl1.Visible = true;
                    btnlogin.Visible = true;
                    txbpass.Text = "";
                    txbpass.Focus();
                    return;
                }
                

                string felhasznalonev = txbusername.Text;
                string jelszo = txbpass.Text;

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = "SELECT jelszo_hash, aktiv FROM felhasznalok WHERE email = @email";
                parancs.Parameters.AddWithValue("@email", felhasznalonev);

                var read = parancs.ExecuteReader();

                if (!read.HasRows)
                {
                    
                    pbloading.Visible = false;
                    pictureBox1.Visible = true;
                    lbluser.Visible = true;
                    lblpass.Visible = true;
                    lblhibas.Visible = true;
                    txbpass.Visible = true;
                    txbusername.Visible = true;
                    lbl1.Visible = true;
                    btnlogin.Visible = true;
                    txbpass.Text = "";
                    txbpass.Focus();
                    return;
                }

                read.Read();
                string JelszoHash = read.GetString(0);
                bool validjelszo = BCrypt.Net.BCrypt.Verify(jelszo, JelszoHash);
                read.Read();
                
                int aktiv = read.GetInt32(1);

                
                if (aktiv == 0)
                {
                    lblhibas.Text = "A fiók nincs aktiválva.\r\nForduljon az adminisztrátorhoz.";
                    lblhibas.Visible = true;

                    pbloading.Visible = false;
                    pictureBox1.Visible = true;
                    lbluser.Visible = true;
                    lblpass.Visible = true;
                    txbpass.Visible = true;
                    txbusername.Visible = true;
                    lbl1.Visible = true;
                    btnlogin.Visible = true;

                    txbpass.Text = "";
                    txbpass.Focus();
                    return;
                }

                if (validjelszo)
                {
                    userinterface ui = new userinterface();
                    ui.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblhibas.Text = "Kérjük, ellenőrizze a jelszavát\r\nés az E-mail címét, majd próbálja újra.";
                    lblhibas.Visible = true;
                    pbloading.Visible = false;
                    pictureBox1.Visible = true;
                    lbluser.Visible = true;
                    lblpass.Visible = true;
                    lblhibas.Visible = true;
                    txbpass.Visible = true;
                    txbusername.Visible = true;
                    lbl1.Visible = true;
                    btnlogin.Visible = true;
                    txbpass.Text = "";
                    txbpass.Focus();
                }
            }
        }
        #endregion






    }
}
