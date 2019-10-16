using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{ // Quản lý các thuộc tính của Văn phòng phẩm
   public class AccessoryOffice
    {
        public string MASANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public string MALOAISANPHAM { get; set; }
        public  decimal GIA { get; set; }
        public string DANHMUC { set; get; }
        public DateTime NGAYSANXUAT { get; set; }
        public DateTime HANSUDUNG { set; get; }
        public string NHASANXUAT { set; get; }
    }
}
