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

            if (role == "ceg_admin")
            {
                this.Text = "TollÚtdíj - Adminisztrátor";
            }

            if (role == "rendszer_admin")
            {
                this.Text = "Rendszer adminisztrátor";
            }
        }


        private void userinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
