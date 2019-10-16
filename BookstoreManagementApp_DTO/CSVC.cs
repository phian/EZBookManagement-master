using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class CSVC
    {
        private string idcsvc;
        public string IDCSVC
        {
            get { return idcsvc; }
            set { idcsvc = value; }
        }

        private string tencsvc;
        public string TENCSVC
        {
            get { return tencsvc; }
            set { tencsvc = value; }
        }

        private string ngay_nhap;
        public string NGAYNHAP
        {
            get { return ngay_nhap; }
            set { ngay_nhap = value; }
        }

        private int so_luong;
        public int SL
        {
            get { return so_luong; }
            set { so_luong = value; }
        }
    }
}
