namespace Fakultet_projekat
{
    partial class Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ime_studenta_TB = new System.Windows.Forms.TextBox();
            this.Prezime_Studenta_TB = new System.Windows.Forms.TextBox();
            this.Broj_Indexa_TB = new System.Windows.Forms.TextBox();
            this.adresebox = new System.Windows.Forms.ComboBox();
            this.Unesi_studenta_BTN = new System.Windows.Forms.Button();
            this.Izmeni_dugme = new System.Windows.Forms.Button();
            this.izbrisi_dugme = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(38, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "broj indexa";
            // 
            // Ime_studenta_TB
            // 
            this.Ime_studenta_TB.Location = new System.Drawing.Point(38, 40);
            this.Ime_studenta_TB.Name = "Ime_studenta_TB";
            this.Ime_studenta_TB.Size = new System.Drawing.Size(100, 20);
            this.Ime_studenta_TB.TabIndex = 5;
            // 
            // Prezime_Studenta_TB
            // 
            this.Prezime_Studenta_TB.Location = new System.Drawing.Point(164, 39);
            this.Prezime_Studenta_TB.Name = "Prezime_Studenta_TB";
            this.Prezime_Studenta_TB.Size = new System.Drawing.Size(100, 20);
            this.Prezime_Studenta_TB.TabIndex = 6;
            // 
            // Broj_Indexa_TB
            // 
            this.Broj_Indexa_TB.Location = new System.Drawing.Point(424, 38);
            this.Broj_Indexa_TB.Name = "Broj_Indexa_TB";
            this.Broj_Indexa_TB.Size = new System.Drawing.Size(100, 20);
            this.Broj_Indexa_TB.TabIndex = 7;
            // 
            // adresebox
            // 
            this.adresebox.FormattingEnabled = true;
            this.adresebox.Location = new System.Drawing.Point(285, 38);
            this.adresebox.Name = "adresebox";
            this.adresebox.Size = new System.Drawing.Size(121, 21);
            this.adresebox.TabIndex = 8;
            // 
            // Unesi_studenta_BTN
            // 
            this.Unesi_studenta_BTN.Location = new System.Drawing.Point(38, 467);
            this.Unesi_studenta_BTN.Name = "Unesi_studenta_BTN";
            this.Unesi_studenta_BTN.Size = new System.Drawing.Size(75, 23);
            this.Unesi_studenta_BTN.TabIndex = 9;
            this.Unesi_studenta_BTN.Text = "Unesi";
            this.Unesi_studenta_BTN.UseVisualStyleBackColor = true;
            this.Unesi_studenta_BTN.Click += new System.EventHandler(this.Unesi_studenta_BTN_Click);
            // 
            // Izmeni_dugme
            // 
            this.Izmeni_dugme.Location = new System.Drawing.Point(164, 467);
            this.Izmeni_dugme.Name = "Izmeni_dugme";
            this.Izmeni_dugme.Size = new System.Drawing.Size(75, 23);
            this.Izmeni_dugme.TabIndex = 10;
            this.Izmeni_dugme.Text = "Izmeni";
            this.Izmeni_dugme.UseVisualStyleBackColor = true;
            this.Izmeni_dugme.Click += new System.EventHandler(this.Izmeni_dugme_Click);
            // 
            // izbrisi_dugme
            // 
            this.izbrisi_dugme.Location = new System.Drawing.Point(285, 467);
            this.izbrisi_dugme.Name = "izbrisi_dugme";
            this.izbrisi_dugme.Size = new System.Drawing.Size(75, 23);
            this.izbrisi_dugme.TabIndex = 11;
            this.izbrisi_dugme.Text = "Izbrisi";
            this.izbrisi_dugme.UseVisualStyleBackColor = true;
            this.izbrisi_dugme.Click += new System.EventHandler(this.izbrisi_dugme_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Izmeni";
            this.dataGridViewImageColumn1.Image = global::Fakultet_projekat.Properties.Resources.update;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Obrisi";
            this.dataGridViewImageColumn2.Image = global::Fakultet_projekat.Properties.Resources.trush;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 569);
            this.Controls.Add(this.izbrisi_dugme);
            this.Controls.Add(this.Izmeni_dugme);
            this.Controls.Add(this.Unesi_studenta_BTN);
            this.Controls.Add(this.adresebox);
            this.Controls.Add(this.Broj_Indexa_TB);
            this.Controls.Add(this.Prezime_Studenta_TB);
            this.Controls.Add(this.Ime_studenta_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ime_studenta_TB;
        private System.Windows.Forms.TextBox Prezime_Studenta_TB;
        private System.Windows.Forms.TextBox Broj_Indexa_TB;
        private System.Windows.Forms.ComboBox adresebox;
        private System.Windows.Forms.Button Unesi_studenta_BTN;
        private System.Windows.Forms.Button Izmeni_dugme;
        private System.Windows.Forms.Button izbrisi_dugme;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa_studenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_indeksa;
        private System.Windows.Forms.DataGridViewImageColumn izmeni;
        private System.Windows.Forms.DataGridViewImageColumn Obrisi;
    }
}