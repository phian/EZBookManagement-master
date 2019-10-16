using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreManagementApp_DTO;
using BookstoreManagementApp_BUS;
namespace BookstoreManagementApp_Final_
{
    public partial class UC_AccessoryOffice : UserControl
    {
        public UC_AccessoryOffice()
        {
            InitializeComponent();
            acBUS = new AccessoryOffice_BUS();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi vẽ rắn lên hình thì sẽ không bị nháy
            acceptBtn.BackColor = Color.Transparent;
            acceptBtn.FlatStyle = FlatStyle.Flat;
            acceptBtn.FlatAppearance.BorderSize = 0;
            showAllAccessoryOffice();
            loadForm();
        }
        AccessoryOffice_BUS acBUS;
        // Đổ databse vào datasource của DataGridview
        public void showAllAccessoryOffice()
        {   // Đổ database vào một đối tượng datatable
            DataTable dt = acBUS.gettAllAccessory();
            //  Đổ data từ datatable vào datasource của DataGridview
            //  Đổ data từ datatable vào datasource của DataGridview
            acsoryGrid.DataSource = dt;
            acsoryGrid.AutoResizeColumns();
        }
        public void showResultsearch()
        {
            AccessoryOffice VANPHONGPHAM = new AccessoryOffice();
            VANPHONGPHAM.MASANPHAM = prdctID_TXT.Text;
            DataTable dt = acBUS.searchByProductID(VANPHONGPHAM);
            acsoryGrid.DataSource = dt;
            acsoryGrid.AutoResizeColumns();
        }
        //Sự kiện khi gọi loadform Văn phòng phẩm
        private void accsoryForm_Load(object sender, EventArgs e)
        {
            showAllAccessoryOffice();
            loadForm();
        } 
        // Hiện trạng load ban đầu của form văn phòng phẩm
        void loadForm()
        {
            addBtn.Visible = true;
            addBtn.Enabled = true;
            updateBtn.Visible = true;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
            deleteBtn.Visible = true;
            searchAccessory.Enabled = true;
            searchAccessory.Visible = true;
            acceptBtn.Enabled = false;
            acceptBtn.Visible = false;
            saveBtn.Enabled = false;
            saveBtn.Visible = false;
            updatesaveBtn.Enabled = false;
            updatesaveBtn.Visible = false;
            backBtn.Enabled = false;
            backBtn.Visible = false;
            prdctID_TXT.Enabled = false;
            prdctCategory_TXT.Enabled = false;
            prductType_TXT.Enabled = false;
            prdctManu_TXT.Enabled = false;
            prdctRelease_DTPICKER.Enabled = false;
            prdctDate_DTPICKER.Enabled = false;
            prdctName_TXT.Enabled = false;
            prdctPrice_TXT.Enabled = false;

        }
        // Mở khóa form để bắt đâu nhập liệu
        void unLoadForm()
        {
            saveBtn.Enabled = true;
            saveBtn.Visible = true;
            backBtn.Enabled = true;
            backBtn.Visible = true;
            updatesaveBtn.Enabled = true;
            updatesaveBtn.Visible = true;
            prdctID_TXT.Enabled = true;
            prdctCategory_TXT.Enabled = true;
            prductType_TXT.Enabled = true;
            prdctManu_TXT.Enabled = true;
            prdctRelease_DTPICKER.Enabled = true;
            prdctDate_DTPICKER.Enabled = true;
            prdctName_TXT.Enabled = true;
            prdctPrice_TXT.Enabled = true;

            prdctID_TXT.Focus();
        }
        //Clear các trường dữ liệu chuẩn bị cho việc nhập liệu
        void clearForm()
        {
            prdctID_TXT.Text = null;
            prdctName_TXT.Text = null;
            prductType_TXT.Text = null;
            prdctCategory_TXT.Text = null;
            prdctPrice_TXT.Text = null;
            prdctManu_TXT.Text = null;
        }
        //Hàm check các trường có bị bỏ trống khi nhập vào
        private bool checkData()
        {
            if (string.IsNullOrEmpty(prdctID_TXT.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prdctID_TXT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prdctName_TXT.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prdctName_TXT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prductType_TXT.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prductType_TXT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prdctCategory_TXT.Text))
            {
                MessageBox.Show("Bạn chưa nhập danh mục cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prdctCategory_TXT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prdctPrice_TXT.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá tiền cho sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prdctPrice_TXT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(prdctManu_TXT.Text))
            {
                MessageBox.Show("Bạn chưa nhập nhà sản xuất cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prdctManu_TXT.Focus();
                return false;
            }
            return true;
        }
        //Hàm thực hiện khi click vào nút Add
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            clearForm();
            unLoadForm();
            updateBtn.Enabled = false;
            updateBtn.Visible = false;
            deleteBtn.Visible = false;
            deleteBtn.Enabled = false;
            addBtn.Visible = false;
            updatesaveBtn.Enabled = false;
            updatesaveBtn.Visible = false;
            searchAccessory.Enabled = false;
            searchAccessory.Visible = false;
            acceptBtn.Enabled = false;
            acceptBtn.Visible = false;
            addBtn.Visible = true;
            addBtn.Enabled = false;
        }
        // Hàm thực hiện khi click vào nút Update
        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            unLoadForm();
            searchAccessory.Visible = false;
            searchAccessory.Enabled = false;
            acceptBtn.Visible = true;
            acceptBtn.Enabled = true;
            saveBtn.Enabled = false;
            saveBtn.Visible = false;
            updateBtn.Enabled = false;
            updateBtn.Visible = true;
            deleteBtn.Visible = false;
            deleteBtn.Enabled = false;
            addBtn.Visible = false;
            prdctID_TXT.Enabled = false; // Khóa chính không được sửa nên textbox mã sản phẩm sẽ bị vô hiệu hóa cho chức năng update
        }
        //Hàm thực hiện khi nhấn vào nút Search
        private void searchAccessory_Click_1(object sender, EventArgs e)
        {
            unLoadForm();
            clearForm();
            acceptBtn.Visible = true;
            acceptBtn.Enabled = true;
            searchAccessory.Enabled = false;
            addBtn.Visible = false;
            addBtn.Enabled = false;
            saveBtn.Enabled = false;
            updatesaveBtn.Enabled = false;
            updateBtn.Enabled = false;
            updateBtn.Visible = false;
        }
        //Hàm thực hiện khi click vào nút delete
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa thông tin này, dữ liệu có thể sẽ không được khôi phục",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                AccessoryOffice VANPHONGPHAM = new AccessoryOffice();
                VANPHONGPHAM.MASANPHAM = prdctID_TXT.Text;
                if (acBUS.deleteAccessory(VANPHONGPHAM))
                    showAllAccessoryOffice();
            }
        }
        //Sự kiện khi nhấn vào nút back
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ thao tác đang thực hiện", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                loadForm();
                backBtn.Visible = false;
                backBtn.Enabled = false;
                showAllAccessoryOffice();
            }
        }
        //Sự kiện khi nhấn vào nút save của Add
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                AccessoryOffice VANPHONGPHAM = new AccessoryOffice();
                VANPHONGPHAM.MASANPHAM = prdctID_TXT.Text;
                VANPHONGPHAM.TENSANPHAM = prdctName_TXT.Text;
                VANPHONGPHAM.MALOAISANPHAM = prductType_TXT.Text;
                VANPHONGPHAM.DANHMUC = prdctCategory_TXT.Text;
                VANPHONGPHAM.GIA = decimal.Parse(prdctPrice_TXT.Text);
                VANPHONGPHAM.NGAYSANXUAT = prdctRelease_DTPICKER.Value;
                VANPHONGPHAM.HANSUDUNG = prdctDate_DTPICKER.Value;
                VANPHONGPHAM.NHASANXUAT = prdctManu_TXT.Text;
                if (acBUS.InsertAccessory(VANPHONGPHAM))
                    showAllAccessoryOffice();
              
                loadForm();
            }
        }
        //Sự kiện khi nhấn vào nút save của update
        private void updatesaveBtn_Click_1(object sender, EventArgs e)
        {
            if (checkData())
            {
                AccessoryOffice VANPHONGPHAM = new AccessoryOffice();
                VANPHONGPHAM.MASANPHAM = prdctID_TXT.Text;
                VANPHONGPHAM.TENSANPHAM = prdctName_TXT.Text;
                VANPHONGPHAM.MALOAISANPHAM = prductType_TXT.Text;
                VANPHONGPHAM.DANHMUC = prdctCategory_TXT.Text;
                VANPHONGPHAM.GIA = decimal.Parse(prdctPrice_TXT.Text);
                VANPHONGPHAM.NGAYSANXUAT = prdctRelease_DTPICKER.Value;
                VANPHONGPHAM.HANSUDUNG = prdctDate_DTPICKER.Value;
                VANPHONGPHAM.NHASANXUAT = prdctManu_TXT.Text;
                if (acBUS.updateaCCESSORY(VANPHONGPHAM))
                    showAllAccessoryOffice();
                loadForm();
            }
        }
        //Sự kiện rowEnter cho DatagridView
        private void acsoryGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                prdctID_TXT.Text = acsoryGrid.Rows[index].Cells["MASANPHAM"].Value.ToString();
                prdctName_TXT.Text = acsoryGrid.Rows[index].Cells["TENSANPHAM"].Value.ToString();
                prductType_TXT.Text = acsoryGrid.Rows[index].Cells["MALOAISANPHAM"].Value.ToString();
                prdctCategory_TXT.Text = acsoryGrid.Rows[index].Cells["DANHMUC"].Value.ToString();
                prdctPrice_TXT.Text = acsoryGrid.Rows[index].Cells["GIA"].Value.ToString();
                prdctRelease_DTPICKER.Text = acsoryGrid.Rows[index].Cells["NGAYSANXUAT"].Value.ToString();
                prdctDate_DTPICKER.Text = acsoryGrid.Rows[index].Cells["HANSUDUNG"].Value.ToString();
                prdctManu_TXT.Text = acsoryGrid.Rows[index].Cells["NHASANXUAT"].Value.ToString();
            }
        }
 //Hàm bắt đầu bung kết quả 
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            showResultsearch();
        }
    }
}
