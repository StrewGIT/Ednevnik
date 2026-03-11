using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAednevnik
{
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        string ime_tabele;
        public Sifarnik(string ime_tabele)
        {
            InitializeComponent();
            this.ime_tabele = ime_tabele;
        }
        private void UpdateKaAplikaciji()
        {
            adapter = new SqlDataAdapter("SELECT * FROM " + ime_tabele, Connection.connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            DGridView.DataSource = tabela;
        }
        private void UpdateKaBazi()
        {
            DataTable delta = tabela.GetChanges();
            if (delta == null) return;
            try
            {
                adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
                adapter.Update(delta);
            }
            catch (Exception ex) { MessageBox.Show("Nije moguce obrisati red");UpdateKaAplikaciji();}
            return;
        }
        private void Sifarnik_Load(object sender, EventArgs e)
        {
            UpdateKaAplikaciji();
            DGridView.Columns["id"].ReadOnly = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdateKaBazi();
        }
    }
}
