using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class Account
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string username;
        public string UserName 
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int access_level;
        public int AccessLevel
        {
            get { return access_level; }
            set { access_level = value; }
        }
    }
}
