using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BookstoreManagementApp_BUS;
using BookstoreManagementApp_DAL;

using BookstoreManagementApp_DTO;

namespace BookstoreManagementApp_Final_
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi vẽ rắn lên hình thì sẽ không bị nháy
            Control_Pnl.Visible = false;
        }
        //Khởi tạo các userControl
        UserControl UC_AccessoryOffice = new UC_AccessoryOffice();
        UserControl UC_AccessoryStorage = new UC_AccessoryStorage();
        UserControl UC_BookManage = new UC_BookManage();
        UserControl UC_BookRepoManage = new UC_BookRepoManage();
        UserControl UC_Sale = new UC_SaleForm();
        UserControl UC_Report = new UC_RevenueReport();
        // Sự kiện khi người dùnng ấn nút log out tk
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            logouttime = DateTime.Now.ToString();
            if (LoginAccountForm.who == 0)
            {
                ManagerForm.EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_st_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                ManagerForm.EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");

            }
            else if (LoginAccountForm.who == 1)
            {
                ManagerForm.EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_st_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                ManagerForm.EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
            }
            LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất khi người dùng đăng xuất tk

            this.Dispose(); // Tắt form đang thao tác

            loginForm.Show(); // Xuất form đăng nhập
        }
        string logouttime;
        // Sự kiện khi ng dùng tắt form
        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                logouttime = DateTime.Now.ToString();
                if (LoginAccountForm.who == 0)
                {
                    ManagerForm.EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_st_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','0','" + data.user + "','')");
                    ManagerForm.EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");

                }
                else if (LoginAccountForm.who == 1)
                {
                    ManagerForm.EXECUTEDATAA("INSERT INTO STAFFLOG VALUES ('" + lb_st_id.Text + "','" + LoginAccountForm.logintime + "','" + logouttime + "','1','" + data.user + "','')");
                    ManagerForm.EXECUTEDATAA("UPDATE STAFFLOG SET WTIME = DATEDIFF(SECOND,STAFFLOG.LOGINTIME,STAFFLOG.LOGOUTTIME) WHERE STAFFLOG.LOGINTIME = '" + LoginAccountForm.logintime + "'");
                }
                LoginAccountForm loginForm = new LoginAccountForm(); // Khai báo form đăng nhập để xuất ra 

                loginForm.Show();

                return;
            }

            else
            {
                e.Cancel = true;
            }
        }
        //---------------------------------------Phần của nút chọn form bán hàng---------------------------------------------//

        // Sự kiện khi nhân viên ấn vào nút để mở form bán hàng của nhân viên
        private void SaleButton_Click(object sender, EventArgs e)
        {
            tb = 0;
            bh = 1;
            tk = 0;

            ManageButton.BackColor = Color.SteelBlue;
            ReportButton.BackColor = Color.SteelBlue;

            label1.Text = "BÁN HÀNG";
            panel3.Visible = false;
            Control_Pnl.Visible = true ;
            UC_AccessoryOffice.Hide();
            UC_Sale.Show();
            UC_AccessoryStorage.Hide();
            UC_BookManage.Hide();
            UC_BookRepoManage.Hide();
            UC_Report.Hide();
            //userControl_Chart.Hide();
            main_FlowPnl.Controls.Clear();
            main_FlowPnl.Controls.Add(UC_Sale);
        }


        //---------------------------------------Phần của nút chọn form để viết báo cáo doanh thu----------------------------//

        // Sự kiện khi người dùng ấn nút để chọn thao tác mở form nhập báo cáo doanh thu
        private void ReportButton_Click(object sender, EventArgs e)
        {
            tb = 0;
            bh = 0;
            tk = 1;


            ManageButton.BackColor = Color.SteelBlue;
            SaleButton.BackColor = Color.SteelBlue;
 
            label1.Text = "BÁO CÁO";
            panel3.Visible = false;
            Control_Pnl.Visible = true;
            UC_AccessoryOffice.Hide();
            UC_Sale.Hide();
            UC_AccessoryStorage.Hide();
            UC_BookManage.Hide();
            UC_BookRepoManage.Hide();
            UC_Report.Show();
            //userControl_Chart.Hide();
            main_FlowPnl.Controls.Clear();
            main_FlowPnl.Controls.Add(UC_Report);
        }
        public int tb = 0;
        public int bh = 0;
        public int tk = 0;
        private void ManageButton_Click(object sender, EventArgs e)
        {
            tb = 1;
            bh = 0;
            tk = 0;

            ReportButton.BackColor = Color.SteelBlue;
            SaleButton.BackColor = Color.SteelBlue;

            label1.Text = "QUẢN LÝ THIẾT BỊ";
            Control_Pnl.Visible = true;

            panel3.Visible = true;

            UC_AccessoryOffice.Hide();
            UC_Sale.Hide();
            UC_AccessoryStorage.Hide();
            UC_BookManage.Hide();
            UC_BookRepoManage.Hide();
            UC_Report.Hide();
        }

        public int vpp = 0;
        public int kvpp = 0;
        public int s = 0;
        public int ks = 0;


        private void AddStationaryButton_Click(object sender, EventArgs e)
        {
            vpp = 1;
            kvpp = 0;
            s = 0;
            ks = 0;

            AddStationaryRepoBut.BackColor = Color.LightBlue;
            BookAndStationaryButton.BackColor = Color.LightBlue;
            AddBookRepoBut.BackColor = Color.LightBlue;

            Control_Pnl.Visible = true;
            UC_AccessoryOffice.Show();
            UC_Sale.Hide();
            UC_AccessoryStorage.Hide();
            UC_BookManage.Hide();
            UC_BookRepoManage.Hide();
            UC_Report.Hide();
            main_FlowPnl.Controls.Clear();
            main_FlowPnl.Controls.Add(UC_AccessoryOffice);
        }

        private void AddStationaryRepoBut_Click(object sender, EventArgs e)
        {
            vpp = 0;
            kvpp = 1;
            s = 0;
            ks = 0;

            AddStationaryButton.BackColor = Color.LightBlue;
            BookAndStationaryButton.BackColor = Color.LightBlue;
            AddBookRepoBut.BackColor = Color.LightBlue;

            Control_Pnl.Visible = true;
            UC_AccessoryOffice.Hide();
            UC_Sale.Hide();
            UC_AccessoryStorage.Show();
            UC_BookManage.Hide();
            UC_BookRepoManage.Hide();
            UC_Report.Hide();
            main_FlowPnl.Controls.Clear();
            main_FlowPnl.Controls.Add(UC_AccessoryStorage);
        }

        private void BookAndStationaryButton_Click(object sender, EventArgs e)
        {
            vpp = 0;
            kvpp = 0;
            s = 1;
            ks = 0;

            AddStationaryButton.BackColor = Color.LightBlue;
            AddStationaryRepoBut.BackColor = Color.LightBlue;
            AddBookRepoBut.BackColor = Color.LightBlue;

            Control_Pnl.Visible = true;
            UC_AccessoryOffice.Hide();
            UC_Sale.Hide();
            UC_AccessoryStorage.Hide();
            UC_BookManage.Show();
            UC_BookRepoManage.Hide();
            UC_Report.Hide();
            main_FlowPnl.Controls.Clear();
            main_FlowPnl.Controls.Add(UC_BookManage);
        }

        private void AddBookRepoBut_Click(object sender, EventArgs e)
        {
            vpp = 0;
            kvpp = 0;
            ks = 1;
            s = 0;

            AddStationaryButton.BackColor = Color.LightBlue;
            AddStationaryRepoBut.BackColor = Color.LightBlue;
            BookAndStationaryButton.BackColor = Color.LightBlue;

            Control_Pnl.Visible = true;
            UC_AccessoryOffice.Hide();
            UC_Sale.Hide();
            UC_AccessoryStorage.Hide();
            UC_BookManage.Hide();
            UC_BookRepoManage.Show();
            UC_Report.Hide();
            main_FlowPnl.Controls.Clear();
            main_FlowPnl.Controls.Add(UC_BookRepoManage);
        }

        private void ManageButton_MouseEnter(object sender, EventArgs e)
        {
            ManageButton.BackColor = Color.SkyBlue;
        }

        private void ManageButton_MouseLeave(object sender, EventArgs e)
        {
            if (tb == 1)
            {
                ManageButton.BackColor = Color.SkyBlue;
            }
            else
            {
                ManageButton.BackColor = Color.SteelBlue;
            }
        }

        private void SaleButton_MouseEnter(object sender, EventArgs e)
        {
            SaleButton.BackColor = Color.SkyBlue;
        }

        private void SaleButton_MouseLeave(object sender, EventArgs e)
        {
            if (bh == 1)
            {
                SaleButton.BackColor = Color.SkyBlue;
            }
            else
            {
                SaleButton.BackColor = Color.SteelBlue;
            }
        }

        private void ReportButton_MouseEnter(object sender, EventArgs e)
        {
            ReportButton.BackColor = Color.SkyBlue;
        }

        private void ReportButton_MouseLeave(object sender, EventArgs e)
        {
            if (tk == 1)
            {
                ReportButton.BackColor = Color.SkyBlue;
            }
            else
            {
                ReportButton.BackColor = Color.SteelBlue;
            }
        }

        private void AddStationaryButton_MouseEnter(object sender, EventArgs e)
        {
            AddStationaryButton.BackColor = Color.SteelBlue;
        }

        private void AddStationaryButton_MouseLeave(object sender, EventArgs e)
        {
            if (vpp == 1)
            {
                AddStationaryButton.BackColor = Color.SteelBlue;
            }
            AddStationaryButton.BackColor = Color.LightBlue;
        }

        private void AddStationaryRepoBut_MouseEnter(object sender, EventArgs e)
        {
            AddStationaryRepoBut.BackColor = Color.SteelBlue;
        }

        private void AddStationaryRepoBut_MouseLeave(object sender, EventArgs e)
        {
            if (kvpp == 1)
            {
                AddStationaryRepoBut.BackColor = Color.SteelBlue;
            }
            AddStationaryRepoBut.BackColor = Color.LightBlue;
        }

        private void BookAndStationaryButton_MouseEnter(object sender, EventArgs e)
        {
            BookAndStationaryButton.BackColor = Color.SteelBlue;
        }

        private void BookAndStationaryButton_MouseLeave(object sender, EventArgs e)
        {
            if (s == 1)
            {
                BookAndStationaryButton.BackColor = Color.SteelBlue;
            }
            BookAndStationaryButton.BackColor = Color.LightBlue;
        }

        private void AddBookRepoBut_MouseEnter(object sender, EventArgs e)
        {
            AddBookRepoBut.BackColor = Color.SteelBlue;
        }

        private void AddBookRepoBut_MouseLeave(object sender, EventArgs e)
        {
            if (ks == 1)
            {
                AddBookRepoBut.BackColor = Color.SteelBlue;
            }
            AddBookRepoBut.BackColor = Color.LightBlue;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lb_st_fn.Text = ManagerForm.ReadDataa("SELECT STAFF.FULLNAME FROM STAFF JOIN PASSWORD ON STAFF.ID = PASSWORD.ID WHERE PASSWORD.USERNAME = '"+data.user+"'").ToString();
            lb_st_id.Text = ManagerForm.ReadDataa("SELECT ID FROM PASSWORD WHERE PASSWORD.USERNAME = '" + data.user + "'").ToString();

        }
    }
}
