using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagementApp_DAL;
using BookstoreManagementApp_DTO;

namespace BookstoreManagementApp_BUS
{
    public class InvoiceAccessory_BUS
    {
        InvoiceAccessory_DAL IADal;
        public InvoiceAccessory_BUS()
        {
            IADal = new InvoiceAccessory_DAL();
        }
        public DataTable gettAllInvoiceAccessory() // Đổ datasource
        {
            return IADal.getAllInvoiceAccessory();
        }
        public bool deleteInvoiceAccessory(InvoiceAccessory HOADONVPP) //XÓA THÔNG TIN DATASOURCE
        {
            return IADal.deleteInvoiceAccessory(HOADONVPP);
        }
        public bool InsertInvocieAccessoryType(InvoiceAccessory HOADONVPP) // Nhập dữ liệu cho database
        {
            return IADal.InsertInvoiceAccessory(HOADONVPP);
        }
        public bool updatInvoiceAccessoryType(InvoiceAccessory HOADONVPP) // Cập nhật thông tin vào database
        {
            return IADal.updateInvoiceAccessory(HOADONVPP);
        }
        public bool deleteInvoicebyID(InvoiceAccessory HOADONVPP)
        {
            return IADal.deleteInvoicebyID(HOADONVPP);
        }
        public DataTable searchByInvoiceID (InvoiceAccessory HOADONVPP)
        {
            return IADal.searchByInvoiceID(HOADONVPP);
        }
    }
}
