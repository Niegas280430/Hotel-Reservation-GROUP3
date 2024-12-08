using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowForms
{
    internal class ConnectDatabase
    {
        public SqlConnection DatabaseConnect()
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=UserDB;Integrated Security=True;Encrypt=True;");
            return conn;
        }
    }
}
