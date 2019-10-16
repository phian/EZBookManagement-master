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
    public class RevenueReportManage_DAL // Class để quản lý các hàm để tương tác với thao tác quản lý thống kê
    {
        List<StaffInfo> staffInfo = new List<StaffInfo>(); // List để lưu trữ thông tin nhân viên từ database để so sánh

        // Hàm để lấy dữ liệu hoá đơn tương ứng từ database
        public DataSet GetSalesInvoiceByCategories(string getInvoiceQuery)
        {
            DataSet salesInvoiceData = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter SalesInvoiceData = new SqlDataAdapter(getInvoiceQuery, connection);

                SalesInvoiceData.Fill(salesInvoiceData);

                connection.Close();
            }

            return salesInvoiceData;
        }

        // Hàm để lấy thông tin của nhân viên trong database để so sánh dữ liệu
        private void ReadStaffInfoFromDatabase()
        {
            string staffQuery = "Select TENNV, MANV from NHANVIEN";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand staffInfos = new SqlCommand(staffQuery, connection);
                SqlDataReader staffInfoReader = staffInfos.ExecuteReader();

                while(staffInfoReader.Read())
                {
                    StaffInfo newStaff = new StaffInfo();

                    newStaff.StaffName = (string)staffInfoReader["TENNV"];
                    newStaff.StaffID = (string)staffInfoReader["MANV"];

                    staffInfo.Add(newStaff);
                }

                connection.Close();
            }
        }

        // Hàm để check thông tin của nhân viên nhập vào là đúng hay sai
        public bool CheckStaffInfo(string staffName, string staffID)
        {
            ReadStaffInfoFromDatabase(); // Gọi hàm để đọc dữ liệu nhân viên từ database

            for(int i = 0; i < staffInfo.Count; i++)
            {
                if(string.Equals(staffInfo[i].StaffName.ToLower(), staffName.ToLower()) == true && string.Equals(staffInfo[i].StaffID.ToLower(), staffID.ToLower()) == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
