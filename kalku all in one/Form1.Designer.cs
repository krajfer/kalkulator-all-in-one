namespace kalku_all_in_one
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konwenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednostkiIMiaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kalkulator1 = new kalku_all_in_one.Kalkulator();
            this.konwenter1 = new kalku_all_in_one.konwenter();
            this.jednostki__i_miary1 = new kalku_all_in_one.Jednostki__i_miary();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalkulatorToolStripMenuItem,
            this.konwenterToolStripMenuItem,
            this.jednostkiIMiaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kalkulatorToolStripMenuItem.Text = "Kalkulator";
            this.kalkulatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorToolStripMenuItem_Click_1);
            // 
            // konwenterToolStripMenuItem
            // 
            this.konwenterToolStripMenuItem.Name = "konwenterToolStripMenuItem";
            this.konwenterToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.konwenterToolStripMenuItem.Text = "Konwenter";
            this.konwenterToolStripMenuItem.Click += new System.EventHandler(this.konwenterToolStripMenuItem_Click_1);
            // 
            // jednostkiIMiaryToolStripMenuItem
            // 
            this.jednostkiIMiaryToolStripMenuItem.Name = "jednostkiIMiaryToolStripMenuItem";
            this.jednostkiIMiaryToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.jednostkiIMiaryToolStripMenuItem.Text = "Jednostki i Miary";
            this.jednostkiIMiaryToolStripMenuItem.Click += new System.EventHandler(this.jednostkiIMiaryToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kalkulator1);
            this.panel1.Controls.Add(this.konwenter1);
            this.panel1.Controls.Add(this.jednostki__i_miary1);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 479);
            this.panel1.TabIndex = 1;
            // 
            // kalkulator1
            // 
            this.kalkulator1.Location = new System.Drawing.Point(0, 0);
            this.kalkulator1.Name = "kalkulator1";
            this.kalkulator1.Size = new System.Drawing.Size(722, 479);
            this.kalkulator1.TabIndex = 0;
            // 
            // konwenter1
            // 
            this.konwenter1.Location = new System.Drawing.Point(0, 0);
            this.konwenter1.Name = "konwenter1";
            this.konwenter1.Size = new System.Drawing.Size(775, 447);
            this.konwenter1.TabIndex = 1;
            // 
            // jednostki__i_miary1
            // 
            this.jednostki__i_miary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jednostki__i_miary1.Location = new System.Drawing.Point(0, 0);
            this.jednostki__i_miary1.Name = "jednostki__i_miary1";
            this.jednostki__i_miary1.Size = new System.Drawing.Size(722, 479);
            this.jednostki__i_miary1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(724, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "All in One";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konwenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednostkiIMiaryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Kalkulator kalkulator1;
        private konwenter konwenter1;
        private Jednostki__i_miary jednostki__i_miary1;
    }
}

