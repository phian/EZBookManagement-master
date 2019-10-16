using BookstoreManagementApp_BUS;
using System;
using System.Drawing;
using System.Windows.Forms;
using BookstoreManagementApp_DAL;
using BookstoreManagementApp_DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookstoreManagementApp_Final_
{
    public class data
    {
        public static string user;
    }
    public partial class LoginAccountForm : Form
    {
        public static string logintime;
   
        public static int who;
        public LoginAccountForm()
        {
           
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi vẽ rắn lên hình thì sẽ không bị nháy

            // Khởi tạo màu để Textbox cùng màu với form
            UserNameTxb.BackColor = Color.FromArgb(242, 242, 242);
            PasswordTxb.BackColor = Color.FromArgb(242, 242, 242);

            UserNameTxb.Select(); // Focus đến ô đăng nhập user name
        }

        // Khai báo form để xét xem ng đăng nhập là nv hay quản lý để gọi form tương ứng
        EmployeeForm employeeForm = new EmployeeForm();
        ManagerForm managerForm = new ManagerForm();
        EmployeePassManage_BUS Employee = new EmployeePassManage_BUS(); // Biến để gọi các thao tác với sự kiện

        public SqlConnection NV_connectionString = new SqlConnection(ConnectionString.connectionString);

        private void OpenConnect() //Khởi tạo kết nối đến database
        {
            if (NV_connectionString.State == ConnectionState.Closed) //Sẽ được mở khi kết nối với database đang đóng 
            {
                NV_connectionString.Open(); //Hàm mở kết nối
            }
        }

        private void CloseConnect() //Đóng kết nối với database
        {
            if (NV_connectionString.State == ConnectionState.Open) //Sẽ được đóng khi kết nối với database đang mở 
            {
                NV_connectionString.Close(); //Hàm đóng kết nối
            }
        }

        

        public void EXECUTEDATAA(string cmd) //Hàm để Execute query với câu lệnh là biến chuỗi cmd
        {
            OpenConnect(); //Mở kết nối với database
            
                SqlCommand sc = new SqlCommand(cmd, NV_connectionString); // Khởi tạo biến sc để lưu giá trị của cmd và ConnectionString
                sc.ExecuteNonQuery(); //Execute query cmd
            
            CloseConnect(); //Đóng kết nối sau khi thực hiện hàm
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0)
            {
                logintime = DateTime.Now.ToString();
                who = 0;
                data.user = UserNameTxb.Text;

                this.Hide();

                employeeForm.Show();

            }

            // Nếu tk đăng nhập là quản lý
            else if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
            {
                logintime = DateTime.Now.ToString();
                who = 1;
                data.user = UserNameTxb.Text;
                this.Hide();
                managerForm.Show();

            }

            // Nếu tk đăng nhập là ko hợp lệ
            else
            {
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                UserNameTxb.Text = "";
                PasswordTxb.Text = "";

                UserNameTxb.Select(); // Focus lại vào ô nhập user name

                return;
            }
        }

        // Sự kiện đế bắt lệnh Enter (nếu ng dùng nhấn Enter thì ta xét username và password)
        private void UserNameTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Nếu ng đăng nhập là nhân viên
                if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0)
                {
                    logintime = DateTime.Now.ToString();
                    who = 0;
                    data.user = UserNameTxb.Text;
                    this.Hide();

                    employeeForm.Show();
                }

                // Nếu tk đăng nhập là quản lý
                else if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
                {
                    logintime = DateTime.Now.ToString();
                    who = 1;
                    data.user = UserNameTxb.Text;
                    this.Hide();

                    managerForm.Show();
                }

                // Nếu tk đăng nhập là ko hợp lệ
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                    UserNameTxb.Text = "";
                    PasswordTxb.Text = "";

                    UserNameTxb.Select(); // Focus lại vào ô nhập user name

                    return;
                }
            }
        }

        // Sự kiện đế bắt lệnh Enter (nếu ng dùng nhấn Enter thì ta xét username và password)
        private void PasswordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Nếu ng đăng nhập là nhân viên
                if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0)
                {
                    logintime = DateTime.Now.ToString();
                    who = 0;
                    data.user = UserNameTxb.Text;
                    this.Hide();
                    employeeForm.Show();
                }

                // Nếu tk đăng nhập là quản lý
                else if (Employee.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
                {
                    logintime = DateTime.Now.ToString();
                    who = 1;
                    data.user = UserNameTxb.Text;

                    this.Hide();

                    managerForm.Show();
                }

                // Nếu tk đăng nhập là ko hợp lệ
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                    UserNameTxb.Text = "";
                    PasswordTxb.Text = "";

                    UserNameTxb.Select(); // Focus lại vào ô nhập user name

                    return;
                }
            }
        }

        // Sự kiện nếu ng dùng tắt form đăng nhập và thoát ứng dụng
        private void LoginAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
