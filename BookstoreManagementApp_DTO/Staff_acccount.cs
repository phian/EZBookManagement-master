using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class Staff_acccount
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string fullname;
        public string FULLNAME
        {
            get { return fullname; }
            set { fullname = value; }
        }

        private string date_of_birth;
        public string DOB
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }

        private string location;
        public string LOCA
        {
            get { return location; }
            set { location = value; }
        }

        private int sex;
        public int SEX
        {
            get { return sex; }
            set { sex = value; }
        }

        private string phone_number;
        public string PHONE
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        private int pay_rate;
        public int PAYRATE
        {
            get { return pay_rate; }
            set { pay_rate = value; }
        }

        private int basic_rate;
        public int BASICRATE
        {
            get { return basic_rate; }
            set { basic_rate = value; }
        }

        private int allowence;
        public int ALLOWENCE
        {
            get { return allowence; }
            set { allowence = value; }
        }
    }
}
