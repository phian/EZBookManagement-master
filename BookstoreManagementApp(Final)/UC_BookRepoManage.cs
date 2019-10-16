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
    public partial class UC_BookRepoManage : UserControl
    {
        public UC_BookRepoManage()
        {
            InitializeComponent();
            this.SetStyle(
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint |
               ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy

            ExistInvoiceDataDG.DataBindings.Add(nameof(DataGrid.BackgroundColor),
                                this,
                                nameof(Control.BackColor));

            ExistBookRepoDG.DataBindings.Add(nameof(DataGrid.BackgroundColor),
                                this,
                                nameof(Control.BackColor));
        }
        //-----------------------------------------------------Phần của nút thêm----------------------------------------------------//

        // Hàm để visible các control khi ng dùng thêm sách
        private void VisibleControl()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy

            // Disable các nút chức năng để tránh việc ng dùng ấn nhầm
            AddBookRepoButton.Enabled = false;
            EditBookRepoButton.Enabled = false;
            DeleteBookRepoButton.Enabled = false;
            BookRepoStatisticBut.Enabled = false;

            // Nếu đang chọn thao tác thêm (Reset lại toạ độ trc để tránh giật lag khi visible)
            if (CheckButton == 1)
            {
                AddedBookRepoGB.Visible = true;
                SaveButton.Visible = true;

                // Thay đổi toạ độ các control để phù hợp với diện tích form
                //BookTitleCodeLb.Location = new Point(156, 195);
                //BookTitleCodeTxb.Location = new Point(279, 193);
                //NewBookNumLb.Location = new Point(155, 236);
                //NewBookNumberNum.Location = new Point(279, 235);
                //GoodsReceivedPlaceLb.Location = new Point(154, 277);
                //GoodsReceivedPlaceTxb.Location = new Point(279, 275);
                //InvoiceCodeLb.Location = new Point(154, 320);
                //InvoiceCodeTxb.Location = new Point(279, 315);
                //GoodsReceivedDayLb.Location = new Point(555, 190);
                //GoodsReceivedDayDTP.Location = new Point(659, 187);
                //ShipmentCodeLb.Location = new Point(551, 226);
                //ShipmentCodeTxb.Location = new Point(659, 224);
                //InventoryQuantityLb.Location = new Point(534, 263);
                //InventoryQuantityNum.Location = new Point(659, 261);
                //AddedBookRepoGB.Location = new Point(146, 370);
            }

            // Nếu đang chọn thao tác sửa
            else if (CheckButton == 2)
            {
                ExistInvoiceDataGB.Visible = true;
                BookTitleCodeTxb.Enabled = false;
                InvoiceCodeTxb.Enabled = false;
                NewBookNumberNum.Enabled = false;
                SaveButton.Visible = true;

                // Thay đổi toạ độ các control để phù hợp với diện tích form
                //BookTitleCodeLb.Location = new Point(156, 195);
                //BookTitleCodeTxb.Location = new Point(279, 193);
                //NewBookNumLb.Location = new Point(155, 236);
                //NewBookNumberNum.Location = new Point(279, 235);
                //GoodsReceivedPlaceLb.Location = new Point(154, 277);
                //GoodsReceivedPlaceTxb.Location = new Point(279, 275);
                //InvoiceCodeLb.Location = new Point(154, 320);
                //InvoiceCodeTxb.Location = new Point(279, 315);
                //GoodsReceivedDayLb.Location = new Point(555, 195);
                //GoodsReceivedDayDTP.Location = new Point(659, 193);
                //ShipmentCodeLb.Location = new Point(551, 236);
                //ShipmentCodeTxb.Location = new Point(659, 235);
                //InventoryQuantityLb.Location = new Point(534, 263);
                //InventoryQuantityNum.Location = new Point(659, 261);
                //ExistInvoiceDataGB.Location = new Point(146, 370);
            }

            BookTitleCodeLb.Visible = true;
            BookTitleCodeTxb.Visible = true;
            NewBookNumLb.Visible = true;
            NewBookNumberNum.Visible = true;
            GoodsReceivedDayLb.Visible = true;
            GoodsReceivedDayDTP.Visible = true;
            ShipmentCodeLb.Visible = true;
            ShipmentCodeTxb.Visible = true;
            GoodsReceivedPlaceLb.Visible = true;
            GoodsReceivedPlaceTxb.Visible = true;
            InvoiceCodeLb.Visible = true;
            InvoiceCodeTxb.Visible = true;


            // Nếu đang chọn thao tác xoá
            if (CheckButton == 3)
            {
                ExistInvoiceDataGB.Visible = true;
                ExistBookRepoDataGB.Visible = true;
                BookTitleCodeTxb.Enabled = false;
                InvoiceCodeTxb.Enabled = false;
                NewBookNumberNum.Enabled = false;
                GoodsReceivedDayDTP.Enabled = false;
                ShipmentCodeTxb.Enabled = false;
                GoodsReceivedPlaceTxb.Enabled = false;

                SaveButton.Visible = true;
                SaveButton.BackgroundImage = new Bitmap(@"..\Debug\ButtonAndFormImage\DeleteBook.png");
            }

            // Nếu đang chọn thao tác xem thống kê
            if (CheckButton == 4)
            {
                BackButton.Visible = true;
                ExistInvoiceDataGB.Visible = true;
                ExistBookRepoDataGB.Visible = true;
                BookTitleCodeTxb.Enabled = false;
                InvoiceCodeTxb.Enabled = false;
                NewBookNumberNum.Enabled = false;
                GoodsReceivedDayDTP.Enabled = false;
                ShipmentCodeTxb.Enabled = false;
                GoodsReceivedPlaceTxb.Enabled = false;
                BackButton.Location = new Point(793, 31);
                SaveButton.Visible = false;
                InvoiceCodeFindTxb.Visible = true;
                InvoiceCodeFindLb.Visible = true;
                BookTitleCodeFindLb.Visible = true;
                BookTitleCodeFindTxb.Visible = true;
                InvoiceCodeFindLb.Location = new Point(534, 236);
                InvoiceCodeFindTxb.Location = new Point(659, 235);
                BookTitleCodeFindLb.Location = new Point(533, 277);
                BookTitleCodeFindTxb.Location = new Point(659, 275);
            }

            BackButton.Visible = true;

            BookTitleCodeTxb.Focus();
        }

        int CheckButton; // Biến để check xem ng dùng đang chọn thao tác nào
                         // Sự kiện khi người dùng ấn nút để thêm dữ liệu cho kho sách
        private void AddBookRepoButton_Click_1(object sender, EventArgs e)
        {
            CheckButton = 1; // Gán để biết được người dùng đang chọn thao tác thêm

            VisibleControl(); // Gọi hàm để visible các control cho việc nhập kho sách
        }

        // Hàm để reset lại các vị trí bị sai mà error provider đã đánh dấu
        private void ResetErrorProvider()
        {
            ErrorPlaceEP.SetError(BookTitleCodeTxb, "");
            ErrorPlaceEP.SetError(NewBookNumberNum, "");
            ErrorPlaceEP.SetError(GoodsReceivedDayDTP, "");
            ErrorPlaceEP.SetError(ShipmentCodeTxb, "");
            ErrorPlaceEP.SetError(GoodsReceivedPlaceTxb, "");
            ErrorPlaceEP.SetError(InvoiceCodeTxb, "");
        }

        // Hàm để check xem các thông tin người dùng nhập đã đúng hay chưa
        private bool CheckBookRepoInfo()
        {
            ResetErrorProvider(); // Gồi hàm để reset lại các vị trí bị sai mà error provider đã đánh dấu trc đó

            if (string.IsNullOrEmpty(BookTitleCodeTxb.Text) == true || string.IsNullOrWhiteSpace(BookTitleCodeTxb.Text) == true)
            {
                ErrorPlaceEP.SetError(BookTitleCodeTxb, "Vui lòng nhập mã tựa sách!");

                return false;
            }

            if (NewBookNumberNum.Value == 0)
            {
                ErrorPlaceEP.SetError(NewBookNumberNum, "Vui lòng nhập số lượng mới");

                return false;
            }

            if (string.IsNullOrEmpty(ShipmentCodeTxb.Text) == true || string.IsNullOrWhiteSpace(ShipmentCodeTxb.Text) == true)
            {
                ErrorPlaceEP.SetError(ShipmentCodeTxb, "Vui lòng nhập mã lô hàng");

                return false;
            }

            if (string.IsNullOrEmpty(GoodsReceivedPlaceTxb.Text) == true || string.IsNullOrWhiteSpace(GoodsReceivedPlaceTxb.Text) == true)
            {
                ErrorPlaceEP.SetError(GoodsReceivedPlaceTxb, "Vui lòng nhập thông tin nơi nhập hàng");

                return false;
            }

            if (string.IsNullOrEmpty(InvoiceCodeTxb.Text) == true || string.IsNullOrWhiteSpace(InvoiceCodeTxb.Text) == true)
            {
                ErrorPlaceEP.SetError(InvoiceCodeTxb, "Vui lòng nhập mã hoả đơn thanh toán của lô hàng");

                return false;
            }

            if (bookRepoManage.CheckInvoiceCode(InvoiceCodeTxb.Text) == true && CheckButton == 1)
            {
                ErrorPlaceEP.SetError(InvoiceCodeTxb, "Mã hoá đơn đã tồn tại vui lòng kiểm tra lại");

                return false;
            }

            return true;
        }

        // Hàm để reset lại các control sau khi ng dùng đã nhập thành công dữ liệu
        private void ResetControl()
        {
            BookTitleCodeTxb.Text = "";
            NewBookNumberNum.Value = 0;
            GoodsReceivedDayDTP.Value = DateTime.Today;
            ShipmentCodeTxb.Text = "";
            GoodsReceivedPlaceTxb.Text = "";
            InvoiceCodeTxb.Text = "";

            BackButton.Location = new Point(667, 31);

            //// Reset lại toạ độ các control như ban đầu
            //BookTitleCodeLb.Location = new Point(190, 155);
            //BookTitleCodeTxb.Location = new Point(279, 153);
            //NewBookNumLb.Location = new Point(156, 195);
            //NewBookNumberNum.Location = new Point(279, 193);
            //GoodsReceivedPlaceLb.Location = new Point(155, 236);
            //GoodsReceivedPlaceTxb.Location = new Point(279, 235);
            //InvoiceCodeLb.Location = new Point(154, 277);
            //InvoiceCodeTxb.Location = new Point(279, 275);
            //GoodsReceivedDayLb.Location = new Point(553, 153);
            //GoodsReceivedDayDTP.Location = new Point(659, 151);
            //ShipmentCodeLb.Location = new Point(555, 190);
            //ShipmentCodeTxb.Location = new Point(659, 187);
            //InventoryQuantityLb.Location = new Point(551, 226);
            //InventoryQuantityNum.Location = new Point(659, 224);
        }

        // Hàm để add hàng dữ liệu mới vào datagridview
        private void AddNewBookRepoInfoRow()
        {
            DataGridViewRow newBookRepo = (DataGridViewRow)AddedBookRepoDG.Rows[AddedBookRepoDG.RowCount - 1].Clone(); // Đồng bộ dòng trong datagridview với dòng ta mới tạo để add vào

            newBookRepo.Cells[0].Value = BookTitleCodeTxb.Text;
            newBookRepo.Cells[1].Value = NewBookNumberNum.Value;
            newBookRepo.Cells[2].Value = GoodsReceivedDayDTP.Value;
            newBookRepo.Cells[3].Value = ShipmentCodeTxb.Text;
            newBookRepo.Cells[4].Value = GoodsReceivedPlaceTxb.Text;
            newBookRepo.Cells[5].Value = InvoiceCodeTxb.Text;

            AddedBookRepoDG.Rows.Add(newBookRepo);
        }

        BookRepoManage_BUS bookRepoManage = new BookRepoManage_BUS(); // Khởi tạo đối tượng để tương tác vói giao diện kho sách 

        string InsertBookRepoQuery; // Biến để lưu trữ câu lệnh query dữ liệu vào kho sách
        string InsertInvoiceQuery; // Biến để lưu trữ câu lệnh query dữ liệu vào hoá đơn
        string updateInvoiceQuery; // 2 biến để lưu 2 câu lệnh query vào kho sách và hoá đơn
        string updateBookRepoQuery;
        string deleteNewBookRepoNumQuery; // 2 biến để lưu trữ lệnh xoá dữ liệu trong kho sách và hoá đơn
        string deleteInvoiceQuery;
        int CheckQuery; // Biến để check xem ng dùng đang sử dụng query nào
        int Total; // Biến để lưu trữ tổng số lượng tồn kho để lưu trữ vào database

        // Sự kiện khi người dùng ấn nút để save dữ liệu
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (CheckButton == 1 && CheckBookRepoInfo() == true)
            {
                // Nếu mã sách đó chưa có trong kho sách
                if (bookRepoManage.CheckBookTitleCode(BookTitleCodeTxb.Text) == false)
                {
                    InsertBookRepoQuery = "Insert into KHOSACH values(@BookTitleCode, @InventoryQuantity)";
                    InsertInvoiceQuery = "Insert into HOADON values(@InvoiceCode, @BookTitleCode, @NewBookNumber, @GoodsReceiveDay, @ShipmentCode, @GoodsReceivePlace)";

                    CheckQuery = 0;
                }

                else
                {
                    InsertBookRepoQuery = "Update KHOSACH set SOLUONGTONKHO = @InventoryQuantity where MATUASACH = @BookTitleCode";
                    InsertInvoiceQuery = "Insert into HOADON values(@InvoiceCode, @BookTitleCode, @NewBookNumber, @GoodsReceiveDay, @ShipmentCode, @GoodsReceivePlace)";

                    CheckQuery = 1;
                }

                if (CheckQuery == 0) // Nếu dữ kiện đưa vào là hoàn toàn mới
                {
                    // Gọi 2 hàm để insert dữ liệu vào bảng kho sách và hoá đơn
                    bookRepoManage.InsertBookRepo(InsertBookRepoQuery, BookTitleCodeTxb.Text, Convert.ToInt32(NewBookNumberNum.Value));
                    bookRepoManage.InsertInvoiceInfo(InsertInvoiceQuery, InvoiceCodeTxb.Text, BookTitleCodeTxb.Text, Convert.ToInt32(NewBookNumberNum.Value), GoodsReceivedDayDTP.Value, ShipmentCodeTxb.Text, GoodsReceivedPlaceTxb.Text);

                    MessageBox.Show("Add successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    AddNewBookRepoInfoRow(); // Gọi hàm add dữ liệu mới dc ng dùng thêm vào
                    ResetControl(); // Gọi hàm reset lại các control để ng dùng có thể nhập dữ liệu mới

                    return;
                }

                else if (CheckQuery == 1)
                {
                    Total = bookRepoManage.ReadBookTotalNumber(BookTitleCodeTxb.Text) + Convert.ToInt32(NewBookNumberNum.Value);

                    // Gọi 2 hàm để insert dữ liệu vào bảng kho sách và hoá đơn
                    bookRepoManage.InsertInvoiceInfo(InsertInvoiceQuery, InvoiceCodeTxb.Text, BookTitleCodeTxb.Text, Convert.ToInt32(NewBookNumberNum.Value), GoodsReceivedDayDTP.Value, ShipmentCodeTxb.Text, GoodsReceivedPlaceTxb.Text);
                    bookRepoManage.UpdateBookRepoInfo(InsertBookRepoQuery, BookTitleCodeTxb.Text, Total);

                    MessageBox.Show("Add successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    AddNewBookRepoInfoRow(); // Gọi hàm add dữ liệu mới dc ng dùng thêm vào
                    ResetControl(); // Gọi hàm reset lại các control để ng dùng có thể nhập dữ liệu mới

                    return;
                }
            }

            else if (CheckButton == 2 && CheckBookRepoInfo() == true)
            {
                updateInvoiceQuery = "update HOADON set MATUASACH = @BookTitleCode, SOLUONGNHAPMOI = @NewBookNumber, NGAYNHAP = @GoodsReceiveDay, MALOHANG = @ShipmentCode, NOINHAP = @GoodsReceivePlace where MAHOADON = @InvoiceCode";

                bookRepoManage.UpdateBookRepo(updateInvoiceQuery, InvoiceCodeTxb.Text, BookTitleCodeTxb.Text, Convert.ToInt32(NewBookNumberNum.Value), GoodsReceivedDayDTP.Value, ShipmentCodeTxb.Text, GoodsReceivedPlaceTxb.Text);

                MessageBox.Show("Update successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                AddBookRepoDataAndInvoiceDataToDG();
            }

            else if (CheckButton == 3)
            {
                if (InventoryQuantityNum.Visible == false)
                {
                    if (MessageBox.Show("Are you sure you want to delete", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteInvoiceQuery = "delete HOADON where MAHOADON = @InvoiceCode";

                        bookRepoManage.DeleteInvoiceInfo(deleteInvoiceQuery, InvoiceCodeTxb.Text);

                        MessageBox.Show("Delete successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        AddBookRepoDataAndInvoiceDataToDG();
                    }

                    else
                    {
                        return;
                    }
                }

                if (InventoryQuantityNum.Visible == true)
                {
                    if (MessageBox.Show("Are you sure you want to delete! If you accept all the books information in database will be deleted all!", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string deleteBookRepoDataQuery = "delete KHOSACH where MATUASACH = @BookTitleCode";
                        string deleteAllBookQuery = "delete from SACH where MATUASACH = @BookTitleCode";
                        string deleteAllInvoiceQuery = "delete from HOADON where MATUASACH = @BookTitleCode";

                        bookRepoManage.DeleteAllBookBelongToABookTitleCode(deleteAllBookQuery, BookTitleCodeTxb.Text);
                        bookRepoManage.DeleteAllInvoiceBelongToABookTitleCode(deleteAllInvoiceQuery, BookTitleCodeTxb.Text);
                        bookRepoManage.DeleteBookRepoData(deleteBookRepoDataQuery, BookTitleCodeTxb.Text);

                        MessageBox.Show("Delete successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        AddBookRepoDataAndInvoiceDataToDG();
                    }

                    else
                    {
                        return;
                    }
                }
            }
        }

        // Hàm để invisible các control khi ng dùng ấn nút để quay lại form chính
        private void InvisibleControl()
        {
            // Enable các nút chức năng 
            AddBookRepoButton.Enabled = true;
            EditBookRepoButton.Enabled = true;
            DeleteBookRepoButton.Enabled = true;
            BookRepoStatisticBut.Enabled = true;

            BookTitleCodeLb.Visible = false;
            BookTitleCodeTxb.Visible = false;
            NewBookNumLb.Visible = false;
            NewBookNumberNum.Visible = false;
            GoodsReceivedDayLb.Visible = false;
            GoodsReceivedDayDTP.Visible = false;
            ShipmentCodeLb.Visible = false;
            ShipmentCodeTxb.Visible = false;
            GoodsReceivedPlaceLb.Visible = false;
            GoodsReceivedPlaceTxb.Visible = false;
            InvoiceCodeLb.Visible = false;
            InvoiceCodeTxb.Visible = false;
            AddedBookRepoGB.Visible = false;

            if (CheckButton == 2 || CheckButton == 3)
            {
                ExistInvoiceDataGB.Visible = false;
                ExistBookRepoDataGB.Visible = false;
                BookTitleCodeTxb.Enabled = true;
                InvoiceCodeTxb.Enabled = true;
                NewBookNumberNum.Enabled = true;
                GoodsReceivedDayDTP.Enabled = true;
                ShipmentCodeTxb.Enabled = true;
                GoodsReceivedPlaceTxb.Enabled = true;
                InventoryQuantityNum.Visible = false;
                InventoryQuantityLb.Visible = false;

                SaveButton.BackgroundImage = new Bitmap(@"..\Debug\ButtonAndFormImage\Save Button.jpg");

            }

            if (CheckButton == 4)
            {
                ExistInvoiceDataGB.Visible = false;
                ExistBookRepoDataGB.Visible = false;

                InvoiceCodeFindTxb.Visible = false;
                InvoiceCodeFindLb.Visible = false;
                BookTitleCodeFindTxb.Visible = false;
                BookTitleCodeFindLb.Visible = false;
            }

            SaveButton.Visible = false;
            BackButton.Visible = false;
        }

        // Sự kiện khi người dùng ấn nút để quay lại form trc
        private void BackButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the form", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InvisibleControl();
                ResetControl();
            }

            else
            {
                return;
            }
        }

        //----------------------------------------------------------------------------------------------------------------//

        //-----------------------------------------------------Phần của nút sửa-------------------------------------------//

        GroupBox ExistInvoiceDataGB = new GroupBox(); // GroupBox để chứa Datagirdview chứa thông tin đang có kho sách và hoá đơn
        DataGridView ExistInvoiceDataDG = new DataGridView(); // Datagirdview để chứa thông tin đang có kho sách và hoá đơn
        GroupBox ExistBookRepoDataGB = new GroupBox(); // GroupBox và Datagridview chứa thông tin trong kho sách
        DataGridView ExistBookRepoDG = new DataGridView();

        // Hàm để khởi tạo groupbox dùng cho việc sữa dữ liệu
        private void CreateControl()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy


            ExistInvoiceDataGB.Size = AddedBookRepoGB.Size;
            ExistInvoiceDataGB.Location = new Point(145, 320);
            ExistInvoiceDataGB.Visible = false;
            ExistInvoiceDataGB.Text = "Dữ liệu đang có trong kho hoá đơn của kho sách";
            ExistInvoiceDataGB.Font = AddedBookRepoDG.Font;
            ExistInvoiceDataGB.BackColor = Color.Transparent;

            ExistInvoiceDataDG.Location = AddedBookRepoDG.Location;
            ExistInvoiceDataDG.Size = AddedBookRepoDG.Size;
            ExistInvoiceDataDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExistInvoiceDataDG.MultiSelect = false;
            ExistInvoiceDataDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ExistInvoiceDataDG.ReadOnly = true;
            ExistInvoiceDataDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            ExistInvoiceDataGB.Controls.Add(ExistInvoiceDataDG);

            //-----------------------------------------------------------------------------------------------------------//

            if (CheckButton == 2 || CheckButton == 3 || CheckButton == 4)
            {
                ExistInvoiceDataDG.RowEnter += ExistBookRepoDataDG_RowEnter;
            }

            if (CheckButton == 3 || CheckButton == 4)
            {
                ExistBookRepoDataGB.Location = new Point(145, 530);
                ExistBookRepoDataGB.Size = AddedBookRepoGB.Size;
                ExistBookRepoDataGB.Visible = false;
                ExistBookRepoDataGB.Text = "Hàng hoá có trong kho của nhà sách";
                ExistBookRepoDataGB.Font = AddedBookRepoGB.Font;
                ExistBookRepoDataGB.BackColor = Color.Transparent;

                ExistBookRepoDG.Location = AddedBookRepoDG.Location;
                ExistBookRepoDG.Size = AddedBookRepoDG.Size;
                ExistBookRepoDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ExistBookRepoDG.MultiSelect = false;
                ExistBookRepoDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ExistBookRepoDG.ReadOnly = true;
                ExistBookRepoDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                ExistBookRepoDG.RowEnter += ExistBookRepoDG_RowEnter;

                ExistBookRepoDataGB.Controls.Add(ExistBookRepoDG);

                this.Controls.Add(ExistBookRepoDataGB);
            }

            this.Controls.Add(ExistInvoiceDataGB);
        }

        // Hàm để enable các control dùng cho việc xoá dữ liệu trong kho sách
        private void VisibleControlFoDeleteBookRepoInfo()
        {
            // Enable các control dùng cho việc xoá dữ liệu trong kho sách
            InventoryQuantityLb.Visible = true;
            InventoryQuantityNum.Visible = true;
            InventoryQuantityLb.Location = NewBookNumLb.Location;
            InventoryQuantityNum.Location = new Point(278, 231);
            InventoryQuantityNum.Enabled = false;

            GoodsReceivedDayDTP.Visible = false;
            GoodsReceivedDayLb.Visible = false;
            GoodsReceivedPlaceLb.Visible = false;
            GoodsReceivedPlaceTxb.Visible = false;
            ShipmentCodeLb.Visible = false;
            ShipmentCodeTxb.Visible = false;
            InvoiceCodeLb.Visible = false;
            InvoiceCodeTxb.Visible = false;
            NewBookNumLb.Visible = false;
            NewBookNumberNum.Visible = false;
        }

        // Sự kiện khi người dùng ấn vào từng dòng của DG chứa thông tin kho sách
        private void ExistBookRepoDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != ExistBookRepoDG.RowCount - 1)
            {
                VisibleControlFoDeleteBookRepoInfo();

                ExistInvoiceDataDG.ClearSelection(); // Xoá các lựa chọn của datagridview còn lại để tránh việc thông tin bị chèn

                BookTitleCodeTxb.Text = ExistBookRepoDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                InventoryQuantityNum.Value = Convert.ToInt32(ExistBookRepoDG.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        // Sự kiện khi người dùng chọn 1 hàng trong datagridview
        private void ExistBookRepoDataDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != ExistInvoiceDataDG.RowCount - 1)
            {
                // Disable 2 control dùng cho việc xoá dữ kiệu kho sách
                InventoryQuantityLb.Visible = false;
                InventoryQuantityNum.Visible = false;

                VisibleControl(); // Visile lại các control dùng cho việc xoá dữ liệu trong hoá đơn

                ExistBookRepoDG.ClearSelection(); // Xoá các lựa chọn của datagridview còn lại để tránh việc thông tin bị chèn

                // Gán các giá trị tương ứng của hàng ng dùng chọn vào các control
                InvoiceCodeTxb.Text = ExistInvoiceDataDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                BookTitleCodeTxb.Text = ExistInvoiceDataDG.Rows[e.RowIndex].Cells[1].Value.ToString();
                NewBookNumberNum.Value = Convert.ToInt32(ExistInvoiceDataDG.Rows[e.RowIndex].Cells[2].Value);
                GoodsReceivedDayDTP.Value = Convert.ToDateTime(ExistInvoiceDataDG.Rows[e.RowIndex].Cells[3].Value);
                ShipmentCodeTxb.Text = ExistInvoiceDataDG.Rows[e.RowIndex].Cells[4].Value.ToString();
                GoodsReceivedPlaceTxb.Text = ExistInvoiceDataDG.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        // Hàm để add dữ liệu đang có trong kho sách và kho hoá đơn nhập hàng vào datagridview
        private void AddBookRepoDataAndInvoiceDataToDG()
        {
            string bookRepoQuery = "Select * from HOADON order by NGAYNHAP";
            string bookRepoDataQuery = "Select * from KHOSACH";

            ExistBookRepoDG.DataSource = bookRepoManage.ReadBookRepoDataFromDB(bookRepoDataQuery).Tables[0];
            ExistInvoiceDataDG.DataSource = bookRepoManage.ReadBookRepoData(bookRepoQuery).Tables[0];

            if (CheckButton == 3)
            {
                // Disable việc datgridview tự động focus vào dòng đầu tiên để tránh việc thông tin bị đưa lên trc
                ExistInvoiceDataDG.Rows[0].Selected = false;
                ExistBookRepoDG.Rows[0].Selected = false;
            }

            if(ExistBookRepoDG.DataSource == null || ExistBookRepoDG.DataSource == null)
            {
                ExistBookRepoDG = new DataGridView();
                ExistInvoiceDataDG = new DataGridView();

                return;
            }
        }

        // Hàm để sửa header hiển thị trong 
        private void SetHeaderTest()
        {
            if (CheckButton == 3 || CheckButton == 4)
            {
                ExistInvoiceDataDG.Columns[0].HeaderText = "Mã hoá đơn";
                ExistInvoiceDataDG.Columns[1].HeaderText = "Mã tựa sách";
                ExistInvoiceDataDG.Columns[2].HeaderText = "Số lượng nhập mới";
                ExistInvoiceDataDG.Columns[3].HeaderText = "Ngày nhập";
                ExistInvoiceDataDG.Columns[4].HeaderText = "Mã lô hàng";
                ExistInvoiceDataDG.Columns[5].HeaderText = "Nơi nhập hàng";

                ExistBookRepoDG.Columns[0].HeaderText = "Mã tựa sách";
                ExistBookRepoDG.Columns[1].HeaderText = "Số lượng tồn kho";
            }

        }

        // Sự kiên5 khi người dùng ấn nút sửa thông tin
        private void EditBookRepoButton_Click_1(object sender, EventArgs e)
        {
            CheckButton = 2;

            CreateControl(); // Gọi hàm để khởi tạo control dùng cho thao tác sửa dữ liệu
            VisibleControl(); // Gọi hàm để visible các control cần thiết cho việc sửa
            AddBookRepoDataAndInvoiceDataToDG(); // Gọi hàm để đưa dữ liệu đang có trong database của kho sách và sửa hiẻn thị của các headertext
            SetHeaderTest();
        }

        //---------------------------------------------------Phần của nút xoá--------------------------------------------//

        // Sự kiện khi người dùng án nút xoá
        private void DeleteBookRepoButton_Click_1(object sender, EventArgs e)
        {
            CheckButton = 3;

            CreateControl(); // Gọi hàm để khởi tạo control dùng cho thao tác sửa dữ liệu
            VisibleControl(); // Gọi hàm để visible các control cần thiết cho việc sửa
            AddBookRepoDataAndInvoiceDataToDG(); // Gọi hàm để đưa dữ liệu đang có trong database của kho sách và sửa hiẻn thị của các headertext
            SetHeaderTest();
        }

        //---------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------Phần của nút thống kê---------------------------------------------------//

        // Sự kiện khi người dùng ấn nút xem thống kê dữ liệu trong kho sách
        private void BookRepoStatisticBut_Click_1(object sender, EventArgs e)
        {
            CheckButton = 4;
            CreateControl(); // Gọi hàm để khởi tạo control dùng cho thao tác sửa dữ liệu
            VisibleControl(); // Gọi hàm để visible các control cần cho phần thống kê
            AddBookRepoDataAndInvoiceDataToDG(); // Gọi hàm để đưa dữ liệu đang có trong database của kho sách và sửa hiẻn thị của các headertext
            SetHeaderTest();
        }

        // Sự kiện khi người dùng nhập mã hoá đơn nhập hàng để tìm kiếm
        private void InvoiceCodeFindTxb_TextChanged(object sender, EventArgs e)
        {
            // Nếu ng dùng nhập mã hoá đơn nhập hàng để tìm kiếm 
            if (CheckButton == 4 && string.IsNullOrEmpty(InvoiceCodeFindTxb.Text) == false && string.IsNullOrWhiteSpace(InvoiceCodeFindTxb.Text) == false)
            {
                (ExistInvoiceDataDG.DataSource as DataTable).DefaultView.RowFilter = string.Format("MAHOADON LIKE '%{0}%'", InvoiceCodeFindTxb.Text);
            }

            // Ngược lại
            else if (CheckButton == 4 && string.IsNullOrEmpty(InvoiceCodeFindTxb.Text) == true && string.IsNullOrWhiteSpace(InvoiceCodeFindTxb.Text) == true)
            {
                AddBookRepoDataAndInvoiceDataToDG();
            }
        }
        // Sự kiện khi người dùng nhập mã tựa sách vào để xem số lượng
        private void BookTitleCodeFindTxb_TextChanged_1(object sender, EventArgs e)
        {

            if (CheckButton == 4 && string.IsNullOrEmpty(BookTitleCodeFindTxb.Text) == false && string.IsNullOrWhiteSpace(BookTitleCodeFindTxb.Text) == false)
            {
                (ExistBookRepoDG.DataSource as DataTable).DefaultView.RowFilter = string.Format("MATUASACH LIKE '%{0}%'", BookTitleCodeFindTxb.Text);
            }

            else if (CheckButton == 4 && string.IsNullOrEmpty(BookTitleCodeFindTxb.Text) == true && string.IsNullOrWhiteSpace(BookTitleCodeFindTxb.Text) == true)
            {
                AddBookRepoDataAndInvoiceDataToDG();
            }
        }
        //---------------------------------------------------------------------------------------------------------------//
    }
}

