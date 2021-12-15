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
    public partial class Pretraga : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        Ucitavanje loader = new Ucitavanje();
        public Pretraga()
        {
            InitializeComponent();
        }

        private void Pretraga_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(dbcon.MyConection());
            loader.Ucitaj_ucenika(cn, dr, dataGridView1);
        }

        private void Pretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                int vrednost = Int32.Parse(PretraziTB.Text);
                loader.Pretrazi_studente(cn, dr, dataGridView1, "id_studenta", vrednost.ToString());
            }
            catch
            {
                string vrednost = PretraziTB.Text.ToString();
                loader.Pretrazi_studente(cn, dr, dataGridView1, $"ime like '%{vrednost}%' or prezime", vrednost);
            }
        }
    }
}
