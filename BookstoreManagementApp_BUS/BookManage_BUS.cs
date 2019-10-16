using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class BookManage_BUS // Lớp để tương tác với giao diện khi nhập sách
    {
        BookManage_DAL bookManage = new BookManage_DAL(); // Khai báo đối tượng thuộc lớp DAL để tương tác với database khi có tương tác từ BUS

        public bool CheckBookID(string BookID)
        {
            return bookManage.CheckBookID(BookID);
        }

        // Hàm để đọc dữ liệu sách đang có trong database
        public DataSet ReadBookFromDatabase()
        {
            return bookManage.ReadBookFromDatabase();
        }

        // Hàm để tương tác với giao diện phần nhập sách vào database
        public bool InsertBook(string insertQuery, string bookID, string bookName, string bookAuthorName, string bookTranslatorName, DateTime bookPublishedDay, int bookRepublishedTime, int bookPrice, string bookType, string bookTitleCode)
        {
            return bookManage.InsertBook(insertQuery ,bookID, bookName, bookAuthorName, bookTranslatorName, bookPublishedDay, bookRepublishedTime, bookPrice, bookType, bookTitleCode);
        }

        // Hàm để thêm sách vào database
        public bool UpdateBook(string updateQuery, string bookID, string bookName, string bookAuthorName, string bookTranslatorName, DateTime bookPublishedDay, int bookRepublishedTime, int bookPrice, string bookType, string bookTitleCode)
        {
            return bookManage.UpdateBook(updateQuery, bookID, bookName, bookAuthorName, bookTranslatorName, bookPublishedDay, bookRepublishedTime, bookPrice, bookType, bookTitleCode);
        }

        // Hàm để xét xem mã tựa sách ng dùng sửa có trong database hay ko
        public bool CheckBookTitleCode(string bookTitleCode)
        {
            return bookManage.CheckBookTitleCode(bookTitleCode);
        }

        // Hàm để gọi thao tác xoá sách
        public bool DeleteBook(string deleteQuery, string bookID)
        {
            return bookManage.DeleteBook(deleteQuery, bookID);
        }
    }
}
