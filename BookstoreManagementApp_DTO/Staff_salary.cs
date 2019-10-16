using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class Staff_salary
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

        private int tongluong;
        public int TL
        {
            get { return tongluong; }
            set { tongluong = value; }
        }

    }
}
