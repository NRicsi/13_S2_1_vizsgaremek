using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollÚtdíj
{
    public partial class userinterface : Form
    {
        public userinterface(string role, int cegId)
        {
            InitializeComponent();


            

            if (role == "operator")
            {
                this.Text = "TollÚtdíj - Operátor";
                btncegkezeles.Enabled = false;
                btnjarmutorles.Enabled = false;
                btnuthozzaadas.Enabled = false;
            }
            else if (role == "ceg_admin")
            {
                this.Text = "TollÚtdíj - Adminisztrátor";
            }
            else if (role == "rendszer_admin")
            {
                this.Text = "TollÚtdíj - Rendszer adminisztrátor";
            }
        }


        private void userinterface_Load(object sender, EventArgs e)
        {

        }
        private void btnlogout_Click_1(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.SessionToken = "";
            Properties.Settings.Default.Save();
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();

            
        }
    }
}
