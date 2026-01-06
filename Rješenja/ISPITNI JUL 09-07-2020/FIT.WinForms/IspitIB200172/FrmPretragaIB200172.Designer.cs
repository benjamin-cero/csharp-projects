namespace FIT.WinForms.IspitIB200172
{
    partial class FrmPretragaIB200172
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
            txtPretraga = new TextBox();
            chbAktivnost = new CheckBox();
            cbSemestar = new ComboBox();
            dgvStudenti = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Indeks = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Slika = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 12);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(512, 27);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // chbAktivnost
            // 
            chbAktivnost.AutoSize = true;
            chbAktivnost.Location = new Point(687, 14);
            chbAktivnost.Name = "chbAktivnost";
            chbAktivnost.Size = new Size(80, 24);
            chbAktivnost.TabIndex = 1;
            chbAktivnost.Text = "Aktivan";
            chbAktivnost.UseVisualStyleBackColor = true;
            chbAktivnost.CheckedChanged += chbAktivnost_CheckedChanged;
            // 
            // cbSemestar
            // 
            cbSemestar.FormattingEnabled = true;
            cbSemestar.Location = new Point(530, 12);
            cbSemestar.Name = "cbSemestar";
            cbSemestar.Size = new Size(151, 28);
            cbSemestar.TabIndex = 2;
            cbSemestar.SelectedIndexChanged += cbSemestar_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Semestar, Indeks, Aktivan, Slika });
            dgvStudenti.Location = new Point(12, 61);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(776, 360);
            dgvStudenti.TabIndex = 3;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.MinimumWidth = 6;
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.HeaderText = "";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Text = "Slika";
            Slika.UseColumnTextForButtonValue = true;
            // 
            // FrmPretragaIB200172
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudenti);
            Controls.Add(cbSemestar);
            Controls.Add(chbAktivnost);
            Controls.Add(txtPretraga);
            Name = "FrmPretragaIB200172";
            Text = "FrmPretragaIB200172";
            Load += FrmPretragaIB200172_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        private CheckBox chbAktivnost;
        private ComboBox cbSemestar;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Slika;
    }
}