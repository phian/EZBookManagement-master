using BookstoreManagementApp_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_BUS
{
    public class CSVC_BUS
    {
        CSVC_DAL temp = new CSVC_DAL();
        public DataSet Get()
        {
            return temp.Get();
        }
        public void Add(string IDCSVC, string TENCSVC, string NGAYNHAP, int SL)
        {
            temp.Add(IDCSVC,TENCSVC, NGAYNHAP, SL);
        }
        public void Delete(string IDCSVC)
        {
            temp.Delete(IDCSVC);
        }
        public void Update(string IDCSVC, string TENCSVC, string NGAYNHAP, int SL)
        {
            temp.Update(IDCSVC, TENCSVC, NGAYNHAP, SL);
        }
    }
}
