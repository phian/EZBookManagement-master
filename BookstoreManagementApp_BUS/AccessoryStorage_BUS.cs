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
    public class AccessoryStorage_BUS
    {
        AccessoryStorage_DAL asDAL;
        public AccessoryStorage_BUS()
        {
            asDAL = new AccessoryStorage_DAL();
        }
        public DataTable gettAllAccessoryType() // Đổ datasource
        {
            return asDAL.getAllAccessoryType();
        }
        public bool deleteAccessoryType(AccessoryStorage KHOVANPHONGPHAM) // Xóa thông tin trong Database
        {
            return asDAL.deleteAccessoryStorage(KHOVANPHONGPHAM);
        }
        public bool InsertAccessoryType(AccessoryStorage KHOVANPHONGPHAM) // Nhập dữ liệu cho database
        {
            return asDAL.InsertAccesoryType(KHOVANPHONGPHAM);
        }
        public bool updateaCCESSORYType(AccessoryStorage KHOVANPHONGPHAM) // Cập nhật thông tin vào database
        {
            return asDAL.updateAccessoryType(KHOVANPHONGPHAM);
        }
        public DataTable getAllAcc_Invoice()
        {
            return asDAL.getAllAcc_Invoice();
        }
//HÀM KIỂM TRA XEM CÓ TỒN TẠI MÃ SÁCH TRONG DATABASE CHƯA
        public bool checkExistAccessoryType(AccessoryStorage KHOVANPHONGPHAM)
        {
            return asDAL.checkExistAccessory(KHOVANPHONGPHAM);
        }
        //HÀM CẬP NHẬT LẠI SỐ LƯỢNG KHO VĂN PHÒNG PHẨM NẾU NHẬP TRÙNG MÃ LOẠI SẢN PHẨM
        public bool updateNumberAccessoryStorage(InvoiceAccessory HOADONVPP)
        {
            return asDAL.updateNumberAccessoryStorage(HOADONVPP);
        }
        public DataTable searchByProductTypeID(AccessoryStorage KHOVANPHONGPHAM)
        {
            return asDAL.searchByProductTypeID(KHOVANPHONGPHAM);
        }
    }
}