using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementApp_DAL
{
    public class BookRepoManage_DAL
    {
        List<string> ExistTitleCode = new List<string>(); // list để lưu trữ các mã tựa sách đang tồn tại trong database
        List<string> ExistInvoiceCode = new List<string>(); // list để lưu trữ các mã hoá đơn đang tồn tại trong database

        // Hàm để đọc các mã tựa sách đang có trong database
        public void ReadBookTitleCodeFromDatabase()
        {
            string query = "Select * from KHOSACH";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookRepoInfo = new SqlCommand(query, connection); // Đọc tất cả dữ liệu đang có trong kho sách
                SqlDataReader bookRepoReader = bookRepoInfo.ExecuteReader();

                while (bookRepoReader.Read())
                {
                    ExistTitleCode.Add((string)bookRepoReader["MATUASACH"]); // Add các mã tựa sách đang có vào list
                }

                connection.Close();
            }
        }

        // Hàm để check xem mã tựa sách ng dùng nhập vào có tồn tại hay chưa
        public bool CheckBookTitleCode(string bookTitleCode)
        {
            ReadBookTitleCodeFromDatabase(); // Gọi hàm để đọc dữ liệu từ database

            // Vòng lặp để ktr các mã sách đã tồn tại có trùng với mã sách mới thêm vào hay ko
            for(int i = 0; i < ExistTitleCode.Count; i++)
            {
                if(bookTitleCode.ToLower() == ExistTitleCode[i].ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        // Hàm để insert thông tin mới vào kho sách
        public bool InsertBookRepo(string insertBookRepoQuery, string bookTitleCode, int inventoryQuantity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand repoInfo = new SqlCommand(insertBookRepoQuery, connection);

                repoInfo.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;
                repoInfo.Parameters.Add("@InventoryQuantity", SqlDbType.NVarChar, 20).Value = inventoryQuantity;

                repoInfo.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để lấy ra tổng số lượng sách cho những mã sách đang có trong kho sách
        public int ReadBookTotalNumber(string bookTitleCode)
        {
            int Total = 0; // Biến để lưu trữ tổng số lượng của mã sách đã tồn tại

            string countBook = "Select SOLUONGTONKHO from KHOSACH where MATUASACH = @BookTitleCode";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookAmount = new SqlCommand(countBook, connection);

                bookAmount.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                SqlDataReader dataReader = bookAmount.ExecuteReader();

                while (dataReader.Read())
                {
                    Total = (int)dataReader["SOLUONGTONKHO"];
                }

                connection.Close();
            }

            return Total;
        }

        // Hàm để update lại dữ liệu mã tựa sách nếu ng dùng add 1 mã tựa sách đã tồn tại
        public bool UpdateBookRepoInfo(string updateBookRepoQuery, string bookTitleCode, int inventoryQuantity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand repoInfo = new SqlCommand(updateBookRepoQuery, connection);

                repoInfo.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;
                repoInfo.Parameters.Add("@InventoryQuantity", SqlDbType.Int).Value = inventoryQuantity;

                repoInfo.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        //----------------------------------------------------------------------------------------------------------------//

        // Hàm để insert dữ liệu vào bảng hoá đơn
        public bool InsertInvoiceInfo(string insertInvoiceQuery, string invoiceCode, string bookTitleCode, int newBookNumber, DateTime goodsReceiveDay, string shipmentCode, string goodsReceivePlace)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand invoiceInfo = new SqlCommand(insertInvoiceQuery, connection);

                invoiceInfo.Parameters.Add("@InvoiceCode", SqlDbType.VarChar, 50).Value = invoiceCode;
                invoiceInfo.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;
                invoiceInfo.Parameters.Add("@NewBookNumber", SqlDbType.Int).Value = newBookNumber;
                invoiceInfo.Parameters.Add("@GoodsReceiveDay", SqlDbType.Date).Value = goodsReceiveDay;
                invoiceInfo.Parameters.Add("@ShipmentCode", SqlDbType.NVarChar, 20).Value = shipmentCode;
                invoiceInfo.Parameters.Add("@GoodsReceivePlace", SqlDbType.NVarChar, 100).Value = goodsReceivePlace;

                invoiceInfo.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để đọc các mã hoá đơn đang có trong database
        public void ReadInvoiceCodeFromDatabase()
        {
            string query = "Select * from HOADON";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand invoiceCodeList = new SqlCommand(query, connection);
                SqlDataReader dataReader = invoiceCodeList.ExecuteReader();

                while(dataReader.Read())
                {
                    ExistInvoiceCode.Add((string)dataReader["MAHOADON"]);
                }

                connection.Close();
            }
        }

        // Hàm để check xem mã hoá đơn ng dùng nhập vào đã tồn tại hay chưa 
        public bool CheckInvoiceCode(string invoiceCode)
        {
            ReadInvoiceCodeFromDatabase(); 

            for (int i = 0; i < ExistInvoiceCode.Count; i++)
            {
                if(string.Equals(invoiceCode.ToLower(), ExistInvoiceCode[i].ToLower()) == true)
                {
                    return true;
                }
            }

            return false;
        }

        //-------------------------------------------------Phần cho nút sửa-----------------------------------------------//

        // Hàm để đọc các giá trĩ đang có trong database của kho sách
        public DataSet ReadBookRepoData(string bookRepoQuery)
        {
            DataSet booksRepoData = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter bookRepoData = new SqlDataAdapter(bookRepoQuery, connection);

                bookRepoData.Fill(booksRepoData);

                connection.Close();
            }

            return booksRepoData;
        }

        // Hàm để update dữ liệu khi ng dùng ko sửa số lượng mới
        public bool UpdateBookRepo(string updateQuery, string invoiceCode, string bookTitleCode, int newBookNumber, DateTime goodsReceiveDay, string shipmentCode, string goodsReceivePlace)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand updateRepoInfo = new SqlCommand(updateQuery, connection);

                updateRepoInfo.Parameters.Add("@InvoiceCode", SqlDbType.VarChar, 50).Value = invoiceCode;
                updateRepoInfo.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;
                updateRepoInfo.Parameters.Add("@NewBookNumber", SqlDbType.Int).Value = newBookNumber;
                updateRepoInfo.Parameters.Add("@GoodsReceiveDay", SqlDbType.Date).Value = goodsReceiveDay;
                updateRepoInfo.Parameters.Add("@ShipmentCode", SqlDbType.NVarChar, 20).Value = shipmentCode;
                updateRepoInfo.Parameters.Add("GoodsReceivePlace", SqlDbType.NVarChar, 100).Value = goodsReceivePlace;

                updateRepoInfo.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để update dữ liệu cho bảng kho sách nếu ng dùng có sửa số lượng mới
        public bool UpdateBookRepoNewBookNumberInfo(string updateBookRepoQuery, int newBookNumber, string bookTitleCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookRepoInfo = new SqlCommand(updateBookRepoQuery, connection);

                bookRepoInfo.Parameters.Add("@NewBookNumber", SqlDbType.Int).Value = newBookNumber;
                bookRepoInfo.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                bookRepoInfo.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        //----------------------------------------------------------------------------------------------------------------//

        //-------------------------------------------------Phần cho nút xoá-----------------------------------------------//

        // Hàm để xoá hoá đơn
        public bool DeleteInvoiceInfo(string deleteInvoiceQuery, string invoiceCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand invoiceInfo = new SqlCommand(deleteInvoiceQuery, connection);

                invoiceInfo.Parameters.Add("@InvoiceCode", SqlDbType.VarChar, 50).Value = invoiceCode;

                invoiceInfo.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Phần xoá dữ liệu trong kho sách--------------------------------------------------------------------------------//

        // Hàm để đọc dữ liệu đang có trong kho sách để dùng cho việc xoá
        public DataSet ReadBookRepoDataFromDB(string bookRepoDataQuery)
        {
            DataSet bookRepoData = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter repoData = new SqlDataAdapter(bookRepoDataQuery, connection);

                repoData.Fill(bookRepoData);

                connection.Close();
            }

            return bookRepoData;
        }

        // Hàm để xoá dữ liệu trong kho sách
        public bool DeleteBookRepoData(string deleteBookRepoDataQuery, string bookTitleCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand deleteBookRepoData = new SqlCommand(deleteBookRepoDataQuery, connection);

                deleteBookRepoData.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                deleteBookRepoData.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để xoá các hoá đơn của 1 mã tựa sách khi mã tựa sách bị xoá
        public bool DeleteAllInvoiceBelongToABookTitleCode(string deleteAllInvoiceQuery, string bookTitleCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand deleteAllInvoice = new SqlCommand(deleteAllInvoiceQuery, connection);

                deleteAllInvoice.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                deleteAllInvoice.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để xoá tất cả sách thuộc một mã tựa sách bị xoá
        public bool DeleteAllBookBelongToABookTitleCode(string deleteAllBookQuery, string bookTitleCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand deleteAllBook = new SqlCommand(deleteAllBookQuery, connection);

                deleteAllBook.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                deleteAllBook.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        //----------------------------------------------------------------------------------------------------------------//

        //--------------------------------------------Phần cho nút thống kê-----------------------------------------------//


        // Hàm để đọc thông tin đang có trong kho sách dùng cho việc thống kê
        public DataSet ReadBookRepoInfoData(string bookRepoQuery)
        {
            DataSet bookRepoInfo = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter BookRepoInfo = new SqlDataAdapter(bookRepoQuery, connection);

                BookRepoInfo.Fill(bookRepoInfo);

                connection.Close();
            }

            return bookRepoInfo;
        }


    }
}
