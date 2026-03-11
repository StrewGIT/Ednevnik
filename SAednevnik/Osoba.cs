using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAednevnik
{
    public partial class Osoba : Form
    {
        private DataTable tabela;
        private int counter;
        public Osoba()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            SqlConnection veza = Connection.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            Prikazi();
        }
        private void Osoba_Load(object sender, EventArgs e)
        {
            counter = 0;
            Refresh();
        }
        private void Prikazi()
        {
            if (counter < tabela.Rows.Count && counter >= 0) 
            {
                try
                {
                    TboxID.Text = tabela.Rows[counter]["id"].ToString();
                    TboxIme.Text = tabela.Rows[counter]["ime"].ToString();
                    TboxPrezime.Text = tabela.Rows[counter]["prezime"].ToString();
                    TboxAdresa.Text = tabela.Rows[counter]["adresa"].ToString();
                    TboxJmbg.Text = tabela.Rows[counter]["jmbg"].ToString();
                    TboxEmail.Text = tabela.Rows[counter]["email"].ToString();
                    TboxLozinka.Text = tabela.Rows[counter]["pass"].ToString();
                    TboxUloga.Text = tabela.Rows[counter]["uloga"].ToString();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void Osoba_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            counter = 0;
            Prikazi();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if(counter>0) counter--;
            Prikazi();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(counter<tabela.Rows.Count-1)counter++;
            Prikazi();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            counter=tabela.Rows.Count - 1;
            Prikazi();
        }

        private void BtnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection veza = Connection.connect();
                SqlCommand komanda = new SqlCommand("DELETE FROM Osoba WHERE id = "+TboxID.Text,veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                Refresh();
                BtnPrevious_Click(sender, e);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            string com = "INSERT INTO Osoba VALUES('";
            com += TboxIme.Text + "','";
            com += TboxPrezime.Text + "','";
            com += TboxAdresa.Text + "','";
            com += TboxJmbg.Text + "','";
            com += TboxEmail.Text + "','";
            com += TboxLozinka.Text + "',";
            com += TboxUloga.Text + ")";
            try
            {
                SqlConnection veza = Connection.connect();
                SqlCommand komanda = new SqlCommand(com, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                Refresh();
                BtnNext_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnMenjaj_Click(object sender, EventArgs e)
        {
            string com = "UPDATE OSOBA SET ime ='";
            com += TboxIme.Text + "',prezime ='";
            com += TboxPrezime.Text + "',adresa='";
            com += TboxAdresa.Text + "',jmbg='";
            com += TboxJmbg.Text + "',email='";
            com += TboxEmail.Text + "',pass='";
            com += TboxLozinka.Text + "',uloga=";
            com += TboxUloga.Text + "WHERE ID=";
            com += TboxID.Text;
            try
            {
                SqlConnection veza = Connection.connect();
                SqlCommand komanda = new SqlCommand(com, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
