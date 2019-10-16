using System;
using System.Globalization;
using System.Windows.Forms;
using BookstoreManagementApp_BUS;

namespace BookstoreManagementApp_Final_
{
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); 
        }
        //Init
        Staff_account_BUS account = new Staff_account_BUS();
        public string ID; //ID của nhân viên hiện đang được chọn
        public string FULLNAME; //Tên đầy đủ
        public string DOB; //Ngày sinh
        public string LOCA; //Địa chỉ
        public int SEX; //Giới tính 0 - Nam, 1 - Nữ
        public string PHONE; //Số điện thoại
        public float PAYRATE; //Bậc lương
        public int BASICRATE; //Lương cơ bản
        public int ALLOWENCE; //Phụ cấp
        //Đặt giá trị cho các biến tương ứng với giá trị lấy từ TextBox
        private bool Set_varialbe_name()
        {
            if(checkData())
            {
                FULLNAME = tb_name.Text.ToString();
                DOB = dtp.Text;
                LOCA = tb_location.Text;
                if (rb_male.Checked == true) { SEX = 0; }
                else { SEX = 1; }
                PHONE = tb_phone.Text;
                PAYRATE = float.Parse(tb_bl.Text.ToString());
                BASICRATE = Convert.ToInt32(tb_basicrate.Text);
                ALLOWENCE = Convert.ToInt32(tb_allowence.Text);
                return true;
            }
            return false;
        }
        
        private void UC_Staff_Load(object sender, EventArgs e)
        {
            dgv_st.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Khi click chọn 1 cell thì cả Row sẽ được chọn
            dgv_st.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Chế độ giãn cách đều dữ liệu theo kích thước của DataGridView
            Load_Data_From_Database();
            //Đặt tên các cột trong DataGridView - dgv_st
            dgv_st.Columns[0].HeaderText = "ID";
            dgv_st.Columns[1].HeaderText = "Họ & tên";
            dgv_st.Columns[2].HeaderText = "Ngày sinh";
            dgv_st.Columns[3].HeaderText = "Địa chỉ";
            dgv_st.Columns[4].HeaderText = "Giới tính";
            dgv_st.Columns[5].HeaderText = "SĐT";
            dgv_st.Columns[6].HeaderText = "Bậc lương";
            dgv_st.Columns[7].HeaderText = "LCB";
            dgv_st.Columns[8].HeaderText = "Phụ cấp";
            dgv_st.ReadOnly = true; //Không cho phép sửa nội dung trực tiếp trên DataGridView
            bt_save_new_staff.Visible = false;
            bt_save_edited_staff.Visible = false;
            bt_cancel.Visible = false;
        }

        //CÁC HÀM THAO TÁC VỚI DỮ LIỆU NHÂN VIÊN TRÊN BẢNG STAFF
        private void Load_Data_From_Database()
        {
            dgv_st.DataSource = account.Get().Tables[0];
        }
        //Hàm thêm thông tin nhân viên vào CSDL
        public void AddData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {
            account.Add(ID, FULLNAME, DOB, LOCA, SEX, PHONE, PAYRATE, BASICRATE, ALLOWENCE);
        }
        //Hàm thay đổi thông tin nhân viên trong CSDL
        public void EditData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {
            account.Update(ID, FULLNAME, DOB, LOCA, SEX, PHONE, PAYRATE, BASICRATE, ALLOWENCE);
        }
        //Hàm xoá thông tin nhân viên trong CSDL
        public void DeleteData(object sender, EventArgs e)
        {
            DialogResult DelData = MessageBox.Show("Bạn có muốn xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.YesNo); //Hiện thông báo xác nhận xóa
            if (DelData == DialogResult.Yes) //nếu chọn yes thì sẽ execute lệnh bên dưới để xóa
            {
                account.Delete(ID);
            }
        }

        //CÁC SỰ KIỆN XỬ LÝ BUTTON
        //Thêm nhân viên mới
        private void bt_add_staff_Click(object sender, EventArgs e)
        {
            //Xoá nội dung đang hiển thị trên các textbox để người dùng nhập dữ liệu mới
            tb_id.Text = "";
            tb_name.Text = "";
            tb_location.Text = "";
            tb_phone.Text = "";
            tb_bl.Text = "";
            tb_basicrate.Text = "";
            tb_allowence.Text = "";
            dtp.Text = "";
            rb_male.Checked = true;
            //Hiển thị nút Lưu, huỷ
            bt_save_new_staff.Visible = true;
            bt_cancel.Visible = true;
            //Sau khi chọn Thêm thì ẩn các nút chức năng Thêm, Sửa, Xoá
            bt_add_staff.Visible = false;
            bt_remove_staff.Visible = false;
            bt_edit_staff.Visible = false;
            bt_save_edited_staff.Visible = false;
        }
        //Lưu thông tin nhân viên mới
        private void bt_save_new_staff_Click(object sender, EventArgs e)
        {
            if(Set_varialbe_name())
            {
                //Gọi hàm khởi tạo giá trị các biến
                ID = tb_id.Text;
                Set_varialbe_name();
                AddData(sender, e);
                //Gọi sự kiện nút Huỷ - Hiển thị lại các nút chức năng ban đầu
                bt_cancel_Click(sender, e);
                //Sau khi thêm dữ liệu mới vào database thì cập nhật dữ liệu mới lên datagridview
                UC_Staff_Load(sender, e);
            }
        }
        //Xoá thông tin nhân viên
        private void bt_remove_staff_Click(object sender, EventArgs e)
        {
            DeleteData(sender, e);
            bt_cancel_Click(sender, e);
            UC_Staff_Load(sender, e);
        }
        //Sửa thông tin nhân viên
        private void bt_edit_staff_Click(object sender, EventArgs e)
        {
            //Không cho phép người dùng sửa ID
            tb_id.Enabled = false;
            //Sau khi chọn chức năng Sửa thì ẩn các nút chức năng Thêm, Sửa, Xoá
            bt_edit_staff.Visible = false;
            bt_remove_staff.Visible = false;
            bt_add_staff.Visible = false;
            bt_save_new_staff.Visible = false;
            tb_name.Focus();
            //Hiển thị nút Lưu, huỷ
            bt_save_edited_staff.Visible = true;
            bt_cancel.Visible = true;
        }
        //Cập nhật thông tin nhân viên vừa sửa
        private void bt_save_edited_staff_Click(object sender, EventArgs e)
        {
            if (Set_varialbe_name())
            {
                ID = tb_id.Text;
                Set_varialbe_name();
                EditData(sender, e);
                //Gọi sự kiện nút Huỷ - Hiển thị lại các nút chức năng ban đầu
                bt_cancel_Click(sender, e);
                tb_id.Enabled = true;
                //Sau khi thêm dữ liệu mới vào database thì cập nhật dữ liệu mới lên datagridview
                UC_Staff_Load(sender, e);
            }
        }
        //Huỷ hoạt động đang diễn ra - Thêm, Sửa, Xoá
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            //Khi nhấn "Huỷ" thì hiển thị lại các nút chức năng ban đầu
            bt_add_staff.Visible = true;
            bt_save_new_staff.Visible = true;
            bt_remove_staff.Visible = true;
            bt_edit_staff.Visible = true;
            bt_save_edited_staff.Visible = true;
            //
            tb_id.Enabled = true;
            UC_Staff_Load(sender, e);
        }

        //CÁC SỰ KIỆN XỬ LÝ DataGridView - dgv_st
        private void dgv_st_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = string.Copy(dgv_st.Rows[index].Cells["ID"].Value.ToString());
                tb_id.Text = dgv_st.Rows[index].Cells["ID"].Value.ToString();
                tb_name.Text = dgv_st.Rows[index].Cells["FULLNAME"].Value.ToString();
                dtp.Text = dgv_st.Rows[index].Cells["DOB"].Value.ToString();
                tb_location.Text = dgv_st.Rows[index].Cells["LOCA"].Value.ToString();
                tb_phone.Text = dgv_st.Rows[index].Cells["PHONE"].Value.ToString();
                tb_bl.Value = Convert.ToDecimal(dgv_st.Rows[index].Cells["PAYRATE"].Value);
                tb_basicrate.Text = dgv_st.Rows[index].Cells["BASICRATE"].Value.ToString();
                tb_allowence.Text = dgv_st.Rows[index].Cells["ALLOWENCE"].Value.ToString();
                if (string.Equals("0",dgv_st.Rows[index].Cells["SEX"].Value.ToString()))
                {
                    rb_male.Checked = true;
                }
                else if (string.Equals("1", dgv_st.Rows[index].Cells["SEX"].Value.ToString()))
                {
                    rb_female.Checked = true;
                }
            }
        }
        private void dgv_st_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = string.Copy(dgv_st.Rows[index].Cells["ID"].Value.ToString());
                tb_id.Text = dgv_st.Rows[index].Cells["ID"].Value.ToString();
                tb_name.Text = dgv_st.Rows[index].Cells["FULLNAME"].Value.ToString();
                dtp.Text = dgv_st.Rows[index].Cells["DOB"].Value.ToString();
                tb_location.Text = dgv_st.Rows[index].Cells["LOCA"].Value.ToString();
                tb_phone.Text = dgv_st.Rows[index].Cells["PHONE"].Value.ToString();
                tb_bl.Value = Convert.ToDecimal(dgv_st.Rows[index].Cells["PAYRATE"].Value);
                tb_basicrate.Text = dgv_st.Rows[index].Cells["BASICRATE"].Value.ToString();
                tb_allowence.Text = dgv_st.Rows[index].Cells["ALLOWENCE"].Value.ToString();
                if (string.Equals("0", dgv_st.Rows[index].Cells["SEX"].Value.ToString()))
                {
                    rb_male.Checked = true;
                }
                else if (string.Equals("1", dgv_st.Rows[index].Cells["SEX"].Value.ToString()))
                {
                    rb_female.Checked = true;
                }
            }
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("vn-VN", false).TextInfo;
            tb_name.Text = textInfo.ToTitleCase(tb_name.Text.ToLower()); //Chuyển tất cả về chữ thường sau đó đổi kiểu chữ hoa chữ cái đầu tiên
        }

        private void tb_location_Leave(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("vn-VN", false).TextInfo;
            tb_location.Text = textInfo.ToTitleCase(tb_location.Text.ToLower()); //Chuyển tất cả về chữ thường sau đó đổi kiểu chữ hoa chữ cái đầu tiên
        }
        //Kiểm tra các dữ liệu người dùng nhập vào
        private bool checkData()
        {
            if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_id.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_name.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_phone.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_phone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_location.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_location.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_basicrate.Text))
            {
                MessageBox.Show("Bạn chưa nhập lương cơ bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_basicrate.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_bl.Text))
            {
                MessageBox.Show("Bạn chưa nhập bậc lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_bl.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_allowence.Text))
            {
                MessageBox.Show("Bạn chưa nhập phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_allowence.Focus();
                return false;
            }
            if (rb_male.Checked==false && rb_female.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rb_male.Focus();
                return false;
            }
            if (tb_bl.Value <= 0)
            {
                MessageBox.Show("Bậc lương phải là một số dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_bl.Focus();
                return false;
            }
            if (tb_basicrate.Value <= 0)
            {
                MessageBox.Show("Lương cơ bản phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_basicrate.Focus();
                return false;
            }
            if (tb_allowence.Value <= 0)
            {
                MessageBox.Show("Phụ cấp phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_allowence.Focus();
                return false;
            }
            if(Int32.TryParse(tb_basicrate.Text, out int intNumber) == false)
            {
                MessageBox.Show("Lương cơ bản phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_basicrate.Focus();
                return false;
            }
            if (Int32.TryParse(tb_allowence.Text, out int intNumber2) == false)
            {
                MessageBox.Show("Phụ cấp phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_allowence.Focus();
                return false;
            }
            return true;
        }
    }
}
