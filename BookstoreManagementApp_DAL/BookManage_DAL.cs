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
    public class BookManage_DAL // Lớp để tạo các tương tác với database cho bảng sách
    {
        // Khởi tạo danh sách để lưu trữ các thông tin sách được đọc lên từ database
        List<Book> booksList = new List<Book>();

        // Hàm để add sách đọc từ database vào list
        public void AddBookToList()
        {
            // Câu lệnh để truy xuất sách trong bảng sách
            string bookQuery = "Select * from SACH";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                // Nơi để lưu danh sách những cuốn sách được đọc lên từ database
                SqlCommand bookList = new SqlCommand(bookQuery, connection);
                SqlDataReader bookReader = bookList.ExecuteReader();

                while (bookReader.Read())
                {
                    Book newBook = new Book(); // Tạo ra một cuốn sách mới để lưu dữ liệu và đưa và list

                    // Gán các dữ liệu từ các cột tương ứng vào cho thông tin trong sách
                    newBook.BookID = (string)bookReader["MASACH"];
                    newBook.BookName = (string)bookReader["TENSACH"];
                    newBook.BookAuthorName = (string)bookReader["TENTG"];
                    newBook.BookTranslatorName = (string)bookReader["DICHGIA"];
                    newBook.BookPublishedDay = (DateTime)bookReader["NGAYXB"];
                    newBook.BookRepublishedTime = (int)bookReader["LANTAIBAN"];
                    newBook.BookPrice = (int)bookReader["GIA"];
                    newBook.BookType = (string)bookReader["THELOAI"];
                    newBook.BookTitleCode = (string)bookReader["MATUASACH"];

                    booksList.Add(newBook); // Thêm sách vào list
                }

                connection.Close();
            }
        }

        // Hàm để check xem mã sách nhập vào đã đúng hay chưa (chuyển qua BUS với DAL)
        public bool CheckBookID(string BookID)
        {
            AddBookToList(); // Gọi hàm để thêm thông tin sách vào 

            for (int i = 0; i < booksList.Count; i++)
            {
                if (string.Equals(booksList[i].BookID.ToLower(), BookID.ToLower()) == true)
                {
                    return false;
                }
            }

            return true;
        }

        // Hàm để đọc dữ liệu những cuốn sách có trong database
        public DataSet ReadBookFromDatabase()
        {
            DataSet bookDataList = new DataSet(); // Nơi lưu trữ thông tin sách để trả về

            string bookQuery = "Select * from SACH"; // Câu lệnh để query dữ liệu từ database

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter bookData = new SqlDataAdapter(bookQuery, connection); // Nơi để chứa data sách khi đọc từ database lên

                bookData.Fill(bookDataList); // Đổ dữ liệ vào dataset

                connection.Close();
            }

            return bookDataList;
        }

        // Hàm để insert sách vào database
        public bool InsertBook(string insertQuery, string bookID, string bookName, string bookAuthorName, string bookTranslatorName, DateTime bookPublishedDay, int bookRepublishedTime, int bookPrice, string bookType, string bookTitleCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookID;
                command.Parameters.Add("@BookName", SqlDbType.NVarChar, 100).Value = bookName;
                command.Parameters.Add("@BookAuthor", SqlDbType.NVarChar, 100).Value = bookAuthorName;
                command.Parameters.Add("@BookTranslator", SqlDbType.NVarChar, 50).Value = bookTranslatorName;
                command.Parameters.Add("@BookPublishDay", SqlDbType.Date).Value = bookPublishedDay;
                command.Parameters.Add("@BookRepublishedTime", SqlDbType.Int).Value = bookRepublishedTime;
                command.Parameters.Add("@BookPrice", SqlDbType.Int).Value = bookPrice;
                command.Parameters.Add("@BookType", SqlDbType.NVarChar, 100).Value = bookType;
                command.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                command.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        // Hàm để update thông tin sách
        public bool UpdateBook(string updateQuery, string bookID, string bookName, string bookAuthorName, string bookTranslatorName, DateTime bookPublishedDay, int bookRepublishedTime, int bookPrice, string bookType, string bookTitleCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookID;
                command.Parameters.Add("@BookName", SqlDbType.NVarChar, 100).Value = bookName;
                command.Parameters.Add("@BookAuthor", SqlDbType.NVarChar, 100).Value = bookAuthorName;
                command.Parameters.Add("@BookTranslator", SqlDbType.NVarChar, 50).Value = bookTranslatorName;
                command.Parameters.Add("@BookPublishDay", SqlDbType.Date).Value = bookPublishedDay;
                command.Parameters.Add("@BookRepublishedTime", SqlDbType.Int).Value = bookRepublishedTime;
                command.Parameters.Add("@BookPrice", SqlDbType.Int).Value = bookPrice;
                command.Parameters.Add("@BookType", SqlDbType.NVarChar, 100).Value = bookType;
                command.Parameters.Add("@BookTitleCode", SqlDbType.VarChar, 50).Value = bookTitleCode;

                command.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        List<string> bookTitleCodeList = new List<string>(); // Khai báo mảng để lưu trữ các mã tựa sách có trong database

        // Hàm để đọc dữ liệu các mã sách đang có trong database
        public void ReadBookTitleCodeFromDatabase()
        {
            string bookRepoQuery = "Select * from KHOSACH"; // Câu lệnh để select dữ liệu trong kho sách

            // Đọc dữ liệu từ database
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                // Nơi để lưu danh sách những cuốn sách được đọc lên từ database
                SqlCommand bookList = new SqlCommand(bookRepoQuery, connection);
                SqlDataReader bookRepoReader = bookList.ExecuteReader();

                while(bookRepoReader.Read())
                {
                    bookTitleCodeList.Add((string)bookRepoReader["MATUASACH"]);
                }

                connection.Close();
            }
        }

        bool checkBookTitleCode; // Biến để check xem mã tựa sách có tồn tại hay ko
        // Hàm để xét xem mã sách ng dùng sửa có trong danh sách hay không
        public bool CheckBookTitleCode(string bookTitleCode)
        {
            ReadBookTitleCodeFromDatabase(); //Gọi hàm đọc dữ liệu mã tựa sách từ database

            // Vòng lặp để check xem mã tựa sách đã tồn tại hay chưa
            for(int i = 0; i < bookTitleCodeList.Count; i++)
            {
                if(string.Equals(bookTitleCode.ToLower(), bookTitleCodeList[i].ToLower()) == true)
                {
                    checkBookTitleCode = true;
                    break;
                }

                else
                {
                    checkBookTitleCode = false;
                }
            }

            if(checkBookTitleCode == false)
            {
                return false;
            }

            else

            {
                return true;
            }
        }

        // Hàm để thực hiện thao tác xoá sách
        public bool DeleteBook(string deleteQuery ,string bookID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand delete = new SqlCommand(deleteQuery, connection);

                delete.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookID;

                delete.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }
    }
}
