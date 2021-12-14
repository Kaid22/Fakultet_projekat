using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Fakultet_projekat
{
    public partial class Student : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        // Globalne promenljive 
        string id_grida;
        int selektovani_red_grida, id_ucenika, id_ulice;


        public Student()
        {
            InitializeComponent();
            //Uspostavljanje konekcije u trenutku poziva forme


        }
        void Ucitaj_ucenika()
        {

            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select s.id_studenta, s.ime, s.prezime, s.broj_indeksa, a.grad, a.drzava,a.ime_ulice from student as s left outer join adrese as a on s.adrese_id_adrese = a.id_adrese", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["id_studenta"].ToString(), dr["ime"].ToString(), dr["prezime"].ToString(), $"{dr["drzava"].ToString()}, {dr["grad"].ToString()}, {dr["ime_ulice"].ToString()} ", dr["broj_indeksa"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        void Ucitaj_Adrese()
        {
            cn.Open();
            cm = new SqlCommand(" SELECT * FROM adrese ", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            adresebox.DataSource = dt;

            //Pozivanje ostalih redova u DataSourse 

            adresebox.DisplayMember = "ime_ulice";
            adresebox.ValueMember = "id_adrese";

            adresebox.AutoCompleteMode = AutoCompleteMode.Suggest;
            adresebox.AutoCompleteSource = AutoCompleteSource.ListItems;

            dr.Close();
            cn.Close();
        }

        private void Unesi_studenta_BTN_Click(object sender, EventArgs e)
        {
            if (Ime_studenta_TB.Text != "" && Prezime_Studenta_TB.Text != "" && adresebox.Text != "" && Broj_Indexa_TB.Text != "")
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand(" INSERT INTO student(ime,prezime,adrese_id_adrese,broj_indeksa)" +
                                        " VALUES (@ime, @prezime, @adrese_id_adrese, @broj_indeksa)", cn);

                    cm.Parameters.AddWithValue("@ime", Ime_studenta_TB.Text);
                    cm.Parameters.AddWithValue("@prezime", Prezime_Studenta_TB.Text);
                    cm.Parameters.AddWithValue("@adrese_id_adrese", adresebox.SelectedValue);
                    cm.Parameters.AddWithValue("@broj_indeksa", Broj_Indexa_TB.Text);


                    cm.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novog učenika", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cn.Close();

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli potrebne podatke o uceniku", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Ucitaj_ucenika();

        }

        private void izbrisi_dugme_Click(object sender, EventArgs e)
        {
            id_grida = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand(" DELETE FROM student " +
                                        " WHERE id_studenta=" + id_grida, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Ucitaj_ucenika();
                    MessageBox.Show("Red je uspesno izbrisan", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void Izmeni_dugme_Click(object sender, EventArgs e)
        {
            //Izmena selektovanog objekta
            id_grida = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            //Kreiranje upita za unos podataka u tabelu objekat
            cn.Open();
            cm = new SqlCommand(" UPDATE student  SET ime=@ime_studenta, prezime=@prezime_studenta, " +
                                                   " broj_indeksa=@broj_indeksa, " +
                                                   " adrese_id_adrese=@id_adrese " +
                                                   " WHERE id_studenta=" + id_grida, cn);

            cm.Parameters.AddWithValue("@ime_studenta", Ime_studenta_TB.Text);
            cm.Parameters.AddWithValue("@prezime_studenta", Prezime_Studenta_TB.Text);
            cm.Parameters.AddWithValue("@broj_indeksa", Broj_Indexa_TB.Text);
            cm.Parameters.AddWithValue("@id_adrese", adresebox.SelectedValue);
            cm.ExecuteNonQuery();
            cn.Close();
            Ucitaj_ucenika();

            dataGridView1.Rows[selektovani_red_grida].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Ime_studenta_TB.Clear();
            Prezime_Studenta_TB.Clear();
            Broj_Indexa_TB.Clear();
            adresebox.SelectedValue = 0;
        }

    private void Student_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(dbcon.MyConection());
            Ucitaj_ucenika();
            Ucitaj_Adrese();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Izmena i brisanje podataka iz grida - Objekat
            string naziv_kolone = dataGridView1.Columns[e.ColumnIndex].Name;
            id_grida = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            selektovani_red_grida = dataGridView1.CurrentRow.Index;
            //Editovanje i brisanje reda iz DataGrid-a
            if (naziv_kolone == "izmeni")
            {
                id_ucenika = Int32.Parse(id_grida);
                cn.Open();
                cm = new SqlCommand(" SELECT * FROM student" +
                                    " WHERE id_studenta=" + id_ucenika, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Ime_studenta_TB.Text = dr["ime"].ToString();
                    Prezime_Studenta_TB.Text = dr["prezime"].ToString();
                    id_ulice = Int32.Parse(dr["adrese_id_adrese"].ToString());
                    Broj_Indexa_TB.Text = dr["broj_indeksa"].ToString();
                }

                dr.Close();
                cn.Close();

                //Mora da postoji zatvorena konekcija zbog selektovanja vradnosti iz ComboBox-ova
                adresebox.SelectedValue = id_ulice;

            }
            else if (naziv_kolone == "Obrisi")
            {
                try
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand(" DELETE FROM student " +
                                            " WHERE id_studenta=" + id_grida, cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        Ucitaj_ucenika();
                        MessageBox.Show("Red je uspesno izbrisan", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    dr.Close();
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}

