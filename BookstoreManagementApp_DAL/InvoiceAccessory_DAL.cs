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
    public class InvoiceAccessory_DAL
    {
        ConnectionString dc; // Tạo đối tượng dataconnection
        SqlDataAdapter da; // Tạo đối tượng dataAdapter
        SqlCommand cmd;   // Tạo đối tượng SqlCommand
        public InvoiceAccessory_DAL()
        {
            dc = new ConnectionString();
        }
        //Đổ data từ SQL vào dataGridview
        public DataTable getAllInvoiceAccessory()
        {
            string query = "SELECT * FROM HOADONVPP"; // Câu lệnh thao tác lấy tất cả thông tin của bảng KHO VĂN PHÒNG PHẨM từ database
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(query, con); // SQL adaprer chứa câu lệnh sql và chuỗi  tạo kết nối
            con.Open(); // Mở kết nối
            DataTable dt = new DataTable(); // Đối tượng DataTable dùng để chứa dữ liệu
            da.Fill(dt);    // Đổ datasource vào datatable 
            con.Close();// Đóng kết nối sau khi đổ data xong
            return dt; // Giá trị trả về datatable
        }
        //Hàm Insert dữ liệu vào hóa đơn nhập văn phòng phẩm
        public bool InsertInvoiceAccessory(InvoiceAccessory HOADONVPP)
        {
            string query = "INSERT INTO HOADONVPP (MAHOADON, MALOHANG, MALOAISANPHAM, SOLUONGMOI, NGAYNHAP, NHACUNGCAP ) VALUES" +
                " (@mahoadon, @malohang, @maloaisanpham, @soluongmoi, @ngaynhap, @nhacungcap)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@mahoadon", SqlDbType.VarChar, 50).Value = HOADONVPP.MAHOADON;
                cmd.Parameters.Add("@malohang", SqlDbType.NVarChar, 20).Value = HOADONVPP.MALOHANG;
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = HOADONVPP.MALOAISANPHAM;
                cmd.Parameters.Add("@soluongmoi", SqlDbType.Int).Value = HOADONVPP.SOLUONGMOI;
                cmd.Parameters.Add("@ngaynhap", SqlDbType.Date).Value = HOADONVPP.NGAYNHAP;
                cmd.Parameters.Add("@nhacungcap", SqlDbType.NVarChar).Value = HOADONVPP.NHACUNGCAP;
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
        public bool updateInvoiceAccessory(InvoiceAccessory HOADONVPP)
        {
            string query = "UPDATE HOADONVPP SET MALOHANG= @malohang, MALOAISANPHAM= @maloaisanpham, SOLUONGMOI= @soluongmoi, NGAYNHAP= @ngaynhap, NHACUNGCAP= @nhacungcap WHERE MAHOADON= @mahoadon";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@mahoadon", SqlDbType.VarChar, 50).Value = HOADONVPP.MAHOADON;
                cmd.Parameters.Add("@malohang", SqlDbType.NVarChar, 20).Value = HOADONVPP.MALOHANG;
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = HOADONVPP.MALOAISANPHAM;
                cmd.Parameters.Add("@soluongmoi", SqlDbType.Int).Value = HOADONVPP.SOLUONGMOI;
                cmd.Parameters.Add("@ngaynhap", SqlDbType.Date).Value = HOADONVPP.NGAYNHAP;
                cmd.Parameters.Add("@nhacungcap", SqlDbType.NVarChar).Value = HOADONVPP.NHACUNGCAP;
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
        // HÀM XÓA DỮ LIỆU KHO HÓA ĐƠN
        public bool deleteInvoiceAccessory(InvoiceAccessory HOADONVPP)
        {
            string query = "DELETE HOADONVPP WHERE MAHOADON= @mahoadon";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@mahoadon", SqlDbType.VarChar, 50).Value = HOADONVPP.MAHOADON;
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
        //HÀM XÓA HÓA ĐƠN NHẬP VÀO THEO MÃ LOẠI SẢN PHẨM
        public bool deleteInvoicebyID(InvoiceAccessory HOADONVPP)
        {
            string query = "DELETE HOADONVPP WHERE MALOAISANPHAM= @maloaisanpham";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@maloaisanpham", SqlDbType.VarChar, 20).Value = HOADONVPP.MALOAISANPHAM;
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
        //HÀM TÌM THÔNG TIN HÓA ĐƠN DỰA VÀO CHUỖI GẦN ĐÚNG SO VỚI MÃ HÓA ĐƠN NHẬP
        public DataTable searchByInvoiceID(InvoiceAccessory HOADONVPP)
        {
            string query = "SELECT HOADONVPP.MAHOADON, HOADONVPP.MALOAISANPHAM, HOADONVPP.SOLUONGMOI, HOADONVPP.NGAYNHAP, HOADONVPP.MALOHANG, HOADONVPP.NHACUNGCAP, KHOVANPHONGPHAM.SOLUONGTONKHO FROM KHOVANPHONGPHAM INNER JOIN HOADONVPP ON KHOVANPHONGPHAM.MALOAISANPHAM = HOADONVPP.MALOAISANPHAM WHERE HOADONVPP.MAHOADON LIKE @mahoadon";
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.Add("@mahoadon", SqlDbType.VarChar, 50).Value = HOADONVPP.MAHOADON + "%";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
