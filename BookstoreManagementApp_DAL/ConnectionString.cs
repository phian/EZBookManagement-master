using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DAL
{
    public class ConnectionString // Lớp chứa đường dẫn đến daabase của máy
    {
        // Đường dẫn database
        public static string connectionString = "Data Source=" + Dns.GetHostName() + ";Initial Catalog=EzManage;Integrated Security=True";
        public SqlConnection GetConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
    
}
