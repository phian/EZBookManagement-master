using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreManagementApp_DTO;
namespace BookstoreManagementApp_DAL
{
  public  class AccessoryStorage_DAL
    {
        ConnectionString dc; // Tạo đối tượng dataconnection
        SqlDataAdapter da; // Tạo đối tượng dataAdapter
        SqlCommand cmd;   // Tạo đối tượng SqlCommand
        List<string> existAccessoryType = new List<string>();
        public AccessoryStorage_DAL()
        {
            dc = new ConnectionString();
        }
        //Đổ data từ SQL vào dataGridview
        public DataTable getAllAccessoryType()
        {
            string query = "SELECT * FROM KHOVANPHONGPHAM"; // Câu lệnh thao tác lấy tất cả thông tin của bảng KHO VĂN PHÒNG PHẨM từ database
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(query, con); // SQL adaprer chứa câu lệnh sql và chuỗi  tạo kết nối
            con.Open(); // Mở kết nối
            DataTable dt = new DataTable(); // Đối tượng DataTable dùng để chứa dữ liệu
            da.Fill(dt);    // Đổ datasource vào datatable 
            con.Close();// Đóng kết nối sau khi đổ data xong
            return dt; // Giá trị trả về datatable
        }
        //Hàm Insert dữ liệu vào KHO Văn phòng phẩm
        public bool InsertAccesoryType(AccessoryStorage KHOVANPHONGPHAM)
        {
            string query = "INSERT INTO KHOVANPHONGPHAM (MALOAISANPHAM, SOLUONGTONKHO) VALUES" +
                " (@maloaisanpham, @soluongtonkho)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = KHOVANPHONGPHAM.MALOAISANPHAM;
                cmd.Parameters.Add("@soluongtonkho", SqlDbType.Int).Value = KHOVANPHONGPHAM.SOLUONGTONKHO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi trong quá trình, mời kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // HÀM CHỈNH SỬA DỮ LIỆU KHO VĂN PHÒNG PHẨM
        public bool updateAccessoryType(AccessoryStorage KHOVANPHONGPHAM)
        {
            string query = "UPDATE KHOVANPHONGPHAM SET SOLUONGTONKHO= @soluongtonkho WHERE MALOAISANPHAM= @maloaisanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = KHOVANPHONGPHAM.MALOAISANPHAM;
                cmd.Parameters.Add("@soluongtonkho", SqlDbType.Int).Value = KHOVANPHONGPHAM.SOLUONGTONKHO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi trong quá trình, mời kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //HÀM JOIN 2 BẢNG KHO VĂN PHÒNG PHẨM VÀ HÓA ĐƠN
        public DataTable getAllAcc_Invoice()
        {
            string query = "SELECT HOADONVPP.MAHOADON, HOADONVPP.MALOAISANPHAM, HOADONVPP.SOLUONGMOI, HOADONVPP.NGAYNHAP, HOADONVPP.MALOHANG, HOADONVPP.NHACUNGCAP, KHOVANPHONGPHAM.SOLUONGTONKHO FROM KHOVANPHONGPHAM INNER JOIN HOADONVPP ON KHOVANPHONGPHAM.MALOAISANPHAM = HOADONVPP.MALOAISANPHAM"; // Câu lệnh thao tác lấy tất cả thông tin củ 2 BẢNG KHO VĂN PHÒNG PHẨM VÀ HÓA ĐƠN
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(query, con); // SQL adaprer chứa câu lệnh sql và chuỗi  tạo kết nối
            con.Open(); // Mở kết nối
            DataTable dt = new DataTable(); // Đối tượng DataTable dùng để chứa dữ liệu
            da.Fill(dt);    // Đổ datasource vào datatable 
            con.Close();// Đóng kết nối sau khi đổ data xong
            return dt; // Giá trị trả về datatable
        }
        //Hàm đọc các mã trong kho văn phòng phẩm và add vào list
        public void addAccesoryTypeList()
        {
            string query = "Select * from KHOVANPHONGPHAM";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand Cmd = new SqlCommand(query, connection); // Đọc tất cả dữ liệu đang có trong kho sách
                SqlDataReader da = Cmd.ExecuteReader();

                while (da.Read())
                {
                    existAccessoryType.Add((string)da["MALOAISANPHAM"]); // Add các mã tựa sách đang có vào list
                }

                connection.Close();
            }
        }
        //HÀM KIỂM TRA XEM MÃ LOẠI SẢN PHẨM ĐÃ NHẬP VÀO HAY CHƯA
        public bool checkExistAccessory(AccessoryStorage KHOVANPHONGPHAM)
        {
            addAccesoryTypeList(); // Gọi hàm để đọc dữ liệu từ database

            // Vòng lặp để ktr các mã sách đã tồn tại có trùng với mã sách mới thêm vào hay ko
            for (int i = 0; i < existAccessoryType.Count; i++)
            {
                if (KHOVANPHONGPHAM.MALOAISANPHAM.ToLower() == existAccessoryType[i].ToLower())
                {
                    return true;
                }
            }

            return false;
        }
        //HÀM UPDATE SỐ LƯỢNG MÃ LOẠI SẢN PHẨM 
        public bool updateNumberAccessoryStorage(InvoiceAccessory HOADONVPP)
        {
            string query = "UPDATE KHOVANPHONGPHAM SET SOLUONGTONKHO= SOLUONGTONKHO + @soluongmoi WHERE MALOAISANPHAM= @maloaisanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value =HOADONVPP.MALOAISANPHAM;
                cmd.Parameters.Add("@soluongmoi", SqlDbType.Int).Value = HOADONVPP.SOLUONGMOI;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi trong quá trình, mời kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        } 
        // HÀM XÓA DỮ LIỆU KHO VĂN PHÒNG PHẨM
        public bool deleteAccessoryStorage(AccessoryStorage KHOVANPHONGPHAM)
        {
            string query = "DELETE KHOVANPHONGPHAM WHERE MALOAISANPHAM= @maloaisanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = KHOVANPHONGPHAM.MALOAISANPHAM;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi trong quá trình, mời kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //HÀM TÌM  THÔNG TIN SẢN PHẨM DỰA VÀO CHUỖI GẦN ĐÚNG CỦA MÃ SẢN PHẨM  
        public DataTable searchByProductTypeID(AccessoryStorage KHOVANPHONGPHAM)
        {
            string query = "SELECT HOADONVPP.MAHOADON, HOADONVPP.MALOAISANPHAM, HOADONVPP.SOLUONGMOI, HOADONVPP.NGAYNHAP, HOADONVPP.MALOHANG, HOADONVPP.NHACUNGCAP, KHOVANPHONGPHAM.SOLUONGTONKHO FROM KHOVANPHONGPHAM INNER JOIN HOADONVPP ON KHOVANPHONGPHAM.MALOAISANPHAM = HOADONVPP.MALOAISANPHAM WHERE KHOVANPHONGPHAM.MALOAISANPHAM LIKE @maloaisanpham";
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 50).Value = KHOVANPHONGPHAM.MALOAISANPHAM + "%";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
