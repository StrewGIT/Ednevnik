namespace SAednevnik
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TstripDatoteke = new System.Windows.Forms.ToolStripDropDownButton();
            this.ItemOsoba = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemOdeljenje = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSkGodina = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPredmet = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSmer = new System.Windows.Forms.ToolStripMenuItem();
            this.TstripDokumenti = new System.Windows.Forms.ToolStripDropDownButton();
            this.ItemUpisnica = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRaspodela = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemOcena = new System.Windows.Forms.ToolStripMenuItem();
            this.TstripIzvestaji = new System.Windows.Forms.ToolStripDropDownButton();
            this.ItemPoOdeljenju = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPoNastavniku = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPoUceniku = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TstripAdministracija = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstripDatoteke,
            this.TstripDokumenti,
            this.TstripIzvestaji,
            this.TstripAdministracija});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TstripDatoteke
            // 
            this.TstripDatoteke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TstripDatoteke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemOsoba,
            this.ItemOdeljenje,
            this.ItemSkGodina,
            this.ItemPredmet,
            this.ItemSmer});
            this.TstripDatoteke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TstripDatoteke.Name = "TstripDatoteke";
            this.TstripDatoteke.Size = new System.Drawing.Size(67, 22);
            this.TstripDatoteke.Text = "Datoteke";
            // 
            // ItemOsoba
            // 
            this.ItemOsoba.Name = "ItemOsoba";
            this.ItemOsoba.Size = new System.Drawing.Size(180, 22);
            this.ItemOsoba.Text = "Osoba";
            this.ItemOsoba.Click += new System.EventHandler(this.ItemOsoba_Click);
            // 
            // ItemOdeljenje
            // 
            this.ItemOdeljenje.Name = "ItemOdeljenje";
            this.ItemOdeljenje.Size = new System.Drawing.Size(180, 22);
            this.ItemOdeljenje.Text = "Odeljenje";
            this.ItemOdeljenje.Click += new System.EventHandler(this.ItemOdeljenje_Click);
            // 
            // ItemSkGodina
            // 
            this.ItemSkGodina.Name = "ItemSkGodina";
            this.ItemSkGodina.Size = new System.Drawing.Size(180, 22);
            this.ItemSkGodina.Text = "Skolska godina";
            this.ItemSkGodina.Click += new System.EventHandler(this.ItemSkGodina_Click);
            // 
            // ItemPredmet
            // 
            this.ItemPredmet.Name = "ItemPredmet";
            this.ItemPredmet.Size = new System.Drawing.Size(180, 22);
            this.ItemPredmet.Text = "Predmet";
            this.ItemPredmet.Click += new System.EventHandler(this.ItemPredmet_Click);
            // 
            // ItemSmer
            // 
            this.ItemSmer.Name = "ItemSmer";
            this.ItemSmer.Size = new System.Drawing.Size(180, 22);
            this.ItemSmer.Text = "Smer";
            this.ItemSmer.Click += new System.EventHandler(this.ItemSmer_Click);
            // 
            // TstripDokumenti
            // 
            this.TstripDokumenti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TstripDokumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemUpisnica,
            this.ItemRaspodela,
            this.ItemOcena});
            this.TstripDokumenti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TstripDokumenti.Name = "TstripDokumenti";
            this.TstripDokumenti.Size = new System.Drawing.Size(79, 22);
            this.TstripDokumenti.Text = "Dokumenti";
            // 
            // ItemUpisnica
            // 
            this.ItemUpisnica.Name = "ItemUpisnica";
            this.ItemUpisnica.Size = new System.Drawing.Size(180, 22);
            this.ItemUpisnica.Text = "Upisnica";
            // 
            // ItemRaspodela
            // 
            this.ItemRaspodela.Name = "ItemRaspodela";
            this.ItemRaspodela.Size = new System.Drawing.Size(180, 22);
            this.ItemRaspodela.Text = "Raspodela";
            // 
            // ItemOcena
            // 
            this.ItemOcena.Name = "ItemOcena";
            this.ItemOcena.Size = new System.Drawing.Size(180, 22);
            this.ItemOcena.Text = "Ocena";
            // 
            // TstripIzvestaji
            // 
            this.TstripIzvestaji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TstripIzvestaji.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemPoOdeljenju,
            this.ItemPoNastavniku,
            this.ItemPoUceniku,
            this.toolStripMenuItem4});
            this.TstripIzvestaji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TstripIzvestaji.Name = "TstripIzvestaji";
            this.TstripIzvestaji.Size = new System.Drawing.Size(61, 22);
            this.TstripIzvestaji.Text = "Izvestaji";
            // 
            // ItemPoOdeljenju
            // 
            this.ItemPoOdeljenju.Name = "ItemPoOdeljenju";
            this.ItemPoOdeljenju.Size = new System.Drawing.Size(180, 22);
            this.ItemPoOdeljenju.Text = "Po odeljenju";
            // 
            // ItemPoNastavniku
            // 
            this.ItemPoNastavniku.Name = "ItemPoNastavniku";
            this.ItemPoNastavniku.Size = new System.Drawing.Size(180, 22);
            this.ItemPoNastavniku.Text = "Po nastavniku";
            // 
            // ItemPoUceniku
            // 
            this.ItemPoUceniku.Name = "ItemPoUceniku";
            this.ItemPoUceniku.Size = new System.Drawing.Size(180, 22);
            this.ItemPoUceniku.Text = "Po uceniku";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Predmet";
            // 
            // TstripAdministracija
            // 
            this.TstripAdministracija.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TstripAdministracija.Image = ((System.Drawing.Image)(resources.GetObject("TstripAdministracija.Image")));
            this.TstripAdministracija.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TstripAdministracija.Name = "TstripAdministracija";
            this.TstripAdministracija.Size = new System.Drawing.Size(87, 22);
            this.TstripAdministracija.Text = "Administracija";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 390);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton TstripDatoteke;
        private System.Windows.Forms.ToolStripMenuItem ItemOsoba;
        private System.Windows.Forms.ToolStripMenuItem ItemOdeljenje;
        private System.Windows.Forms.ToolStripMenuItem ItemSkGodina;
        private System.Windows.Forms.ToolStripMenuItem ItemPredmet;
        private System.Windows.Forms.ToolStripDropDownButton TstripDokumenti;
        private System.Windows.Forms.ToolStripMenuItem ItemUpisnica;
        private System.Windows.Forms.ToolStripMenuItem ItemRaspodela;
        private System.Windows.Forms.ToolStripMenuItem ItemOcena;
        private System.Windows.Forms.ToolStripMenuItem ItemSmer;
        private System.Windows.Forms.ToolStripDropDownButton TstripIzvestaji;
        private System.Windows.Forms.ToolStripMenuItem ItemPoOdeljenju;
        private System.Windows.Forms.ToolStripMenuItem ItemPoNastavniku;
        private System.Windows.Forms.ToolStripMenuItem ItemPoUceniku;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripButton TstripAdministracija;
    }
}