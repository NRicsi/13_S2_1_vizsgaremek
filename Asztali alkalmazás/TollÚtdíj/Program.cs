using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollÚtdíj
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Megnézzük, van-e elmentett session token
            string sessionToken = Properties.Settings.Default.SessionToken;

            if (!string.IsNullOrEmpty(sessionToken) &&
                TryGetUserFromSession(sessionToken, out string role, out int cegId))
            {
                // Van ÉRVÉNYES session → azonnal a bejelentkezett felület indul
                Application.Run(new userinterface(role, cegId));
            }
            else
            {
                // NINCS érvényes session (nincs token vagy lejárt) → normál login
                Application.Run(new Login());
            }
        }

        private static bool TryGetUserFromSession(string token, out string role, out int cegId)
        {
            role = null;
            cegId = 0;

            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (var kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                try
                {
                    kapcsolat.Open();
                }
                catch
                {
                    // ha nem elérhető a DB, akkor ne autologin-oljunk
                    return false;
                }

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = @"
                    SELECT f.ceg_id, f.role, f.aktiv
                    FROM felhasznalo_sessionok s
                    JOIN felhasznalok f ON f.id = s.felhasznalo_id
                    WHERE s.token = @token
                      AND s.lejart_at > UTC_TIMESTAMP()";
                parancs.Parameters.AddWithValue("@token", token);

                using (var read = parancs.ExecuteReader())
                {
                    if (!read.Read())
                    {
                        // token lejárt vagy nem létezik
                        return false;
                    }

                    int aktiv = read.GetInt32("aktiv");
                    if (aktiv == 0)
                    {
                        // időközben inaktív lett a felhasználó
                        return false;
                    }

                    role = read.GetString("role");
                    cegId = read.GetInt32("ceg_id");
                    return true;
                }
            }
        }
    }
}
