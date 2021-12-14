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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student formastudent = new Student();
            formastudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection dbcon = new DBConnection();
            SqlConnection cn = new SqlConnection (dbcon.MyConection());
            cn.Open();
            MessageBox.Show("Connection Open  !");
            cn.Close();
        }
    }
}
