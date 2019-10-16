using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementApp_DAL
{
    public class CSVC_DAL
    {
        //Hàm lấy thông tin toàn bộ các cơ sở vật chất
        public DataSet Get()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT * FROM CSVC";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        //Hàm thêm thông tin 1 csvc mới vào cơ sở dữ liệu
        public void Add(string IDCSVC, string TENCSVC, string NGAYNHAP, int SL)
        {
            string Insert_into = "INSERT INTO CSVC VALUES (@IDCSVC, @TENCSVC, @NGAYNHAP, @SL)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@IDCSVC", SqlDbType.VarChar).Value = IDCSVC;
                    cmdInsert.Parameters.Add("@TENCSVC", SqlDbType.NVarChar).Value = TENCSVC;
                    cmdInsert.Parameters.Add("@NGAYNHAP", SqlDbType.Date).Value = NGAYNHAP;
                    cmdInsert.Parameters.Add("@SL", SqlDbType.Int).Value = SL;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thêm thông tin cơ sở vật chất, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm xoá thông tin 1 csvc
        public void Delete(string IDCSVC)
        {
            string Delete_from = "DELETE FROM CSVC WHERE IDCSVC=@IDCSVC";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@IDCSVC", SqlDbType.VarChar).Value = IDCSVC;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xoá thông tin cơ sở vật chất này, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //Hàm thay đổi thông tin 1 csvc trong cơ sở dữ liệu
        public void Update(string IDCSVC, string TENCSVC, string NGAYNHAP, int SL)
        {
            string Update_set = "UPDATE CSVC SET TENCSVC=@TENCSVC, NGAYNHAP=@NGAYNHAP, SL=@SL WHERE IDCSVC=@IDCSVC";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@IDCSVC", SqlDbType.VarChar).Value = IDCSVC;
                    cmdInsert.Parameters.Add("@TENCSVC", SqlDbType.NVarChar).Value = TENCSVC;
                    cmdInsert.Parameters.Add("@NGAYNHAP", SqlDbType.Date).Value = NGAYNHAP;
                    cmdInsert.Parameters.Add("@SL", SqlDbType.Int).Value = SL;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thay đổi thông tin cơ sở vật chất, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
