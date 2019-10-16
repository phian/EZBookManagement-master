using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class BookSaleManage_BUS
    {
        private BookSaleManage_DAL bookSaleManage = new BookSaleManage_DAL();

        // Hàm để so sánh thông tin của mã sách ng dùng nhập vào đã tồn tại trong database hay chưa
        public bool CheckBookCode(string bookCode)
        {
            return bookSaleManage.CheckBookCode(bookCode);
        }

        // Hàm để check xem mã tựa sách ng dùng nhập có tồn tại hay không
        public bool CheckBookTitleCode(string bookTitleCode)
        {
            return bookSaleManage.CheckBookTitleCode(bookTitleCode);
        }

        // Hàm để lấy giá của quyển sách cần bán
        public int GetBookPriceFromDatabase(string bookQuery, string bookCode)
        {
            return bookSaleManage.GetBookPriceFromDatabase(bookQuery, bookCode);
        }

        // Hàm để check xem mã tựa sách có khớp với mã sách hay không
        public bool CheckBookTitleCodeReferenceWithBookCode(string bookTitleCode, string bookCode)
        {
            return bookSaleManage.CheckBookTitleCodeReferenceWithBookCode(bookTitleCode, bookCode);
        }

        // Hàm để xoá những cuốn sách đã bán
        public bool DeleteSoldBook(List<string> bookCode)
        {
            return bookSaleManage.DeleteSoldBook(bookCode);
        }

        // Hàm để giảm số lượng trong kho sách khi sách đã dc bán
        public bool ReduceBookTotalNumberInDB(List<string> bookTitleCodeList)
        {
            return bookSaleManage.ReduceBookTotalNumberInDB(bookTitleCodeList);
        }

        // Phần thêm thông tin vào bảng hoá đơn và CTHD

        // Hàm để insert dữ liệu vào table hoá đơn bán hàng
        public bool AddNewInvoiceToDB(string insertNewInvoiceQuery, string invoiceCode, int amountCusMustPay, int excessMoney, DateTime dateOfInvoicing)
        {
            return bookSaleManage.AddNewInvoiceToDB(insertNewInvoiceQuery, invoiceCode, amountCusMustPay, excessMoney, dateOfInvoicing);
        }

        // Hàm để thếm 1 chi tiết hoá đơn mới
        public bool AddNewInvoiceDetailsToDB(string insertNewInvoiceDetailsQuery, string invoiceCode, string booksCode)
        {
            return bookSaleManage.AddNewInvoiceDetailsToDB(insertNewInvoiceDetailsQuery, invoiceCode, booksCode);
        }

        // Hàm để đếm số lượng hoá đơn đang có trong bảng CTHD
        public int CountInvoiceDetailsNumnber(string countInvoiceQuery)
        {
            return bookSaleManage.CountInvoiceDetailsNumnber(countInvoiceQuery);
        }

        // Hàm để đếm số lượng hoá đơn đang có trong database
        public int CountInvoiceData(string countInvoiceQuery)
        {
            return bookSaleManage.CountInvoiceData(countInvoiceQuery);
        }
    }
}
