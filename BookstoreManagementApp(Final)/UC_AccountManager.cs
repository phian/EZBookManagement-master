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


namespace BookstoreManagementApp_Final_
{
    public partial class UC_AccountManager : UserControl
    {
        public UC_AccountManager()
        {
            InitializeComponent();
        }
        public string ID_Account;
        public string new_password;
        EmployeePassManage_BUS Account_List = new EmployeePassManage_BUS(); 
        private void UC_AccountList_Load(object sender, EventArgs e)
        {
            dgv_account_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Khi click chọn 1 cell thì cả Row sẽ được chọn
            dgv_account_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Chế độ giãn cách đều dữ liệu theo kích thước của DataGridView
            dgv_account_list.Columns[0].HeaderText = "ID";
            dgv_account_list.Columns[1].HeaderText = "Họ tên";
            dgv_account_list.Columns[2].HeaderText = "Tài khoản";
            dgv_account_list.Columns[3].HeaderText = "Cấp bậc";
            
            pn_change_pass.Hide();
            pn_crt_account.Hide();
            pn_promote.Hide();
            Load_Data_From_Database();
        }
       
        //CÁC HÀM THAO TÁC VỚI DỮ LIỆU TÀI KHOẢN TRÊN BẢNG PASSWORD
        private void Load_Data_From_Database()
        {
            dgv_account_list.DataSource = Account_List.Get().Tables[0];
        }
        //CÁC SỰ KIỆN XỬ LÝ BUTTON
        private void bt_change_password_Click(object sender, EventArgs e)
        {
            tb_ch_id.Text = ID_Account;
            pn_crt_account.Hide();
            pn_promote.Hide();
            pn_change_pass.Show();
        }
        //Xác nhận thay đổi mật khẩu
        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if (checkData_Change_Password())
            {
                ID_Account = tb_id.Text;
                new_password = BCrypt.Net.BCrypt.EnhancedHashPassword(tb_newpass.Text.ToString());
                Account_List.ChangePassword(ID_Account, tb_username2.Text, new_password);
                UC_AccountList_Load(sender, e);
            }
        }
        //Huỷ thay đổi mật khẩu
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_newpass.Text = "";
            tb_confirm_newpass.Text = "";
            tb_username2.Text = "";
            pn_change_pass.Hide();
            pn_crt_account.Hide();
            pn_promote.Hide();
            UC_AccountList_Load(sender, e);
        }
        //Tạo tài khoản mới
        private void bt_create_Click(object sender, EventArgs e)
        {
            pn_change_pass.Hide();
            pn_crt_account.Show();
            cb_crt_aceslevel.SelectedItem = "0";
        }
        private void bt_crt_new_Click(object sender, EventArgs e)
        {
            if (checkData_Crt_Account())
            {
                ID_Account = tb_crt_id.Text;
                new_password = BCrypt.Net.BCrypt.EnhancedHashPassword(tb_crt_password.Text.ToString());
                int temp = Convert.ToInt16(cb_crt_aceslevel.SelectedItem.ToString());
                Account_List.CreateAccount(ID_Account, tb_crt_username.Text, new_password, temp);
                UC_AccountList_Load(sender, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pn_change_pass.Hide();
            pn_crt_account.Hide();
            pn_promote.Hide();
            UC_AccountList_Load(sender, e);
        }
        //
        private void bt_cf_promote_Click(object sender, EventArgs e)
        {
            ID_Account = tb_pro_id.Text;
            int temp = Convert.ToInt16(tb_pro_aclvl.SelectedItem.ToString());
            Account_List.PromoteAccount(ID_Account, tb_username3.Text, temp);
            UC_AccountList_Load(sender, e);
        }

        private void bt_promote_Click(object sender, EventArgs e)
        {
            tb_pro_id.Text = ID_Account;
            pn_change_pass.Hide();
            pn_crt_account.Hide();
            pn_promote.Show();
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            pn_change_pass.Hide();
            pn_crt_account.Hide();
            pn_promote.Hide();
            UC_AccountList_Load(sender, e);
        }
        //Xoá tài khoản đang được chọn
        private void bt_delete_account_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa tài khoản này, dữ liệu có thể sẽ không được khôi phục",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                ID_Account = tb_id.Text;
                Account_List.DeleteAccount(ID_Account);
                UC_AccountList_Load(sender, e);
            }
        }
        //CÁC SỰ KIỆN XỬ LÝ DataGridView - dgv_account_list
        private void dgv_account_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID_Account = string.Copy(dgv_account_list.Rows[index].Cells["ID"].Value.ToString());
                tb_id.Text = dgv_account_list.Rows[index].Cells["ID"].Value.ToString();
                tb_name.Text = dgv_account_list.Rows[index].Cells["FULLNAME"].Value.ToString();
                tb_username.Text = dgv_account_list.Rows[index].Cells["USERNAME"].Value.ToString();
                tb_username2.Text = dgv_account_list.Rows[index].Cells["USERNAME"].Value.ToString();
                tb_username3.Text = dgv_account_list.Rows[index].Cells["USERNAME"].Value.ToString();
                tb_accesslevel.Text = dgv_account_list.Rows[index].Cells["ACCESSLEVEL"].Value.ToString();
                tb_username2.Text = tb_username.Text;
                if ("0" == dgv_account_list.Rows[index].Cells["ACCESSLEVEL"].Value.ToString())
                {
                    tb_accesslevel.Text = "Nhân viên";
                    
                }
                else if ("1" == dgv_account_list.Rows[index].Cells["ACCESSLEVEL"].Value.ToString())
                {
                    tb_accesslevel.Text = "Quản trị viên";
                }
            }
        }
        private void dgv_account_list_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID_Account = string.Copy(dgv_account_list.Rows[index].Cells["ID"].Value.ToString());
                tb_id.Text = dgv_account_list.Rows[index].Cells["ID"].Value.ToString();
                tb_username.Text = dgv_account_list.Rows[index].Cells["USERNAME"].Value.ToString();
                tb_name.Text = dgv_account_list.Rows[index].Cells["FULLNAME"].Value.ToString();
                tb_username2.Text = dgv_account_list.Rows[index].Cells["USERNAME"].Value.ToString();
                tb_username3.Text = dgv_account_list.Rows[index].Cells["USERNAME"].Value.ToString();
                tb_accesslevel.Text = dgv_account_list.Rows[index].Cells["ACCESSLEVEL"].Value.ToString();
                tb_username2.Text = tb_username.Text;
                if ("0" == dgv_account_list.Rows[index].Cells["ACCESSLEVEL"].Value.ToString())
                {
                    tb_accesslevel.Text = "Nhân viên";
                    tb_pro_aclvl.SelectedItem = "0";
                }
                else if ("1" == dgv_account_list.Rows[index].Cells["ACCESSLEVEL"].Value.ToString())
                {
                    tb_accesslevel.Text = "Quản trị viên";
                    tb_pro_aclvl.SelectedItem = "1";
                }
            }
        }
        private bool checkData_Change_Password()
        {
            if (string.IsNullOrEmpty(tb_newpass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_newpass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_confirm_newpass.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_confirm_newpass.Focus();
                return false;
            }
            if (tb_newpass.Text != tb_confirm_newpass.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_confirm_newpass.Focus();
                return false;
            }
            return true;
        }
        private bool checkData_Crt_Account()
        {
            if (string.IsNullOrEmpty(tb_crt_id.Text))
            {
                MessageBox.Show("Hãy nhập một ID hợp lệ - ID có trong danh sách nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_crt_id.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_crt_username.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_crt_username.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_crt_password.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_crt_password.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_crt_cf_pass.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_crt_cf_pass.Focus();
                return false;
            }
            if (tb_crt_password.Text != tb_crt_cf_pass.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_crt_cf_pass.Focus();
                return false;
            }
            return true;
        }
    }
}
