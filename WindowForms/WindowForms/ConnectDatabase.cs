using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WindowForms
{
    internal class ConnectDatabase
    {
        public SqlConnection DatabaseConnect()
        {
            SqlConnection conn1 = new SqlConnection("Data Source=,\\sqlexpress;Initial Catalog=MainDB;Integrated Security=True;Trust Server Certificate=True");
            return conn1;
        }
    }
}
