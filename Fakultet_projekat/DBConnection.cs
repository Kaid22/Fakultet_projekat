using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet_projekat
{
    class DBConnection
    {
        public string MyConection()
        {
            string con = @"Data Source=KAID; Initial Catalog=Fakultet_projekat; Trusted_Connection=true; Integrated Security=True";
            return con;
        }
    }
}
