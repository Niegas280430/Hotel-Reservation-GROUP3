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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2TV9723;Initial Catalog=UserInfo;Integrated Security=True;Trust Server Certificate=True");
            return conn;
        }
    }
}
