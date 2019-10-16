using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class Staff_salary_BUS
    {
        Staff_salary_DAL temp = new Staff_salary_DAL();
        public DataSet Get()
        {
            return temp.Get();
        }
    }
}
