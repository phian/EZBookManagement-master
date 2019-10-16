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
    public class Staff_account_BUS
    {
        Staff_info temp = new Staff_info();

        public DataSet Get()
        {
            return temp.Get_Staff_Info();
        }
        public void Update(string ID, string FULLNAME, string DOB, string LOCA, int SEX, string PHONE, float PAYRATE, int BASICRATE, int ALLOWENCE)
        {
            temp.Update_Staff_Info(ID, FULLNAME, DOB, LOCA, SEX, PHONE, PAYRATE, BASICRATE, ALLOWENCE);
        }
        public void Delete(string ID)
        {
            temp.Delete_Staff_Info(ID);
        }
        public void Add(string ID, string FULLNAME, string DOB, string LOCA, int SEX, string PHONE, float PAYRATE, int BASICRATE, int ALLOWENCE)
        {
            temp.Add_New_Staff_Info(ID, FULLNAME, DOB, LOCA, SEX, PHONE, PAYRATE, BASICRATE, ALLOWENCE);
        }
    }
}
