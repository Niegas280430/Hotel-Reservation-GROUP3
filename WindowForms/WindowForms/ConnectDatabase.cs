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
        public SqlConnection Connect()
        {
            SqlConnection connect = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            return connect;
        }
    }
}
