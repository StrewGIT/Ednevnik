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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAednevnik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Connection.connect();
            SqlCommand naredba = new SqlCommand("SELECT pass FROM Osoba WHERE email = '" + TboxEmail.Text + "'", veza);
            SqlDataAdapter adapt = new SqlDataAdapter(naredba);
            DataTable tabela = new DataTable();
            adapt.Fill(tabela);
            if (tabela.Rows.Count != 0)
            {
                if (tabela.Rows[0]["pass"].ToString() == TboxPass.Text)
                {
                    Main glavna = new Main();
                    this.Hide();
                    glavna.Show();
                }
                else
                {
                    MessageBox.Show("Uneta je neispravna lozinka");
                }
            }
            else
            {
                MessageBox.Show("Unet je nepostojaci mejl");
            }
        }
    }
}
