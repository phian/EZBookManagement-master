using BookstoreManagementApp_DAL;
using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class EmployeePassManage_BUS
    {
        Account_manage_DAL Account = new Account_manage_DAL(); // Đối tượng để thực thi các thao tác đối với GUI

        // Hàm gọi khi người dùng đăng nhập vào ứng dụng
        public int LoginAccount(string UserName, string Password)
        {
            return Account.LoginAccount(UserName, Password);
            
        }
        public DataSet Get()
        {
            return Account.Get();
        }
        public void ChangePassword(string ID, string USERNAME,string NEWPASS)
        {
            Account.ChangePassword(ID, USERNAME, NEWPASS);
        }
        public void CreateAccount(string ID, string USERNAME, string PASS, int ACCESSLEVEL)
        {
            Account.CreateAccount(ID, USERNAME, PASS, ACCESSLEVEL);
        }
        public void PromoteAccount(string ID, string USERNAME, int ACCESSLEVEL)
        {
            Account.PromoteAccount(ID, USERNAME, ACCESSLEVEL);
        }
        public void DeleteAccount(string ID)
        {
            Account.Delete(ID);
        }
    }
}
