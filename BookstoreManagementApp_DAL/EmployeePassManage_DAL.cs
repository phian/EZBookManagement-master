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
    public class Account_manage_DAL // Class để thực hiện những thao tác với tk của nhân viên
    {
        // List để lưu dữ liệu mật khẩu truy xuất từ database (xét xem nhân viên có nhập đúng mk đăng nhập hay không)
        List<Account> List_accounts = new List<Account>();

        // Hàm để lưu thông tin password của nhân viên lấy từ database
        public void Get_Account_Info() //Lấy thông tin tài khoản nhân viên từ database, thêm nó vào list "Account"
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) // khởi tạo kết nối đến database
            {
                connection.Open(); // Mở kết nối đến database

                string Select_all = "SELECT * from PASSWORD";

                SqlCommand sqlcmd = new SqlCommand(Select_all, connection); // Truy xuất dữ liệu từ database
                SqlDataReader Data_reader = sqlcmd.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

                while (Data_reader.Read())
                {
                    Account Staff = new Account(); // biến để lưu trữ các thông tin được đọc ra và đưa vào list

                    Staff.UserName = (string)Data_reader["USERNAME"]; // đọc dữ liệu đã truy xuất
                    Staff.Password = (string)Data_reader["PASS"];
                    Staff.AccessLevel = (int)Data_reader["ACCESSLEVEL"];

                    List_accounts.Add(Staff); // Lưu dữ liệu đã đọc vào list "Account"
                }

                connection.Close(); // Đóng kết nối đến database
            }
        }
        //Hàm lấy thông tin phục vụ chức năng "Quản lý tài khoản" 
        //UC_AccountList
        public DataSet Get()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT STAFF.ID, STAFF.FULLNAME, PASSWORD.USERNAME, PASSWORD.ACCESSLEVEL from PASSWORD, STAFF WHERE PASSWORD.ID=STAFF.ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        //Thay đổi mật khẩu trong bảng PASSWORD
        public void ChangePassword(string ID, string USERNAME,string NEWPASSWORD)
        {
            string Update_set = "UPDATE PASSWORD SET PASS=@NEWPASSWORD WHERE ID=@ID AND USERNAME=@USERNAME";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@NEWPASSWORD", SqlDbType.NVarChar).Value = NEWPASSWORD;
                    cmdInsert.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Thay đổi cấp bậc - admin/user
        public void PromoteAccount(string ID, string USERNAME, int ACCESSLEVEL)
        {
            string Update_set = "UPDATE PASSWORD SET ACCESSLEVEL=@ACCESSLEVEL WHERE ID=@ID AND USERNAME=@USERNAME";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
                    cmdInsert.Parameters.Add("@ACCESSLEVEL", SqlDbType.Int).Value = ACCESSLEVEL;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Hoàn thành!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Xoá tài khoản đăng nhập ứng dụng
        public void Delete(string ID)
        {
            string Delete_from = "DELETE FROM PASSWORD WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Đã xoá tài khoản thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void CreateAccount(string ID, string USERNAME, string PASS, int ACCESSLEVEL)
        {
            string Update_set = "INSERT INTO PASSWORD VALUES (@ID, @USERNAME, @PASS, @ACCESSLEVEL)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
                    cmdInsert.Parameters.Add("@PASS", SqlDbType.NVarChar).Value = PASS;
                    cmdInsert.Parameters.Add("@ACCESSLEVEL", SqlDbType.NVarChar).Value = ACCESSLEVEL;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Tạo tài khoản thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int LoginAccount(string UserName, string Password)
        {
            Get_Account_Info(); // Gọi hàm để add thông tin tk user vào list để xét đăng nhập
            //Vòng lặp để xét xem mật khẩu và user name đã dc nhập đúng hay chưa(xét từ đầu tới cuối)
            for (int i = 0; i < List_accounts.Count; i++)
            {
                // Nếu nhập đúng thì ẩn form nhập password và hiển thị form tiếp theo
                if (List_accounts[i].UserName == UserName && checkPass(Password, List_accounts[i].Password))
                {
                    //CheckUser = true;

                    // Xét xem phân quyền là admin hay nhân viên để trả về giá trị tương ứng và gọi form tương ứng
                    if (List_accounts[i].AccessLevel == 0)
                        return 0; // return 0 trong TH là nhân viên
                    else
                        return 1;
                }
            }

            return 2; // return 1 trong TH là quản lý
        }
        private bool checkPass(string Entered_password, string Saved_password)
        {
            try
            {
                return BCrypt.Net.BCrypt.EnhancedVerify(Entered_password, Saved_password);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
                  
        }
    }
}

