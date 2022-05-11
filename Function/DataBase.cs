using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Function
{
    public class DataBase
    {
        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=phu;Initial Catalog=QLDG;Integrated Security=True");
            return conn;
        }
        public SqlDataAdapter Query(String command)
        { 
            SqlDataAdapter adapter = new SqlDataAdapter(command,Connect());
            return adapter;
        }
    }
}
