using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SAednevnik
{
    internal class Connection
    {
        public static SqlConnection connect()
        {
            string Cstring;
            Cstring = ConfigurationManager.ConnectionStrings["skola"].ConnectionString;
            SqlConnection veza = new SqlConnection(Cstring);
            return veza;
        }
    }
}
