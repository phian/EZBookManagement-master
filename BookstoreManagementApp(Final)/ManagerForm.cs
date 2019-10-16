using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookstoreManagementApp_DAL;

namespace BookstoreManagementApp_Final_
{
    public partial class ManagerForm : Form
    {
        public int btnv = 0;
        public int btl = 0;
        public int btcs = 0;
        public int tk = 0;

        public ManagerForm()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi vẽ rắn lên hình thì sẽ không bị nháy
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        { 
            lb_mng_fn.Text = ReadDataa("SELECT STAFF.FULLNAME FROM STAFF JOIN PASSWORD ON STAFF.ID = PASSWORD.ID WHERE PASSWORD.USERNAME = '" + data.user + "'").ToString();
            lb_mng_id.Text = ReadDataa("SELECT ID FROM PASSWORD WHERE PASSWORD.USERNAME = '" + data.user + "'").ToString();
        }
        //Khởi tạo các User Control
        UserControl userControl_Staff = new UC_Staff();
        UserControl userControl_Salary = new UC_Salary();
        UserControl userControl_CSVC = new UC_CSVC();
        UserControl userControl_AccountList = new UC_AccountManager();
        //UserControl userControl_Chart = new UC_Chart();
        //Các hàm thao tác với User Control trên Panel chính - pn_main
        //Khi click vào Tab Nhân viên thì hiển thị User Control tương ứng
        private void bt_nv_Click(object sender, EventArgs e)
        {
            label3.Text = "QUẢN LÝ NHÂN VIÊN";
            btnv = 1;
            btl = 0;
            btcs = 0;
            tk = 0;
            bt_luong.BackColor = Color.SteelBlue;
            bt_csvc.BackColor = Color.SteelBlue;
            bt_tk.BackColor = Color.SteelBlue;
            userControl_Staff.Show(); //Hiển thị User Control UC_Staff
            //Ẩn các User Control còn lại
            userControl_Salary.Hide();
            userControl_CSVC.Hide();
            //Xoá sạch các controls đang nằm trong pn_main
            pn_main.Controls.Clear();
            //Thêm User Control UC_Staff vào pn_main
            pn_main.Controls.Add(userControl_Staff);
        }
        private void bt_luong_Click(object sender, EventArgs e)
        {
            label3.Text = "QUẢN LÝ LƯƠNG";

            btnv = 0;
            btl = 1;
            btcs = 0;
            tk = 0;

            bt_nv.BackColor = Color.SteelBlue;
            bt_csvc.BackColor = Color.SteelBlue;
            bt_tk.BackColor = Color.SteelBlue;

            userControl_Staff.Hide();
            userControl_Salary.Show();
            userControl_CSVC.Hide();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(userControl_Salary);
        }
        private void bt_csvc_Click(object sender, EventArgs e)
        {
            label3.Text = "QUẢN LÝ CƠ SỞ VẬT CHẤT";

            btnv = 0;
            btl = 0;
            btcs = 1;
            tk = 0;

            bt_nv.BackColor = Color.SteelBlue;
            bt_luong.BackColor = Color.SteelBlue;
            bt_tk.BackColor = Color.SteelBlue;

            userControl_Staff.Hide();
            userControl_Salary.Hide();
            userControl_CSVC.Show();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(userControl_CSVC);
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất khi người dùng đăng xuất tk
            logouttime = DateTime.Now.ToString();
            if (LoginAccountForm.who == 0)
            {
                EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_mng_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
            }
            else if (LoginAccountForm.who == 1)
            {
                EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_mng_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
            }
            this.Dispose(); // Tắt form đang thao tác
            loginForm.Show(); // Xuất form đăng nhập
        }
        public static DataTable ReadData_slr(string cmd)
        {
            OpenConnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, NV_connectionString);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            CloseConnect();
            return da;
        }

        public static object ReadDataa(string cmd)
        {
            OpenConnect();
            DataTable da = new DataTable();

            SqlCommand sc = new SqlCommand(cmd, NV_connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sda.Fill(da);
            object id = sc.ExecuteScalar();

            CloseConnect();
            return id;
        }
        public static SqlConnection NV_connectionString = new SqlConnection(ConnectionString.connectionString);

        public static void OpenConnect() //Khởi tạo kết nối đến database
        {
            if (NV_connectionString.State == ConnectionState.Closed) //Sẽ được mở khi kết nối với database đang đóng 
            {
                NV_connectionString.Open(); //Hàm mở kết nối
            }
        }

        public static void CloseConnect() //Đóng kết nối với database
        {
            if (NV_connectionString.State == ConnectionState.Open) //Sẽ được đóng khi kết nối với database đang mở 
            {
                NV_connectionString.Close(); //Hàm đóng kết nối
            }
        }

        DataSet GetdataSV() //DataSources của DataGridView
        {
            DataSet data = new DataSet();
            return data;
        }
        DataSet GetdataSV_slr() //DataSources của DataGridView
        {
            DataSet data = new DataSet();
            return data;
        }

        public static void EXECUTEDATAA(string cmd) //Hàm để Execute query với câu lệnh là biến chuỗi cmd
        {
            OpenConnect(); //Mở kết nối với database

            SqlCommand sc = new SqlCommand(cmd, NV_connectionString); // Khởi tạo biến sc để lưu giá trị của cmd và ConnectionString
            sc.ExecuteNonQuery(); //Execute query cmd

            CloseConnect(); //Đóng kết nối sau khi thực hiện hàm
        }

        public static Boolean EXECUTEDATA(string cmd) //Hàm để Execute query với câu lệnh là biến chuỗi cmd
        {
            OpenConnect(); //Mở kết nối với database
            Boolean check = false; //Giá trị đầu của biến check là false
            try
            {
                SqlCommand sc = new SqlCommand(cmd, NV_connectionString); // Khởi tạo biến sc để lưu giá trị của cmd và ConnectionString
                sc.ExecuteNonQuery(); //Execute query cmd
                check = true; //Sau khi execute thì trả về giá trị true
            }
            catch (Exception)
            {
                check = false;
            }
            CloseConnect(); //Đóng kết nối sau khi thực hiện hàm
            return check; //Trả về giá trị check của hàm Bool
        }
        
        public DataTable ReadData(string cmd)
        {
            OpenConnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, NV_connectionString);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            CloseConnect();
            return da;
        }
        
        public DataSet GetStaff_SLR()
        {
            DataSet data = new DataSet();
            string query = "SELECT FULLNAME, ID FROM STAFF ORDER BY ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        
        // Sự kiện khi ng dùng tắt form
        public static string logouttime;
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                logouttime = DateTime.Now.ToString();
                if (LoginAccountForm.who == 0)
                {
                    EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_mng_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                    EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
                }
                else if (LoginAccountForm.who == 1)
                {
                    EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_mng_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                    EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
                }
                LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất ra 
                loginForm.Show();
                return;
            }
            else
            {
                e.Cancel = true; //Huỷ đóng form
            }
        }

        private void bt_nv_MouseEnter(object sender, EventArgs e)
        {
            bt_nv.BackColor = Color.SkyBlue;
        }

        private void bt_luong_MouseEnter(object sender, EventArgs e)
        {
            bt_luong.BackColor = Color.SkyBlue;
        }

        private void bt_csvc_MouseEnter(object sender, EventArgs e)
        {
            bt_csvc.BackColor = Color.SkyBlue;
        }

        private void bt_nv_MouseLeave(object sender, EventArgs e)
        {
            if (btnv == 1)
            {
                bt_nv.BackColor = Color.SkyBlue;
            }
            else
            {
                bt_nv.BackColor = Color.SteelBlue;
            }
        }

        private void bt_luong_MouseLeave(object sender, EventArgs e)
        {
            if (btl == 1)
            {
                bt_luong.BackColor = Color.SkyBlue;
            }
            else
            {
                bt_luong.BackColor = Color.SteelBlue;
            }
        }

        private void bt_csvc_MouseLeave(object sender, EventArgs e)
        {
            if (btcs == 1)
            {
                bt_csvc.BackColor = Color.SkyBlue;
            }
            else
            {
                bt_csvc.BackColor = Color.SteelBlue;
            }
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            label3.Text = "QUẢN LÝ TÀI KHOẢN NHÂN VIÊN";

            btnv = 0;
            btl = 0;
            btcs = 0;
            tk = 1;

            bt_luong.BackColor = Color.SteelBlue;
            bt_csvc.BackColor = Color.SteelBlue;
            bt_nv.BackColor = Color.SteelBlue;

            userControl_Staff.Hide();
            userControl_Salary.Hide();
            userControl_CSVC.Hide();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(userControl_AccountList);
        }

        private void bt_tk_MouseEnter(object sender, EventArgs e)
        {
            bt_tk.BackColor = Color.SkyBlue;
        }

        private void bt_tk_MouseLeave(object sender, EventArgs e)
        {
            if (tk == 1)
            {
                bt_tk.BackColor = Color.SkyBlue;
            }
            else
            {
                bt_tk.BackColor = Color.SteelBlue;
            }
        }
    }

}
