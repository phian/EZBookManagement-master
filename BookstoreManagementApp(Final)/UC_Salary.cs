using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreManagementApp_BUS;
using BookstoreManagementApp_DAL;
using System.Data.SqlClient;
using System.Globalization;

namespace BookstoreManagementApp_Final_
{
    public partial class UC_Salary : UserControl
    {
        public UC_Salary()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }
        Staff_salary_BUS staff = new Staff_salary_BUS();
        public string ID; //ID của nhân viên hiện đang được chọn
        public string FULLNAME;
        public int PAYRATE;
        public int BASICRATE;
        public int ALLOWENCE;
        public int TL;



        private void Set_varialbe_name()
        {
            FULLNAME = tb_slr_name.Text;
            PAYRATE = Convert.ToInt32(tb_slr_payrate);
            BASICRATE = Convert.ToInt32(tb_slr_basicrate.Text);
            ALLOWENCE = Convert.ToInt32(tb_slr_allowence.Text);
            TL = Convert.ToInt32(tb_slr_tl);
        }
        private void Load_Data_From_Database()
        {
            DataTable dt = ManagerForm.ReadData_slr("SELECT ID, MONTH, YEAR, TOTALTIME, BS, ADDS, SALARYLV, SLR FROM SALARY");
            if (dt != null)
            {
                dgv_slr.DataSource = dt;
            }
        }
        private void UC_Salary_Load(object sender, EventArgs e)
        {
            dgv_slr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_slr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load_Data_From_Database();
            dgv_slr.Columns[0].HeaderText = ("Mã nhân viên");
            dgv_slr.Columns[1].HeaderText = ("Tháng");
            dgv_slr.Columns[2].HeaderText = ("Năm");
            dgv_slr.Columns[3].HeaderText = ("Tổng giờ làm");
            dgv_slr.Columns[4].HeaderText = ("Lương cơ bản");
            dgv_slr.Columns[5].HeaderText = ("Phụ cấp");
            dgv_slr.Columns[6].HeaderText = ("Bậc lương");
            dgv_slr.Columns[7].HeaderText = ("Tổng lương");
        }

        private void dgv_slr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                tb_slr_id.Text = dgv_slr.Rows[numrow].Cells[0].Value.ToString();
                tb_slr_name.Text = ManagerForm.ReadDataa("SELECT STAFF.FULLNAME FROM STAFF WHERE STAFF.ID = '" + dgv_slr.Rows[numrow].Cells[0].Value.ToString() + "'").ToString();
                tb_slr_payrate.Text = dgv_slr.Rows[numrow].Cells[3].Value.ToString();
                tb_slr_allowence.Text = dgv_slr.Rows[numrow].Cells[5].Value.ToString();
                tb_slr_basicrate.Text = dgv_slr.Rows[numrow].Cells[4].Value.ToString();
                tb_slr_tl.Text = dgv_slr.Rows[numrow].Cells[6].Value.ToString();
            }
        }

        private void dgv_slr_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                tb_slr_id.Text = dgv_slr.Rows[numrow].Cells[0].Value.ToString();
                tb_slr_name.Text = ManagerForm.ReadDataa("SELECT STAFF.FULLNAME FROM STAFF WHERE STAFF.ID = '" + dgv_slr.Rows[numrow].Cells[0].Value.ToString() + "'").ToString();
                tb_slr_payrate.Text = dgv_slr.Rows[numrow].Cells[3].Value.ToString();
                tb_slr_allowence.Text = dgv_slr.Rows[numrow].Cells[5].Value.ToString();
                tb_slr_basicrate.Text = dgv_slr.Rows[numrow].Cells[4].Value.ToString();
                tb_slr_tl.Text = dgv_slr.Rows[numrow].Cells[6].Value.ToString();
            }
        }


        private void Calslr()
        {
            if (ManagerForm.EXECUTEDATA("INSERT INTO SALARY(ID, MONTH, YEAR, TOTALTIME, BS, ADDS, SALARYLV) SELECT STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), SUM(WTIME), STAFF.BASICRATE, STAFF.ALLOWENCE, STAFF.PAYRATE FROM STAFF, STAFFLOG WHERE MONTH(LOGINTIME) = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR(LOGINTIME) = '" + cbb_slr_y.SelectedItem.ToString() + "' AND STAFF.ID = STAFFLOG.ID GROUP BY STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), STAFF.BASICRATE, STAFF.ALLOWENCE, STAFF.PAYRATE"))
            {
                ManagerForm.EXECUTEDATAA("UPDATE SALARY SET SLR = [BS]*[TOTALTIME]*[SALARYLV]+[ADDS]");
                DataTable dt = ManagerForm.ReadData_slr("SELECT ID, MONTH, YEAR, TOTALTIME, BS, ADDS, SALARYLV, SLR FROM SALARY WHERE MONTH = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR = '" + cbb_slr_y.SelectedItem.ToString() + "'");
                if (dt != null)
                {
                    dgv_slr.Columns[0].HeaderText = ("Mã nhân viên");
                    dgv_slr.Columns[1].HeaderText = ("Tháng");
                    dgv_slr.Columns[2].HeaderText = ("Năm");
                    dgv_slr.Columns[3].HeaderText = ("Tổng giờ làm");
                    dgv_slr.Columns[4].HeaderText = ("Lương cơ bản");
                    dgv_slr.Columns[5].HeaderText = ("Phụ cấp");
                    dgv_slr.Columns[6].HeaderText = ("Bậc lương");
                    dgv_slr.Columns[7].HeaderText = ("Tổng lương");
                }
            }
            else
            {
                //ManagerForm.EXECUTEDATAA("UPDATE SALARY SET SLR = [BS]*[TOTALTIME]*[SALARYLV]+[ADDS]");
                DataTable dt = ManagerForm.ReadData_slr("SELECT ID, MONTH, YEAR, TOTALTIME, BS, ADDS, SALARYLV, SLR FROM SALARY WHERE MONTH = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR = '" + cbb_slr_y.SelectedItem.ToString() + "'");
                if (dt != null)
                {
                    dgv_slr.DataSource = dt;

                    dgv_slr.Columns[0].HeaderText = ("Mã nhân viên");
                    dgv_slr.Columns[1].HeaderText = ("Tháng");
                    dgv_slr.Columns[2].HeaderText = ("Năm");
                    dgv_slr.Columns[3].HeaderText = ("Tổng giờ làm");
                    dgv_slr.Columns[4].HeaderText = ("Lương cơ bản");
                    dgv_slr.Columns[5].HeaderText = ("Phụ cấp");
                    dgv_slr.Columns[6].HeaderText = ("Bậc lương");
                    dgv_slr.Columns[7].HeaderText = ("Tổng lương");
                }
            }

        }

        private void bt_slr_xem_Click(object sender, EventArgs e)
        {
            try
            {
                //textBox1.Text = "INSERT INTO SALARY(ID, MONTH, YEAR, TOTALTIME, BS, ADDS, SALARYLV) SELECT STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), SUM(WTIME), STAFF.BASICRATE, STAFF.ALLOWENCE, STAFF.PAYRATE FROM STAFF, STAFFLOG WHERE MONTH(LOGINTIME) = '" + cbb_slr_m.SelectedItem.ToString() + "' AND YEAR(LOGINTIME) = '" + cbb_slr_y.SelectedItem.ToString() + "' AND STAFF.ID = STAFFLOG.ID GROUP BY STAFFLOG.ID, MONTH(LOGINTIME), YEAR(LOGINTIME), STAFF.BASICRATE, STAFF.ALLOWENCE, STAFF.PAYRATE";
                Calslr();
            }
            catch
            {
                MessageBox.Show("Hãy chọn tháng và năm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_slr_name_Leave(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("vn-VN", false).TextInfo;
            tb_slr_name.Text = textInfo.ToTitleCase(tb_slr_name.Text.ToLower()); //Chuyển tất cả về chữ thường sau đó đổi kiểu chữ hoa chữ cái đầu tiên
        }
    }
}
