using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagementApp_DAL;
namespace BookstoreManagementApp_BUS
{
    public class AccessorySale_BUS
    {
        AccessorySale_DAL aSaleDAL = new AccessorySale_DAL();
        // Hàm để so sánh thông tin của mã sản phẩm ng dùng nhập vào đã tồn tại trong database hay chưa
        public bool CheckAccessoryID(string AccessoryID)
        {
            return aSaleDAL.CheckAccessoryID(AccessoryID);
        }

        // Hàm để check xem mã loại sản phẩm ng dùng nhập có tồn tại hay không
        public bool CheckAccessoryTypeID(string AccessoryTypeID)
        {
            return aSaleDAL.CheckAccessoryTypeID(AccessoryTypeID);
        }

        // Hàm để lấy giá của văn phòng phẩm cần bán
        public Decimal GetAccessoryPriceFromDatabase(string query, string AccessoryID)
        {
            return aSaleDAL.GetAccessoryPriceFromDatabase(query, AccessoryID);
        }

        // Hàm để check xem mã sản phẩm có khớp với mã loại sản phẩm hay không
        public bool CheckAccessoryIDReferencesTypeID(string AccessoryTypeID, string AccessoryID)
        {
            return aSaleDAL.CheckAccessoryIDReferencesTypeID(AccessoryTypeID, AccessoryID);
        }

        // Hàm để xoá văn phòng phẩm
        public bool DeleteSoldAccessory(List<string> AccessoryID)
        {
            return aSaleDAL.DeleteSoldAccessory(AccessoryID);
        }

        // Hàm để giảm số lượng trong kho văn phòng phẩm khi bán 
        public bool ReduceAccessoryTotalNumberInDB(List<string> AccessoryTypeID)
        {
            return aSaleDAL.ReduceAccessoryTotalnumberInDB(AccessoryTypeID);
        }
    }
}
