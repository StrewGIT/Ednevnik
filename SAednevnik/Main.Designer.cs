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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TstripDatoteke = new System.Windows.Forms.ToolStripDropDownButton();
            this.ItemOsoba = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemOdeljenje = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSkGodina = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPredmet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstripDatoteke});
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
            this.ItemPredmet});
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
            // 
            // ItemSkGodina
            // 
            this.ItemSkGodina.Name = "ItemSkGodina";
            this.ItemSkGodina.Size = new System.Drawing.Size(180, 22);
            this.ItemSkGodina.Text = "Skolska godina";
            // 
            // ItemPredmet
            // 
            this.ItemPredmet.Name = "ItemPredmet";
            this.ItemPredmet.Size = new System.Drawing.Size(180, 22);
            this.ItemPredmet.Text = "Predmet";
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
    }
}