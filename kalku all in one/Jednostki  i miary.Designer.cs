namespace kalku_all_in_one
{
    partial class Jednostki__i_miary
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.wynikjednostek1 = new System.Windows.Forms.Label();
            this.wynikmiar1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.jednostki = new System.Windows.Forms.Button();
            this.miary = new System.Windows.Forms.Button();
            this.ilosc = new System.Windows.Forms.NumericUpDown();
            this.wynikmiar = new System.Windows.Forms.TextBox();
            this.wynikjednostek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jednostki i Miary";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "gram",
            "dekagramy",
            "funty",
            "kg",
            "tony",
            "mg"});
            this.comboBox1.Location = new System.Drawing.Point(73, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "cm",
            "mm",
            "dm",
            "metry",
            "km",
            "mile"});
            this.comboBox3.Location = new System.Drawing.Point(486, 154);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "cm",
            "mm",
            "dm",
            "metry",
            "km",
            "mile"});
            this.comboBox4.Location = new System.Drawing.Point(486, 231);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "gram",
            "dekagramy",
            "funty",
            "kg",
            "tony",
            "mg"});
            this.comboBox2.Location = new System.Drawing.Point(73, 231);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // wynikjednostek1
            // 
            this.wynikjednostek1.AutoSize = true;
            this.wynikjednostek1.Location = new System.Drawing.Point(12, 358);
            this.wynikjednostek1.Name = "wynikjednostek1";
            this.wynikjednostek1.Size = new System.Drawing.Size(83, 13);
            this.wynikjednostek1.TabIndex = 7;
            this.wynikjednostek1.Text = "wynik jednostek";
            this.wynikjednostek1.Click += new System.EventHandler(this.wynikjednostek_Click);
            // 
            // wynikmiar1
            // 
            this.wynikmiar1.AutoSize = true;
            this.wynikmiar1.Location = new System.Drawing.Point(368, 358);
            this.wynikmiar1.Name = "wynikmiar1";
            this.wynikmiar1.Size = new System.Drawing.Size(56, 13);
            this.wynikmiar1.TabIndex = 17;
            this.wynikmiar1.Text = "wynik miar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "wprowadz ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "jednoski  wybierz z jakiej";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "do jakiej";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "do jakiej";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "miary wybierz z jakiej";
            // 
            // jednostki
            // 
            this.jednostki.Location = new System.Drawing.Point(76, 298);
            this.jednostki.Name = "jednostki";
            this.jednostki.Size = new System.Drawing.Size(75, 23);
            this.jednostki.TabIndex = 14;
            this.jednostki.Text = "Oblicz";
            this.jednostki.UseVisualStyleBackColor = true;
            this.jednostki.Click += new System.EventHandler(this.jednostki_Click);
            // 
            // miary
            // 
            this.miary.Location = new System.Drawing.Point(486, 298);
            this.miary.Name = "miary";
            this.miary.Size = new System.Drawing.Size(75, 23);
            this.miary.TabIndex = 15;
            this.miary.Text = "Oblicz";
            this.miary.UseVisualStyleBackColor = true;
            this.miary.Click += new System.EventHandler(this.miary_Click);
            // 
            // ilosc
            // 
            this.ilosc.Location = new System.Drawing.Point(276, 154);
            this.ilosc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(120, 20);
            this.ilosc.TabIndex = 16;
            // 
            // wynikmiar
            // 
            this.wynikmiar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wynikmiar.Location = new System.Drawing.Point(430, 355);
            this.wynikmiar.Name = "wynikmiar";
            this.wynikmiar.ReadOnly = true;
            this.wynikmiar.Size = new System.Drawing.Size(219, 20);
            this.wynikmiar.TabIndex = 30;
            // 
            // wynikjednostek
            // 
            this.wynikjednostek.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wynikjednostek.Location = new System.Drawing.Point(101, 355);
            this.wynikjednostek.Name = "wynikjednostek";
            this.wynikjednostek.ReadOnly = true;
            this.wynikjednostek.Size = new System.Drawing.Size(187, 20);
            this.wynikjednostek.TabIndex = 31;
            // 
            // Jednostki__i_miary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wynikjednostek);
            this.Controls.Add(this.wynikmiar);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.miary);
            this.Controls.Add(this.jednostki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wynikmiar1);
            this.Controls.Add(this.wynikjednostek1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Jednostki__i_miary";
            this.Size = new System.Drawing.Size(722, 479);
            this.Load += new System.EventHandler(this.Jednostki__i_miary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label wynikjednostek1;
        private System.Windows.Forms.Label wynikmiar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button jednostki;
        private System.Windows.Forms.Button miary;
        private System.Windows.Forms.NumericUpDown ilosc;
        private System.Windows.Forms.TextBox wynikmiar;
        private System.Windows.Forms.TextBox wynikjednostek;
    }
}
