using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class RevenueReportManage_BUS // Class để quản lý các tương tác từ UI trong việc lập báo cáo doanh thu
    {
        // Biến để gọi hàm lấy thông tin hoá đơn từ DAL
        RevenueReportManage_DAL revenueReportManage = new RevenueReportManage_DAL();

        // Hàm để lấy dữ liệu hoá đơn tương ứng từ database
        public DataSet GetSalesInvoiceByCategories(string getInvoiceQuery)
        {
            return revenueReportManage.GetSalesInvoiceByCategories(getInvoiceQuery);
        }

        // Hàm để check thông tin của nhân viên nhập vào là đúng hay sai
        public bool CheckStaffInfo(string staffName, string staffID)
        {
            return revenueReportManage.CheckStaffInfo(staffName, staffID);
        }
    }
}
