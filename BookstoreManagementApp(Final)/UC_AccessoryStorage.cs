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
using BookstoreManagementApp_DTO;
namespace BookstoreManagementApp_Final_
{
    public partial class UC_AccessoryStorage : UserControl
    {
        public UC_AccessoryStorage()
        {
            InitializeComponent();
            asBUS = new AccessoryStorage_BUS();
            IaBUS = new InvoiceAccessory_BUS();
            afBUS = new AccessoryOffice_BUS();
            showAllInvoiceAccessory();
            loadForm();
        }
        AccessoryStorage_BUS asBUS;
        InvoiceAccessory_BUS IaBUS;
        AccessoryOffice_BUS afBUS;
        //Hiển thị các item trên bảng HÓA ĐƠN VĂN PHÒNG PHẨM
        //Hiển thị các item trên bảng KHO VĂN PHÒNG PHẨM
        public void showAllInvoiceAccessory()
        {
            DataTable dt = asBUS.getAllAcc_Invoice();
            acStorageGrid.DataSource = dt;
            acStorageGrid.AutoResizeColumns();
        }
        //public void showAllAccessoryStorage()
        //{   // Đổ database vào một đối tượng datatable
        //    DataTable dt = asBUS.gettAllAccessoryType();
        //    //  Đổ data từ datatable vào datasource của DataGridview
        //    //  Đổ data từ datatable vào datasource của DataGridview
        //    acStorageGrid.DataSource = dt;
        //    acStorageGrid.AutoResizeColumns();
        //}
        //Hàm đồng bộ từ girview lên các textbox 
        private void acStorageGrid_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                typeIDtext.Text = acStorageGrid.Rows[index].Cells["MALOAISANPHAM"].Value.ToString();
                newNumber.Text = acStorageGrid.Rows[index].Cells["SOLUONGMOI"].Value.ToString();
                oldNumber.Text = acStorageGrid.Rows[index].Cells["SOLUONGTONKHO"].Value.ToString();
                idInvoiceTxt.Text = acStorageGrid.Rows[index].Cells["MAHOADON"].Value.ToString();
                idImportTxt.Text = acStorageGrid.Rows[index].Cells["MALOHANG"].Value.ToString();
                supplierTxt.Text = acStorageGrid.Rows[index].Cells["NHACUNGCAP"].Value.ToString();
                dateImport.Text = acStorageGrid.Rows[index].Cells["NGAYNHAP"].Value.ToString();
            }
        }
        //Hàm check data cho kho văn phòng phẩm 
        private bool checkData()
        {
            if (string.IsNullOrEmpty(typeIDtext.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                typeIDtext.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(newNumber.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newNumber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(oldNumber.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                oldNumber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(idInvoiceTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idInvoiceTxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(idImportTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lộ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idImportTxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(supplierTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                supplierTxt.Focus();
                return false;
            }
            return true;
        }
        //Hàm loadform ban đầu khi gọi form quản lý kho văn phòng phẩm
        private void loadForm()
        {
            addsaveBtn.Enabled = false;
            addsaveBtn.Visible = false;
            editSavebtn.Visible = false;
            editSavebtn.Enabled = false;
            backBtn.Enabled = false;
            backBtn.Visible = false;
            acStoragePnl.Enabled = false;
            updateBtn.Enabled = true;
            updateBtn.Visible = true;
            addBtn1.Enabled = true;
            addBtn1.Visible = true;
            deleteBtn.Enabled = true;
            deleteBtn.Visible = true;
            searchAccessory.Enabled = true;
            searchAccessory.Visible = true;
            typeAccept.Visible = false;
            typeAccept.Enabled = false;
            invoiceAccept.Visible = false;
            invoiceAccept.Enabled = false;
        }
        //Hàm cho sự kiện click vào nút nút ADD
        private void addBtn1_Click(object sender, EventArgs e)
        {
            addBtn1.Enabled = false;
            updateBtn.Enabled = false;
            updateBtn.Visible = false;
            deleteBtn.Enabled = false;
            deleteBtn.Visible = false;
            editSavebtn.Enabled = false;
            editSavebtn.Visible = false;
            addsaveBtn.Enabled = true;
            addsaveBtn.Visible = true;
            backBtn.Enabled = true;
            backBtn.Visible = true;
            acStoragePnl.Enabled = true;
            searchAccessory.Enabled = false;
            searchAccessory.Visible = false;
            clearForm();
        }
        //Hàm cho sự kiện click vào nút quay lại
        private void backBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ thao tác đang thực hiện", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                loadForm();
                idInvoiceTxt.Enabled = true;
                typeIDtext.Enabled = true;
                newNumber.Enabled = true;
                acStorageGrid.Enabled = true;
                showAllInvoiceAccessory();
            }
        }
        //Hàm cho sự kiện nút delete
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa thông tin này. CÁC DỮ LIỆU LIÊN QUAN ĐẾN MÃ LOẠI SẢN PHẨM NÀY SẼ ĐỀU BỊ XÓA",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                AccessoryOffice VANPHONGPHAM = new AccessoryOffice();
                VANPHONGPHAM.MALOAISANPHAM = typeIDtext.Text;
                AccessoryStorage KHOVANPHONGPHAM = new AccessoryStorage();
                KHOVANPHONGPHAM.MALOAISANPHAM = typeIDtext.Text;
                InvoiceAccessory HOADONVPP = new InvoiceAccessory();
                HOADONVPP.MALOAISANPHAM = typeIDtext.Text;
                if (afBUS.deleteAccessoryOfficebyID(VANPHONGPHAM) && IaBUS.deleteInvoicebyID(HOADONVPP) && asBUS.deleteAccessoryType(KHOVANPHONGPHAM))
                    showAllInvoiceAccessory();
            }
        }
        //Hàm clear form để nhập liệu
        private void clearForm()
        {
            typeIDtext.Text = null;
            newNumber.Text = null;
            oldNumber.Text = null;
            idImportTxt.Text = null;
            idInvoiceTxt.Text = null;
            supplierTxt.Text = null;
            typeIDtext.Focus();
        }
        //Hàm cho nút sửa
        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            acStoragePnl.Enabled = true;
            typeIDtext.Enabled = false;
            idInvoiceTxt.Enabled = false;
            updateBtn.Enabled = false;
            addBtn1.Enabled = false;
            addBtn1.Visible = false;
            deleteBtn.Enabled = false;
            deleteBtn.Visible = false;
            editSavebtn.Enabled = true;
            editSavebtn.Visible = true;
            backBtn.Enabled = true;
            backBtn.Visible = true;
            addsaveBtn.Enabled = false;
            addsaveBtn.Visible = false;
            newNumber.Enabled = false;

            searchAccessory.Enabled = false;
            searchAccessory.Visible = true;
            typeAccept.Visible = true;
            typeAccept.Enabled = true;
            invoiceAccept.Visible = true;
            invoiceAccept.Enabled = true;
            searchAccessory.Enabled = false;
            searchAccessory.Visible = false;
        }
        //Hàm cho nút lưu của nút sửa
        private void editSavebtn_Click_1(object sender, EventArgs e)
        {
            if (checkData())
            {
                AccessoryStorage KHOVANPHONGPHAM = new AccessoryStorage();
                InvoiceAccessory HOADONVPP = new InvoiceAccessory();
                KHOVANPHONGPHAM.MALOAISANPHAM = typeIDtext.Text;
                HOADONVPP.SOLUONGMOI = int.Parse(newNumber.Text);
                KHOVANPHONGPHAM.SOLUONGTONKHO = int.Parse(oldNumber.Text);
                HOADONVPP.MAHOADON = idInvoiceTxt.Text;
                HOADONVPP.MALOHANG = idImportTxt.Text;
                HOADONVPP.NGAYNHAP = dateImport.Value;
                HOADONVPP.NHACUNGCAP = supplierTxt.Text;
                HOADONVPP.MALOAISANPHAM = typeIDtext.Text;
                if (asBUS.updateaCCESSORYType(KHOVANPHONGPHAM) && IaBUS.updatInvoiceAccessoryType(HOADONVPP))
                {
                    showAllInvoiceAccessory();
                }
               
                loadForm();
            }
            idInvoiceTxt.Enabled = true;
            typeIDtext.Enabled = true;
            newNumber.Enabled = true;
            acStorageGrid.Enabled = true;
        }
        //HÀM SAVE CHO NÚT THÊM
        private void addsaveBtn_Click_1(object sender, EventArgs e)
        {
            if (checkData())
            {
                AccessoryStorage KHOVANPHONGPHAM = new AccessoryStorage();
                InvoiceAccessory HOADONVPP = new InvoiceAccessory();
                KHOVANPHONGPHAM.MALOAISANPHAM = typeIDtext.Text;
                HOADONVPP.SOLUONGMOI = int.Parse(newNumber.Text);
                KHOVANPHONGPHAM.SOLUONGTONKHO = int.Parse(oldNumber.Text);
                HOADONVPP.MAHOADON = idInvoiceTxt.Text;
                HOADONVPP.MALOHANG = idImportTxt.Text;
                HOADONVPP.NGAYNHAP = dateImport.Value;
                HOADONVPP.NHACUNGCAP = supplierTxt.Text;
                HOADONVPP.MALOAISANPHAM = typeIDtext.Text;
                if (asBUS.checkExistAccessoryType(KHOVANPHONGPHAM))
                {
                    if (asBUS.updateNumberAccessoryStorage(HOADONVPP) && IaBUS.InsertInvocieAccessoryType(HOADONVPP))
                        showAllInvoiceAccessory();
                    
                    loadForm();
                }
                else
                {
                    if (asBUS.InsertAccessoryType(KHOVANPHONGPHAM) && IaBUS.InsertInvocieAccessoryType(HOADONVPP))
                        showAllInvoiceAccessory();
                    
                    loadForm();
                }

            }
        }
        //Hàm cho nút tìm kiếm
        private void searchAccessory_Click_1(object sender, EventArgs e)
        {
            addBtn1.Enabled = false;
            updateBtn.Enabled = false;
            updateBtn.Visible = false;
            deleteBtn.Enabled = true;
            deleteBtn.Visible = true;
            editSavebtn.Enabled = false;
            editSavebtn.Visible = false;
            addsaveBtn.Enabled = false;
            addsaveBtn.Visible = false;
            backBtn.Enabled = true;
            backBtn.Visible = true;
            acStoragePnl.Enabled = true;
            typeAccept.Visible = true;
            typeAccept.Enabled = true;
            invoiceAccept.Visible = true;
            invoiceAccept.Enabled = true;
            addBtn1.Visible = false;
            addBtn1.Enabled = false;
            searchAccessory.Enabled = false;
            clearForm();
        }
        public void showResultSearchStorage()
        {
            AccessoryStorage KHOVANPHONGPHAM = new AccessoryStorage();
            KHOVANPHONGPHAM.MALOAISANPHAM = typeIDtext.Text;
            DataTable dt = asBUS.searchByProductTypeID(KHOVANPHONGPHAM);
            acStorageGrid.DataSource = dt;
            acStorageGrid.AutoResizeColumns();
        }
        public void showResultSearchInvoice()
        {
            InvoiceAccessory HOADONVPP = new InvoiceAccessory();
            HOADONVPP.MAHOADON = idInvoiceTxt.Text;
            DataTable dt = IaBUS.searchByInvoiceID(HOADONVPP);
            acStorageGrid.DataSource = dt;
            acStorageGrid.AutoResizeColumns();
        }
        //Hàm nút chấp nhận tìm kiếm theo mã loại sản phẩm
        private void typeAccept_Click_1(object sender, EventArgs e)
        {
            showResultSearchStorage();
        }
        //Hàm nút sản phẩm tìm kiếm theo mã hóa đơn
        private void invoiceAccept_Click_1(object sender, EventArgs e)
        {
            showResultSearchInvoice();
        }

        private void typeIDtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
