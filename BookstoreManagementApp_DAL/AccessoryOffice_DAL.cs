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
    public class AccessoryOffice_DAL
    {
        ConnectionString dc; // Tạo đối tượng dataconnection
        SqlDataAdapter da; // Tạo đối tượng dataAdapter
        SqlCommand cmd;   // Tạo đối tượng SqlCommand
        public AccessoryOffice_DAL()
        {
            dc = new ConnectionString();
        }
        //Đổ data từ SQL vào dataGridview
        public DataTable getAllAccessory()
        {
            string query = "SELECT * FROM VANPHONGPHAM"; // Câu lệnh thao tác lấy tất cả thông tin của bảng VĂN PHÒNG PHẨM từ database
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(query, con); // SQL adaprer chứa câu lệnh sql và chuỗi  tạo kết nối
            con.Open(); // Mở kết nối
            DataTable dt = new DataTable(); // Đối tượng DataTable dùng để chứa dữ liệu
            da.Fill(dt);    // Đổ datasource vào datatable 
            con.Close();// Đóng kết nối sau khi đổ data xong
            return dt; // Giá trị trả về datatable
        }
        //Hàm Insert dữ liệu vào Văn phòng phẩm
        public bool InsertAccesory(AccessoryOffice VANPHONGPHAM)
        {
            string query = "INSERT INTO VANPHONGPHAM (MASANPHAM, TENSANPHAM, MALOAISANPHAM, GIA, DANHMUC, NGAYSANXUAT, HANSUDUNG, NHASANXUAT) VALUES" +
                " (@masanpham, @tensanpham, @maloaisanpham, @gia, @danhmuc, @ngaysanxuat, @hansudung, @nhasanxuat)"; 
           SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 50).Value = VANPHONGPHAM.MASANPHAM;
                cmd.Parameters.Add("@tensanpham", SqlDbType.NVarChar, 20).Value = VANPHONGPHAM.TENSANPHAM;
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.NVarChar, 20).Value = VANPHONGPHAM.MALOAISANPHAM;
                cmd.Parameters.Add("@gia", SqlDbType.Money).Value = VANPHONGPHAM.GIA;
                cmd.Parameters.Add("@danhmuc", SqlDbType.NVarChar, 100).Value = VANPHONGPHAM.DANHMUC;
                cmd.Parameters.Add("@ngaysanxuat", SqlDbType.DateTime).Value = VANPHONGPHAM.NGAYSANXUAT;
                cmd.Parameters.Add("@hansudung", SqlDbType.DateTime).Value =VANPHONGPHAM.HANSUDUNG;
                cmd.Parameters.Add("@nhasanxuat", SqlDbType.NVarChar, 100).Value = VANPHONGPHAM.NHASANXUAT;
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
        // Hàm sửa Văn phòng phẩm
        public bool updateAccessory(AccessoryOffice VANPHONGPHAM)
        {
            string query = "UPDATE VANPHONGPHAM SET TENSANPHAM = @tensanpham, MALOAISANPHAM = @maloaisanpham, GIA = @gia, DANHMUC = @danhmuc, NGAYSANXUAT = @ngaysanxuat, HANSUDUNG = @hansudung, NHASANXUAT = hansudung WHERE MASANPHAM = @masanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 50).Value = VANPHONGPHAM.MASANPHAM;
                cmd.Parameters.Add("@tensanpham", SqlDbType.NVarChar, 50).Value = VANPHONGPHAM.TENSANPHAM;
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.NVarChar, 20).Value = VANPHONGPHAM.MALOAISANPHAM;
                cmd.Parameters.Add("@gia", SqlDbType.Money).Value = VANPHONGPHAM.GIA;
                cmd.Parameters.Add("@danhmuc", SqlDbType.NVarChar, 100).Value = VANPHONGPHAM.DANHMUC;
                cmd.Parameters.Add("@ngaysanxuat", SqlDbType.DateTime).Value = VANPHONGPHAM.NGAYSANXUAT;
                cmd.Parameters.Add("@hansudung", SqlDbType.DateTime).Value = VANPHONGPHAM.HANSUDUNG;
                cmd.Parameters.Add("@nhasanxuat", SqlDbType.NVarChar, 100).Value = VANPHONGPHAM.NHASANXUAT;
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
        //Hàm xóa văn phòng phẩm
        public bool deleteAccessory(AccessoryOffice VANPHONGPHAM)
        {
            string query = "DELETE VANPHONGPHAM WHERE MASANPHAM= @masanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 50).Value = VANPHONGPHAM.MASANPHAM;
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
        //HÀM XÓA VĂN PHÒNG PHẨM THEO MÃ LOẠI SẢN PHẨM
        public bool deleteAccessoryOfficebyID(AccessoryOffice VANPHONGPHAM)
        {
            string query = "DELETE VANPHONGPHAM WHERE MALOAISANPHAM= @maloaisanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = VANPHONGPHAM.MALOAISANPHAM;
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
        //Hàm tìm kiếm thông tin sản phẩm thoe gần đúng MÃ SẢN PHẨM 
        public DataTable searchByProductID(AccessoryOffice VANPHONGPHAM)
        {
            string query = "SELECT * FROM VANPHONGPHAM WHERE MASANPHAM LIKE  @masanpham";
            SqlConnection con = dc.GetConnect();
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@masanpham", SqlDbType.VarChar, 50).Value = VANPHONGPHAM.MASANPHAM+"%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
        }
        //public List <AccessoryOffice> selectByProductID (string masanpham)
        //{
        //    List<AccessoryOffice> list = new List<AccessoryOffice>();
        //    string query = string.Format("SELECT * FROM VANPHONGPHAM WHERE MASANPHAM LIKE'", masanpham);
        //    DataTable dt = 
        //    return list;
        //}
    }
}
