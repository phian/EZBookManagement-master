using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class EmployeePassword
    {
        private string employeeUserName;

        public string EmployeeUserName
        {
            get { return employeeUserName; }
            set { employeeUserName = value; }
        }

        private string employeePassword;

        public string EmployeePass
        {
            get { return employeePassword; }
            set { employeePassword = value; }
        }

        private int accessLevel;

        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }
    }
}
