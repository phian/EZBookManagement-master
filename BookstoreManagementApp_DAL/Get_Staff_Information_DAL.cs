using BookstoreManagementApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BookstoreManagementApp_DAL
{
    public class Staff_info
    {
        //Hàm lấy thông tin toàn bộ các nhân viên từ cơ sở dữ liệu
        public DataSet Get_Staff_Info()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT * from STAFF";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        //Hàm thêm thông tin 1 nhân viên mới vào cơ sở dữ liệu
        public void Add_New_Staff_Info(string ID, string FULLNAME, string DOB, string LOCA, int SEX, string PHONE, float PAYRATE, int BASICRATE, int ALLOWENCE)
        {
            string Insert_into = "INSERT INTO STAFF VALUES (@ID, @FULLNAME, @DOB, @LOCA, @SEX, @PHONE, @PAYRATE, @BASICRATE, @ALLOWENCE)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                    cmdInsert.Parameters.Add("@LOCA", SqlDbType.NVarChar).Value = LOCA;
                    cmdInsert.Parameters.Add("@SEX", SqlDbType.Int).Value = SEX;
                    cmdInsert.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = PHONE;
                    cmdInsert.Parameters.Add("@PAYRATE", SqlDbType.Float).Value = PAYRATE;
                    cmdInsert.Parameters.Add("@BASICRATE", SqlDbType.Int).Value = BASICRATE;
                    cmdInsert.Parameters.Add("@ALLOWENCE", SqlDbType.Int).Value = ALLOWENCE;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thêm thông tin nhân viên, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm thay đổi thông tin 1 nhân viên trong cơ sở dữ liệu
        public void Update_Staff_Info(string ID, string FULLNAME, string DOB, string LOCA, int SEX, string PHONE, float PAYRATE, int BASICRATE, int ALLOWENCE)
        {
            string Update_set = "UPDATE STAFF SET FULLNAME=@FULLNAME, DOB=@DOB, LOCA=@LOCA, SEX=@SEX, PHONE=@PHONE, PAYRATE=@PAYRATE, BASICRATE=@BASICRATE, ALLOWENCE=@ALLOWENCE WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.SmallDateTime).Value = DOB;
                    cmdInsert.Parameters.Add("@LOCA", SqlDbType.NVarChar).Value = LOCA;
                    cmdInsert.Parameters.Add("@SEX", SqlDbType.Int).Value = SEX;
                    cmdInsert.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = PHONE;
                    cmdInsert.Parameters.Add("@PAYRATE", SqlDbType.Float).Value = PAYRATE;
                    cmdInsert.Parameters.Add("@BASICRATE", SqlDbType.Int).Value = BASICRATE;
                    cmdInsert.Parameters.Add("@ALLOWENCE", SqlDbType.Int).Value = ALLOWENCE;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thay đổi thông tin nhân viên, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm xoá thông tin 1 nhân viên khỏi cơ sở dữ liệu
        public void Delete_Staff_Info(string ID)
        {
            string Delete_from = "DELETE FROM STAFF WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            try
            {
                connection.Open();
                SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                cmdInsert.ExecuteNonQuery();
                connection.Close();
                    MessageBox.Show("Xoá thông tin nhân viên thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xoá nhân viên này, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
