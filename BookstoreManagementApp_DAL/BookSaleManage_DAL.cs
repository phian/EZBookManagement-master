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
    public class BookSaleManage_DAL
    {
        /**
         * Công việc cần làm
         * 1. Xem cách tạo cthd với khoá ngoại identity (ko dc thì làm kiểu tính toán thủ công)
         */
        private List<string> BookCodeList = new List<string>(); // List để chứa các mã sách đang có trong database để so sánh
        private List<string> BookTitleCodeList = new List<string>(); // List để chứa các mã tựa sách đang có trong database để so sánh
        private List<Book> BookTitleCodeAndBookCodeList = new List<Book>(); // List để chứa thông tin mã sách vã mã tựa sách đang có trong table sách

        // Hàm để đọc dữ liệu những cuốn sách đang có trong database
        private void ReadExistBookCodeFromDatabase()
        {
            string bookCodeQuery = "Select MASACH from SACH";

            using(SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookCodeList = new SqlCommand(bookCodeQuery, connection);
                SqlDataReader bookCodeReader = bookCodeList.ExecuteReader();

                while(bookCodeReader.Read())
                {
                    BookCodeList.Add((string)bookCodeReader["MASACH"]);
                }

                connection.Close();
            }
        }

        // Hàm để so sánh thông tin của mã sách ng dùng nhập vào đã tồn tại trong database hay chưa
        public bool CheckBookCode(string bookCode)
        {
            ReadExistBookCodeFromDatabase(); // Gọi hàm để đọc thông tin mã sách có trong database để so sánh

            for(int i = 0; i < BookCodeList.Count; i++)
            {
                if(string.Equals(bookCode.ToLower(), BookCodeList[i].ToLower()) == true)
                {
                    return true;
                }
            }
            return false;
        }

        // Hàm để đọc dữ liệu của những mã tựa sách đang có trong database để so sánh
        private void ReadBookTitleCodeFromDatabase()
        {
            string bookTitleCodeQuery = "Select MATUASACH from KHOSACH";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookTitleList = new SqlCommand(bookTitleCodeQuery, connection);
                SqlDataReader bookTitleCodeReader = bookTitleList.ExecuteReader();

                while(bookTitleCodeReader.Read())
                {
                    BookTitleCodeList.Add((string)bookTitleCodeReader["MATUASACH"]);
                }

                connection.Close();
            }
        }

        // Hàm để check xem mã tựa sách ng dùng nhập có tồn tại hay không
        public bool CheckBookTitleCode(string bookTitleCode)
        {
            ReadBookTitleCodeFromDatabase(); // Gọi hàm để đọc thông tin mã tựa sách có trong database để so sánh

            for (int i = 0; i < BookTitleCodeList.Count; i++)
            {
                if(string.Equals(bookTitleCode.ToLower(), BookTitleCodeList[i].ToLower()) == true)
                {
                    return true;
                }
            }

            return false;
        }

        // Hàm để lấy giá của quyển sách cần bán
        public int GetBookPriceFromDatabase(string bookQuery, string bookCode)
        {
            int BookPrice = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookPrice = new SqlCommand(bookQuery, connection);

                bookPrice.Parameters.Add("@BookCode", SqlDbType.VarChar, 300).Value = bookCode;

                BookPrice = (int)bookPrice.ExecuteScalar();

                connection.Close();
            }

            return BookPrice;
        }
        
        // Hàm để đọc dự liệu mã sách và mã tựa sách đang có trong table sách
        private void ReadBookTitleCodeAndBookCodeFromDB()
        {
            string bookCodeAndTitleCodeQuery = "Select MASACH, MATUASACH from SACH";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand bookCodeAndTitleCodeList = new SqlCommand(bookCodeAndTitleCodeQuery, connection);
                SqlDataReader bookCodeAndTitleCodeReader = bookCodeAndTitleCodeList.ExecuteReader();

                while(bookCodeAndTitleCodeReader.Read())
                {
                    Book newBook = new Book();

                    newBook.BookID = (string)bookCodeAndTitleCodeReader["MASACH"];
                    newBook.BookTitleCode = (string)bookCodeAndTitleCodeReader["MATUASACH"];

                    BookTitleCodeAndBookCodeList.Add(newBook);
                }

                connection.Close();
            }
        }

        // Hàm để check xem mã tựa sách có khớp với mã sách hay không
        public bool CheckBookTitleCodeReferenceWithBookCode(string bookTitleCode, string bookCode)
        {
            ReadBookTitleCodeAndBookCodeFromDB();

            for(int i = 0; i < BookTitleCodeAndBookCodeList.Count; i++)
            {
                if(string.Equals(BookTitleCodeAndBookCodeList[i].BookID.ToLower(), bookCode.ToLower()) == true && string.Equals(BookTitleCodeAndBookCodeList[i].BookTitleCode.ToLower(), bookTitleCode.ToLower()) == true)
                {
                    return true;
                }
            }

            return false;
        }

        // Hàm để xoá những cuốn sách đã bán
        public bool DeleteSoldBook(List<string> bookCode)
        {
            string deleteBookQuery = "Delete from SACH where MASACH = @BookCode";

            for(int i = 0; i < bookCode.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    SqlCommand deleteBook = new SqlCommand(deleteBookQuery, connection);

                    deleteBook.Parameters.Add("@BookCode", SqlDbType.VarChar, 300).Value = bookCode[i];

                    deleteBook.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        // Hàm để giảm số lượng trong kho sách khi sách đã dc bán
        public bool ReduceBookTotalNumberInDB(List<string> bookTitleCodeList)
        {
            string updateBookTotalNumber = "Update KHOSACH set SOLUONGTONKHO = SOLUONGTONKHO - 1 where MATUASACH = @BookTitleCode";

            for(int i = 0; i < bookTitleCodeList.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    SqlCommand updateTotalNumber = new SqlCommand(updateBookTotalNumber, connection);

                    updateTotalNumber.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCodeList[i];

                    updateTotalNumber.ExecuteNonQuery();

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
