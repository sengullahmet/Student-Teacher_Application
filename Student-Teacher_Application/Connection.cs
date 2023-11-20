using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Application
{
    public class Connection
    {

        public SqlConnection connect()
        {
            SqlConnection connection = new SqlConnection();
            return connection;

        }

    }
}
