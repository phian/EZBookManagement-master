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
using System.Globalization;

namespace BookstoreManagementApp_Final_
{
    public partial class UC_CSVC : UserControl
    {
        public UC_CSVC()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }
        //Init
        CSVC_BUS CSVC = new CSVC_BUS();
        public string IDCSVC;
        public string TENCSVC;
        public string NGAYNHAP;
        public int SL;
        //Đặt giá trị cho các biến với dữ liệu lấy từ TextBox
        private bool Set_varialbe_name()
        {
            if(checkData())
            {
                IDCSVC = tb_csvc_id.Text;
                TENCSVC = tb_csvc_name.Text;
                NGAYNHAP = dtp_csvc.Text;
                SL = Convert.ToInt32(tb_csvc_sl.Text);
                return true;
            }
            return false;
        }
        
        private void UC_CSVC_Load(object sender, EventArgs e)
        {
            dgv_csvc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_csvc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Lấy thông tin về các cơ sở vật chất từ cơ sở dữ liệu 
            Load_Data_From_Database();
            //Đặt tên các cột trong DataGridView
            dgv_csvc.Columns[0].HeaderText = "ID";
            dgv_csvc.Columns[1].HeaderText = "Tên";
            dgv_csvc.Columns[2].HeaderText = "Ngày nhập";
            dgv_csvc.Columns[3].HeaderText = "Số lượng";
            //Mặc định sẽ ẩn các button Lưu (thêm), Lưu (sửa), và Huỷ
            bt_csvc_es.Visible = false;
            bt_csvc_as.Visible = false;
            bt_cancel.Visible = false;
        }
        ////CÁC HÀM THAO TÁC VỚI DỮ LIỆU NHÂN VIÊN TRÊN BẢNG CSVC
        private void Load_Data_From_Database()
        {
            dgv_csvc.DataSource = CSVC.Get().Tables[0];
        }
        //CÁC SỰ KIỆN XỬ LÝ BUTTON

        //Thêm thông tin cơ sở vật chất mới
        private void bt_csvc_add_Click(object sender, EventArgs e)
        {
            //Ẩn các nút chức năng Thêm, Sửa, Xoá
            bt_csvc_add.Visible = false;
            bt_csvc_del.Visible = false;
            bt_csvc_edit.Visible = false;
            bt_csvc_es.Visible = false;
            //Xoá dữ liệu trong textbox
            tb_csvc_id.Text = "";
            tb_csvc_name.Text = "";
            tb_csvc_sl.Text = "";
            //Hiển thị nút Lưu (thêm mới), huỷ
            bt_csvc_as.Visible = true;
            bt_cancel.Visible = true;
            tb_csvc_id.Focus();
        }
        //Lưu thông tin cơ sở vật chất mới
        private void bt_csvc_as_Click(object sender, EventArgs e)
        {
            if(Set_varialbe_name())
            {
                IDCSVC = tb_csvc_id.Text;
                Set_varialbe_name();
                CSVC.Add(IDCSVC, TENCSVC, NGAYNHAP, SL);
                bt_cancel_Click(sender, e);
                UC_CSVC_Load(sender, e);
            }
        }
        //Sửa thông tin cơ sở vật chất hiện có
        private void bt_csvc_edit_Click(object sender, EventArgs e)
        {
            //Ẩn các nút chức năng Thêm, Sửa, Xoá
            bt_csvc_add.Visible = false;
            bt_csvc_del.Visible = false;
            bt_csvc_edit.Visible = false;
            bt_csvc_as.Visible = false;
            //Không cho phép người dùng sửa ID
            tb_csvc_id.Enabled = false;
            //Hiển thị nút Lưu (sửa)
            bt_csvc_es.Visible = true;
            //Hiển thị nút Huỷ
            bt_cancel.Visible = true;
            //
            tb_csvc_name.Focus();
        }
        private void bt_csvc_es_Click(object sender, EventArgs e)
        {
            if(Set_varialbe_name())
            {
                IDCSVC = tb_csvc_id.Text;
                Set_varialbe_name();
                CSVC.Update(IDCSVC, TENCSVC, NGAYNHAP, SL);
                tb_csvc_id.Enabled = true;
                bt_cancel_Click(sender, e);
                UC_CSVC_Load(sender, e);
            }
        }
        //Xoá thông tin cơ sở vật chất hiện có
        private void bt_csvc_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa thông tin này, dữ liệu có thể sẽ không được khôi phục",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                IDCSVC = tb_csvc_id.Text;
                CSVC.Delete(IDCSVC);
                bt_cancel_Click(sender, e);
                UC_CSVC_Load(sender, e);
            }
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            //Hiển thị lại các nút chức năng Thêm, Sửa, Xoá
            bt_csvc_add.Visible = true;
            bt_csvc_as.Visible = true;
            bt_csvc_del.Visible = true;
            bt_csvc_edit.Visible = true;
            bt_csvc_es.Visible = true;
            //
            tb_csvc_id.Enabled = true;
            UC_CSVC_Load(sender, e);
        }

        //CÁC SỰ KIỆN XỬ LÝ DataGridView - dgv_csvc
        private void dgv_csvc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                IDCSVC = string.Copy(dgv_csvc.Rows[numrow].Cells["IDCSVC"].Value.ToString());
                tb_csvc_id.Text = dgv_csvc.Rows[numrow].Cells[0].Value.ToString();
                tb_csvc_name.Text = dgv_csvc.Rows[numrow].Cells[1].Value.ToString();
                dtp_csvc.Text= dgv_csvc.Rows[numrow].Cells[2].Value.ToString();
                tb_csvc_sl.Text = dgv_csvc.Rows[numrow].Cells[3].Value.ToString();
            }
        }

        private void dgv_csvc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                IDCSVC = string.Copy(dgv_csvc.Rows[numrow].Cells["IDCSVC"].Value.ToString());
                tb_csvc_id.Text = dgv_csvc.Rows[numrow].Cells[0].Value.ToString();
                tb_csvc_name.Text = dgv_csvc.Rows[numrow].Cells[1].Value.ToString();
                dtp_csvc.Text = dgv_csvc.Rows[numrow].Cells[2].Value.ToString();
                tb_csvc_sl.Text = dgv_csvc.Rows[numrow].Cells[3].Value.ToString();
            }
        }
        private void tb_csvc_name_Leave(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("vn-VN", false).TextInfo;
            tb_csvc_name.Text = textInfo.ToTitleCase(tb_csvc_name.Text.ToLower()); //Chuyển tất cả về chữ thường sau đó đổi kiểu chữ hoa chữ cái đầu tiên
        }
        //Kiểm tra xem người dùng đã nhập dữ liệu hợp lệ vào các TextBox chưa
        private bool checkData()
        {
            if (string.IsNullOrEmpty(tb_csvc_id.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID cơ sở vật chất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_csvc_id.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_csvc_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên cơ sở vật chất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_csvc_name.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_csvc_sl.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_csvc_sl.Focus();
                return false;
            }
            //Kiểm tra chuỗi nhập vào có phải chỉ chứa số nguyên hay không
            if (tb_csvc_sl.Value <= 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_csvc_sl.Focus();
                return false;
            }
            return true;
        }
    }
}
