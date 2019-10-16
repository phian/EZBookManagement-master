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
    public class AccessorySale_DAL
    {
        
        private List<string> AccessoryID = new List<string>(); // List để chứa các mã sản phẩm có trong database
        private List<string> AccessoryTypeID = new List<string>(); // List để chứa các mã loại sản phẩm đang có trong database để so sánh
        private List<AccessoryOffice> AccessoryTypeandID = new List<AccessoryOffice>(); // List để chứa thông tin mã sản phẩm và mã loại sản phẩm

        // Hàm để đọc dữ liệu những cuốn sách đang có trong database
        private void ReadExistAccessoryCodeFromDatabase()
        {
            string query = "Select MASANPHAM from VANPHONGPHAM";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AccessoryID.Add((string)dr["MASANPHAM"]);
                }

                connection.Close();
            }
        }

        // Hàm để so sánh thông tin của MÃ SẢN PHẨM ng dùng nhập vào đã tồn tại trong database hay chưa
        public bool CheckAccessoryID(string AccessoryCode)
        {
            ReadExistAccessoryCodeFromDatabase(); // Gọi hàm để đọc thông tin mã sản phẩm có trong database để so sánh

            for (int i = 0; i < AccessoryID.Count; i++)
            {
                if (string.Equals(AccessoryCode.ToLower(), AccessoryID[i].ToLower()) == true)
                {
                    return true;
                }
            }
            return false;
        }

        // Hàm để đọc dữ liệu của những mã tựa sách đang có trong database để so sánh
        private void ReadAccessoryTypeIDFromDatabase()
        {
            string query = "Select MALOAISANPHAM from KHOVANPHONGPHAM";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AccessoryTypeID.Add((string)dr["MALOAISANPHAM"]);
                }

                connection.Close();
            }
        }

        // Hàm để check xem mã loại sản phẩm ng dùng nhập có tồn tại hay không
        public bool CheckAccessoryTypeID(string AccessoryTypeCode)
        {
            ReadAccessoryTypeIDFromDatabase(); // Gọi hàm để đọc thông tin mã loại sản phẩm có trong database để so sánh

            for (int i = 0; i < AccessoryTypeID.Count; i++)
            {
                if (string.Equals(AccessoryTypeCode.ToLower(), AccessoryTypeID[i].ToLower()) == true)
                {
                    return true;
                }
            }

            return false;
        }

        // Hàm để lấy giá của văn phòng phẩm cần bán
        public Decimal GetAccessoryPriceFromDatabase(string query, string AccessoryCode)
        {
            Decimal AccessoryPrice = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 50).Value = AccessoryCode;

                AccessoryPrice = (Decimal)cmd.ExecuteScalar();

                connection.Close();
            }

            return AccessoryPrice;
        }

        // Hàm để đọc dự liệu mã văn phòng phẩm và mã loại sản phẩm đang có trong table VĂN PHÒNG PHẨM
        private void ReadAccessoryIDandTypeFromDB()
        {
            string query = "Select MASANPHAM, MALOAISANPHAM FROM VANPHONGPHAM";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AccessoryOffice VANPHONGPHAM = new AccessoryOffice();

                    VANPHONGPHAM.MASANPHAM = (string)dr["MASANPHAM"];
                    VANPHONGPHAM.MALOAISANPHAM = (string)dr["MALOAISANPHAM"];
                    AccessoryTypeandID.Add(VANPHONGPHAM);
                }
                connection.Close();
            }
        }

        // Hàm để check xem mã loại sản phẩm có khớp với mã sản phẩm hay không 

        public bool CheckAccessoryIDReferencesTypeID(string AccessoryTypeID, string AccessoryID)
        {
            ReadAccessoryIDandTypeFromDB();

            for (int i = 0; i < AccessoryTypeandID.Count; i++)
            {
                if (string.Equals(AccessoryTypeandID[i].MASANPHAM.ToLower(), AccessoryID.ToLower()) == true && string.Equals(AccessoryTypeandID[i].MALOAISANPHAM.ToLower(), AccessoryTypeID.ToLower()) == true)
                {
                    return true;
                }
            }

            return false;
        }

        // Hàm để xoá những sản phẩm đã bán
        public bool DeleteSoldAccessory(List<string> AccessoryID)
        {
            string query = "Delete from VANPHONGPHAM where MASANPHAM = @masanpham";

            for (int i = 0; i < AccessoryID.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 300).Value = AccessoryID[i];

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        // Hàm để giảm số lượng trong kho văn phòng phẩm khi sản phẩm đã bán
        public bool ReduceAccessoryTotalnumberInDB(List<string> AccessoryTypeID)
        {
            string query = "Update KHOVANPHONGPHAM set SOLUONGTONKHO = SOLUONGTONKHO - 1 where MALOAISANPHAM = @masanpham";

            for (int i = 0; i < AccessoryTypeID.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 50).Value = AccessoryTypeID[i];

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        // Phần thêm thông tin vào bảng hoá đơn và CTHD

        // Hàm để đếm số lượng hoá đơn đang có trong database
        public int CountInvoiceData(string countInvoiceQuery)
        {
            int totalInvoice = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand countInvoice = new SqlCommand(countInvoiceQuery, connection);

                totalInvoice = (int)countInvoice.ExecuteScalar();

                connection.Close();
            }

            return totalInvoice;
        }

        // Hàm để insert dữ liệu vào table hoá đơn bán hàng
        public bool AddNewInvoiceToDB(string insertNewInvoiceQuery, string invoiceCode, int amountCusMustPay, int excessMoney, DateTime dateOfInvoicing)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand invoiceData = new SqlCommand(insertNewInvoiceQuery, connection);

                invoiceData.Parameters.Add("@InvoiceCode", SqlDbType.VarChar, 8000).Value = invoiceCode;
                invoiceData.Parameters.Add("@AmountCusMustPay", SqlDbType.Money).Value = amountCusMustPay;
                invoiceData.Parameters.Add("@ExcessMoney", SqlDbType.Money).Value = excessMoney;
                invoiceData.Parameters.Add("@DateOfInvoicing", SqlDbType.DateTime).Value = dateOfInvoicing;

                invoiceData.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để thếm 1 chi tiết hoá đơn mới
        public bool AddNewInvoiceDetailsToDB(string insertNewInvoiceDetailsQuery, string invoiceCode, string booksCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand invoiceDetailData = new SqlCommand(insertNewInvoiceDetailsQuery, connection);

                invoiceDetailData.Parameters.Add("@InvoiceDetailsCode", SqlDbType.VarChar, 8000).Value = invoiceCode;
                invoiceDetailData.Parameters.Add("@BooksCode", SqlDbType.VarChar, 300).Value = booksCode;

                invoiceDetailData.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để đếm số lượng hoá đơn đang có trong bảng CTHD
        public int CountInvoiceDetailsNumnber(string countInvoiceQuery)
        {
            int invoiceNumber = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand countInvoice = new SqlCommand(countInvoiceQuery, connection);

                invoiceNumber = (int)countInvoice.ExecuteScalar();

                connection.Close();
            }

            return invoiceNumber;
        }
    }
}
