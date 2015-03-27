namespace Klijent
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrijaveStudenata = new System.Windows.Forms.DataGridView();
            this.txtImeIPrezime = new System.Windows.Forms.TextBox();
            this.cmbSviStudenti = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtSifraPrijave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.cmbSviPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbAktivanRok = new System.Windows.Forms.ComboBox();
            this.cmbIzborStudenta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveStudenata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPrijaveStudenata);
            this.groupBox1.Controls.Add(this.txtImeIPrezime);
            this.groupBox1.Controls.Add(this.cmbSviStudenti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbor studenta";
            // 
            // dgvPrijaveStudenata
            // 
            this.dgvPrijaveStudenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijaveStudenata.Location = new System.Drawing.Point(6, 94);
            this.dgvPrijaveStudenata.Name = "dgvPrijaveStudenata";
            this.dgvPrijaveStudenata.Size = new System.Drawing.Size(387, 144);
            this.dgvPrijaveStudenata.TabIndex = 5;
            // 
            // txtImeIPrezime
            // 
            this.txtImeIPrezime.Location = new System.Drawing.Point(184, 46);
            this.txtImeIPrezime.Name = "txtImeIPrezime";
            this.txtImeIPrezime.Size = new System.Drawing.Size(143, 20);
            this.txtImeIPrezime.TabIndex = 4;
            // 
            // cmbSviStudenti
            // 
            this.cmbSviStudenti.FormattingEnabled = true;
            this.cmbSviStudenti.Location = new System.Drawing.Point(184, 19);
            this.cmbSviStudenti.Name = "cmbSviStudenti";
            this.cmbSviStudenti.Size = new System.Drawing.Size(143, 21);
            this.cmbSviStudenti.TabIndex = 3;
            this.cmbSviStudenti.SelectedIndexChanged += new System.EventHandler(this.cmbSviStudenti_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijave Studenata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime i Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi Studenti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSacuvaj);
            this.groupBox2.Controls.Add(this.txtSifraPrijave);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDatum);
            this.groupBox2.Controls.Add(this.txtOcena);
            this.groupBox2.Controls.Add(this.cmbSviPredmeti);
            this.groupBox2.Controls.Add(this.cmbAktivanRok);
            this.groupBox2.Controls.Add(this.cmbIzborStudenta);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(47, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unos prijave";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(289, 166);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(104, 35);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtSifraPrijave
            // 
            this.txtSifraPrijave.Location = new System.Drawing.Point(149, 188);
            this.txtSifraPrijave.Name = "txtSifraPrijave";
            this.txtSifraPrijave.Size = new System.Drawing.Size(121, 20);
            this.txtSifraPrijave.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "SifraPrijave";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(149, 155);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(121, 20);
            this.txtDatum.TabIndex = 9;
            this.txtDatum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDatum_MouseClick);
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(149, 118);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(121, 20);
            this.txtOcena.TabIndex = 8;
            // 
            // cmbSviPredmeti
            // 
            this.cmbSviPredmeti.FormattingEnabled = true;
            this.cmbSviPredmeti.Location = new System.Drawing.Point(149, 85);
            this.cmbSviPredmeti.Name = "cmbSviPredmeti";
            this.cmbSviPredmeti.Size = new System.Drawing.Size(168, 21);
            this.cmbSviPredmeti.TabIndex = 7;
            // 
            // cmbAktivanRok
            // 
            this.cmbAktivanRok.FormattingEnabled = true;
            this.cmbAktivanRok.Location = new System.Drawing.Point(149, 54);
            this.cmbAktivanRok.Name = "cmbAktivanRok";
            this.cmbAktivanRok.Size = new System.Drawing.Size(168, 21);
            this.cmbAktivanRok.TabIndex = 6;
            // 
            // cmbIzborStudenta
            // 
            this.cmbIzborStudenta.FormattingEnabled = true;
            this.cmbIzborStudenta.Location = new System.Drawing.Point(149, 22);
            this.cmbIzborStudenta.Name = "cmbIzborStudenta";
            this.cmbIzborStudenta.Size = new System.Drawing.Size(168, 21);
            this.cmbIzborStudenta.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ocena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Svi Predmeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aktivan Rok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Izbor Studenta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveStudenata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSviStudenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtImeIPrezime;
        private System.Windows.Forms.DataGridView dgvPrijaveStudenata;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtSifraPrijave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.ComboBox cmbSviPredmeti;
        private System.Windows.Forms.ComboBox cmbAktivanRok;
        private System.Windows.Forms.ComboBox cmbIzborStudenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

