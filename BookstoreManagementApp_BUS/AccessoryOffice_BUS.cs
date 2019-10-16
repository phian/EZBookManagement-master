using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagementApp_DTO;
namespace BookstoreManagementApp_BUS
{
    public class AccessoryOffice_BUS
    {
        AccessoryOffice_DAL acDAL;
        public AccessoryOffice_BUS()
        {
            acDAL = new AccessoryOffice_DAL();
        }
        public DataTable gettAllAccessory() // Đổ datasource
        {
            return acDAL.getAllAccessory();
        }
        public bool deleteAccessory(AccessoryOffice VANPHONGPHAM) // Xóa thông tin trong Database
        {
            return acDAL.deleteAccessory(VANPHONGPHAM);
        }
        public bool InsertAccessory(AccessoryOffice VANPHONGPHAM) // Nhập dữ liệu cho database
        {
            return acDAL.InsertAccesory(VANPHONGPHAM);
        }
        public bool updateaCCESSORY(AccessoryOffice VANPHONGPHAM) // Cập nhật thông tin vào database
        {
            return acDAL.updateAccessory(VANPHONGPHAM);
        }
        public bool deleteAccessoryOfficebyID(AccessoryOffice VANPHONGPHAM)
        {
            return acDAL.deleteAccessoryOfficebyID(VANPHONGPHAM);
        }
        public DataTable searchByProductID(AccessoryOffice VANPHONGPHAM)
        {
            return acDAL.searchByProductID(VANPHONGPHAM);
        }
    }
}
