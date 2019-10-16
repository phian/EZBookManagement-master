using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DAL
{
    public class Staff_salary_DAL
    {
        //Hàm lấy thông tin toàn bộ các nhân viên từ cơ sở dữ liệu
        public DataSet Get()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT ID, FULLNAME, PAYRATE, BASICRATE, ALLOWENCE from STAFF";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
