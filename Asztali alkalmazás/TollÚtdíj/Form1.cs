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
        private Bejelentkezessegito UIkisegito;

        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txbusername;
            pbloading.Visible = false;
            UIkisegito = new Bejelentkezessegito(
                lblhibas,
                pbloading,
                pictureBox1,
                lbluser,
                lblpass,
                txbpass,
                txbusername,
                lbl1,
                btnlogin
                );
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        public class Bejelentkezessegito
        {
            private Label lblHibas;
            private PictureBox pbLoading;
            private PictureBox pictureBox1;
            private Label lblUser;
            private Label lblPass;
            private TextBox txbPass;
            private TextBox txbUsername;
            private Label lbl1;
            private Button btnLogin;

            public Bejelentkezessegito(
                Label lblHibas,
                PictureBox pbLoading,
                PictureBox pictureBox1,
                Label lblUser,
                Label lblPass,
                TextBox txbPass,
                TextBox txbUsername,
                Label lbl1,
                Button btnLogin)
            {
                this.lblHibas = lblHibas;
                this.pbLoading = pbLoading;
                this.pictureBox1 = pictureBox1;
                this.lblUser = lblUser;
                this.lblPass = lblPass;
                this.txbPass = txbPass;
                this.txbUsername = txbUsername;
                this.lbl1 = lbl1;
                this.btnLogin = btnLogin;
            }

            public void ShowErrorState()
            {
                lblHibas.Visible = true;
                pbLoading.Visible = false;
                pictureBox1.Visible = true;
                lblUser.Visible = true;
                lblPass.Visible = true;
                txbPass.Visible = true;
                txbUsername.Visible = true;
                lbl1.Visible = true;
                btnLogin.Visible = true;

                txbPass.Text = "";
                txbPass.Focus();
            }
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
                    UIkisegito.ShowErrorState();
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

                    UIkisegito.ShowErrorState();
                    return;
                }

                read.Read();
                string JelszoHash = read.GetString(0);
                bool validjelszo = BCrypt.Net.BCrypt.Verify(jelszo, JelszoHash);                            
                int aktiv = read.GetInt32(1);
           

                if (validjelszo == true)
                {
                    if (aktiv == 0)
                    {
                        lblhibas.Text = "A fiók nincs aktiválva.\r\nForduljon az adminisztrátorhoz.";
                        UIkisegito.ShowErrorState();
                        return;
                    }
                    userinterface ui = new userinterface();
                    ui.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblhibas.Text = "Kérjük, ellenőrizze a jelszavát\r\nés az E-mail címét, majd próbálja újra.";
                    UIkisegito.ShowErrorState();
                    return;
                }
                
            }
        }
        #endregion






    }
}
