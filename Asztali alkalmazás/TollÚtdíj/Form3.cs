using MySqlConnector;
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
    public partial class cegkezeles : Form
    {
        private readonly string role;
        private readonly int cegId;
        public cegkezeles(string role, int cegId)
        {
            
        InitializeComponent();
            lblhibas.Visible = false;
            this.role = role;
            this.cegId = cegId;

            if (role == "operator")
            {
                this.Text = "Cégkezelés - Operátor";
               
            }
            else if (role == "ceg_admin")
            {
                this.Text = "Cégkezelés - Adminisztrátor";
            }
            else if (role == "rendszer_admin")
            {
                this.Text = "Cégkezelés - Rendszer adminisztrátor";
            }
        }


        private void Form3_Load(object sender, EventArgs e)
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
                try
                {
                    kapcsolat.Open();
                }
                catch (Exception)
                {
                    lblhibas.Text = "Adatbetöltési hiba.\r\nEllenőrizze az internetkapcsolatot, majd próbálja újra.";
                    lblhibas.Visible = true;
                    return;
                }

                var parancs = kapcsolat.CreateCommand();
                if (role == "ceg_admin")
                {
                    parancs.CommandText = @"
                SELECT c.nev
                FROM cegek c
                JOIN felhasznalok f ON f.ceg_id = c.id
                WHERE f.ceg_id = @cegId
                  AND f.role = 'ceg_admin'
                LIMIT 1";
                    parancs.Parameters.AddWithValue("@cegId", cegId);
                }
                else if (role == "rendszer_admin")
                {
                    parancs.CommandText = @"
                SELECT nev
                FROM cegek
                WHERE statusz = 'aktiv'";
                }
                else
                {
                    // operator – csak a saját cégét lássa
                    parancs.CommandText = @"
                SELECT nev
                FROM cegek
                WHERE id = @cegId";
                    parancs.Parameters.AddWithValue("@cegId", cegId);
                }

                using (var reader = parancs.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lsbceglista.Items.Add(reader.GetString("nev"));
                    }
                }


            }
        }

        private void btnvissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
