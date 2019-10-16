using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class BookRepoManage_BUS
    {
        BookRepoManage_DAL bookRepoManage = new BookRepoManage_DAL(); // Khai báo đối tượng để tương tác với DAL của kho sách

        // Hàm để gọi hàm check mã tựa sách từ GUI
        public bool CheckBookTitleCode(string bookTitleCode)
        {
            return bookRepoManage.CheckBookTitleCode(bookTitleCode);
        }

        // Hàm để gọi hàm insert dữ liệu mới
        public bool InsertBookRepo(string insertBookRepoQuery, string bookTitleCode, int inventoryQuantity)
        {
            return bookRepoManage.InsertBookRepo(insertBookRepoQuery, bookTitleCode, inventoryQuantity);
        }

        // Hàm để thêm dữ liệu vào bang hoá đơn
        public bool InsertInvoiceInfo(string insertInvoiceQuery, string invoiceCode, string bookTitleCode, int newBookNumber, DateTime goodsReceiveDay, string shipmentCode, string goodsReceivePlace)
        {
            return bookRepoManage.InsertInvoiceInfo(insertInvoiceQuery, invoiceCode, bookTitleCode, newBookNumber, goodsReceiveDay, shipmentCode, goodsReceivePlace);
        }

        // Hàm để check xem mã hoá đơn ng dùng nhập đã tọn tại hay chưa
        public bool CheckInvoiceCode(string invoiceCode)
        {
            return bookRepoManage.CheckInvoiceCode(invoiceCode);
        }

        // Hàm để đếm lượng sách
        public int ReadBookTotalNumber(string bookTitleCode)
        {
            return bookRepoManage.ReadBookTotalNumber(bookTitleCode);
        }

        // Hàm để update lại dữ liệu mã tựa sách nếu ng dùng add 1 mã tựa sách đã tồn tại
        public bool UpdateBookRepoInfo(string updateBookRepoQuery, string bookTitleCode, int inventoryQuantity)
        {
            return bookRepoManage.UpdateBookRepoInfo(updateBookRepoQuery, bookTitleCode, inventoryQuantity);
        }

        // Hàm để đọc dữ liệu đang có trong kho sách
        public DataSet ReadBookRepoData(string bookRepoQuery)
        {
            return bookRepoManage.ReadBookRepoData(bookRepoQuery);
        }

        // Hàm để update dữ liệu khi ng dùng ko sửa số lượng mới
        public bool UpdateBookRepo(string updateQuery, string invoiceCode, string bookTitleCode, int newBookNumber, DateTime goodsReceiveDay, string shipmentCode, string goodsReceivePlace)
        {
            return bookRepoManage.UpdateBookRepo(updateQuery, invoiceCode, bookTitleCode, newBookNumber, goodsReceiveDay, shipmentCode, goodsReceivePlace);
        }

        // Hàm để update dữ liệu cho bảng kho sách nếu ng dùng có sửa số lượng mới
        public bool UpdateBookRepoNewBookNumberInfo(string updateBookRepoQuery, int newBookNumber, string bookTitleCode)
        {
            return bookRepoManage.UpdateBookRepoNewBookNumberInfo(updateBookRepoQuery, newBookNumber, bookTitleCode);
        }

        // Hàm để xoá hoá đơn
        public bool DeleteInvoiceInfo(string deleteInvoiceQuery, string invoiceCode)
        {
            return bookRepoManage.DeleteInvoiceInfo(deleteInvoiceQuery, invoiceCode);
        }

        // Hàm để đọc thông tin đang có trong kho sách dùng cho việc thống kê
        public DataSet ReadBookRepoInfoData(string bookRepoQuery)
        {
            return bookRepoManage.ReadBookRepoInfoData(bookRepoQuery);
        }

        // Hàm để đọc dữ liệu đang có trong kho sách để dùng cho việc xoá
        public DataSet ReadBookRepoDataFromDB(string bookRepoDataQuery)
        {
            return bookRepoManage.ReadBookRepoDataFromDB(bookRepoDataQuery);
        }

        // Hàm để xoá dữ liệu trong kho sách
        public bool DeleteBookRepoData(string deleteBookRepoDataQuery, string bookTitleCode)
        {
            return bookRepoManage.DeleteBookRepoData(deleteBookRepoDataQuery, bookTitleCode);
        }

        // Hàm để xoá tất cả sách thuộc một mã tựa sách bị xoá
        public bool DeleteAllBookBelongToABookTitleCode(string deleteAllBookQuery, string bookTitleCode)
        {
            return bookRepoManage.DeleteAllBookBelongToABookTitleCode(deleteAllBookQuery, bookTitleCode);
        }

        // Hàm để xoá các hoá đơn của 1 mã tựa sách khi mã tựa sách bị xoá
        public bool DeleteAllInvoiceBelongToABookTitleCode(string deleteAllInvoiceQuery, string bookTitleCode)
        {
            return bookRepoManage.DeleteAllInvoiceBelongToABookTitleCode(deleteAllInvoiceQuery, bookTitleCode);
        }
    }
}
