namespace Fakultet_projekat
{
    partial class Pretraga
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
            this.PretraziTB = new System.Windows.Forms.TextBox();
            this.Pretrazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_studenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime_studenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime_studenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa_studenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_indeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmeni = new System.Windows.Forms.DataGridViewImageColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PretraziTB
            // 
            this.PretraziTB.Location = new System.Drawing.Point(12, 12);
            this.PretraziTB.Name = "PretraziTB";
            this.PretraziTB.Size = new System.Drawing.Size(100, 20);
            this.PretraziTB.TabIndex = 0;
            // 
            // Pretrazi
            // 
            this.Pretrazi.Location = new System.Drawing.Point(135, 10);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(75, 23);
            this.Pretrazi.TabIndex = 1;
            this.Pretrazi.Text = "Pretrazi";
            this.Pretrazi.UseVisualStyleBackColor = true;
            this.Pretrazi.Click += new System.EventHandler(this.Pretrazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_studenta,
            this.Ime_studenta,
            this.Prezime_studenta,
            this.adresa_studenta,
            this.Broj_indeksa,
            this.izmeni,
            this.Obrisi});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id_studenta
            // 
            this.Id_studenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id_studenta.HeaderText = "ID";
            this.Id_studenta.Name = "Id_studenta";
            this.Id_studenta.ReadOnly = true;
            this.Id_studenta.Width = 43;
            // 
            // Ime_studenta
            // 
            this.Ime_studenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ime_studenta.HeaderText = "Ime";
            this.Ime_studenta.Name = "Ime_studenta";
            this.Ime_studenta.ReadOnly = true;
            this.Ime_studenta.Width = 49;
            // 
            // Prezime_studenta
            // 
            this.Prezime_studenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Prezime_studenta.HeaderText = "Prezime";
            this.Prezime_studenta.Name = "Prezime_studenta";
            this.Prezime_studenta.ReadOnly = true;
            this.Prezime_studenta.Width = 69;
            // 
            // adresa_studenta
            // 
            this.adresa_studenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.adresa_studenta.HeaderText = "Adresa";
            this.adresa_studenta.Name = "adresa_studenta";
            this.adresa_studenta.ReadOnly = true;
            this.adresa_studenta.Width = 65;
            // 
            // Broj_indeksa
            // 
            this.Broj_indeksa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Broj_indeksa.HeaderText = "Broj Indeksa";
            this.Broj_indeksa.Name = "Broj_indeksa";
            this.Broj_indeksa.ReadOnly = true;
            this.Broj_indeksa.Width = 91;
            // 
            // izmeni
            // 
            this.izmeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.izmeni.HeaderText = "Izmeni";
            this.izmeni.Image = global::Fakultet_projekat.Properties.Resources.update;
            this.izmeni.Name = "izmeni";
            this.izmeni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.izmeni.Width = 43;
            // 
            // Obrisi
            // 
            this.Obrisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Image = global::Fakultet_projekat.Properties.Resources.trush;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisi.Width = 39;
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.PretraziTB);
            this.Name = "Pretraga";
            this.Text = "Pretrag";
            this.Load += new System.EventHandler(this.Pretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PretraziTB;
        private System.Windows.Forms.Button Pretrazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_indeksa;
        private System.Windows.Forms.DataGridViewImageColumn izmeni;
        private System.Windows.Forms.DataGridViewImageColumn Obrisi;
    }
}