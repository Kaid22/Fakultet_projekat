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
    class Ucitavanje
    {
           public void Ucitaj_ucenika(SqlConnection cn, SqlDataReader dr, DataGridView dataGridView1)
            {

                dataGridView1.Rows.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("select s.id_studenta, s.ime, s.prezime, s.broj_indeksa, a.grad, a.drzava,a.ime_ulice from student as s left outer join adrese as a on s.adrese_id_adrese = a.id_adrese", cn);
                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id_studenta"].ToString(), dr["ime"].ToString(), dr["prezime"].ToString(), $"{dr["drzava"].ToString()}, {dr["grad"].ToString()}, {dr["ime_ulice"].ToString()} ", dr["broj_indeksa"].ToString());
                }
                dr.Close();
                cn.Close();
            }

        public void Ucitaj_Adrese(SqlConnection cn, SqlDataReader dr, ComboBox adresebox)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand(" SELECT * FROM adrese ", cn);
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
        public void Pretrazi_studente(SqlConnection cn, SqlDataReader dr, DataGridView dataGridView1, string imekolone, string vrednost)
        {

            dataGridView1.Rows.Clear();
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand ("select s.id_studenta, s.ime, s.prezime, s.broj_indeksa, a.ime_ulice, a.grad, a.drzava "
                +"from student as s "
                +"left outer join adrese as a on s.adrese_id_adrese = a.id_adrese "
                +$"where {imekolone} like '%{vrednost}%'", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["id_studenta"].ToString(), dr["ime"].ToString(), dr["prezime"].ToString(), $"{dr["drzava"].ToString()}, {dr["grad"].ToString()}, {dr["ime_ulice"].ToString()} ", dr["broj_indeksa"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
