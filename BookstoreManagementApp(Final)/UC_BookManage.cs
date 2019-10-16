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
using System.Globalization;

namespace BookstoreManagementApp_Final_
{
    public partial class UC_BookManage : UserControl
    {
        public UC_BookManage()
        {
            InitializeComponent();
            this.SetStyle(
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint |
               ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy

            SetControlBackColor(); // Set màu nền cho control để phù hợp với màu của form
        }
        //---------------------------------------------------------Phẩn của nút thêm----------------------------------------------------//

        // Hàm để set back color của các control cho hợp với màu của form
        private void SetControlBackColor()
        {
            BookStatisticDG.DataBindings.Add(nameof(DataGrid.BackgroundColor),
                                this,
                                nameof(Control.BackColor));
            AddedBookDG.DataBindings.Add(nameof(DataGrid.BackgroundColor),
                                this,
                                nameof(Control.BackColor));
        }

        int CheckButton = 0; // Biến để check xem thao tác nào đang dc ng dùng chọn để thực hiện lệnh query tương ứng

        // Hàm để set các control ẩn hiển thị lên (Dùng cho thêm, sửa và xoá)
        private void VisibleControl()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy

            // Disable 3 nút chức năng để tránh việc ng dùng ấn nhầm
            EditBookButton.Enabled = false;
            DeleteBookButton.Enabled = false;
            AddBookButton.Enabled = false;
            SearchButton.Enabled = false;

            // Visible các label, textbox,... để người dùng nhập thông tin sách
            BookIDLb.Visible = true;
            BookIDTxb.Visible = true;
            BookNameLb.Visible = true;
            BookNameTxb.Visible = true;
            BookAuthorNameLb.Visible = true;
            BookAuthorNameTxb.Visible = true;
            BookTranslatorNameLb.Visible = true;
            BookTranslatorNameTxb.Visible = true;
            BookPublishDateLb.Visible = true;
            BookPublishDateDTP.Visible = true;
            BookRepublishedTimeLb.Visible = true;
            BookRepublishedTimeNum.Visible = true;
            BookPriceLb.Visible = true;
            BookPriceNum.Visible = true;
            BookTypeLb.Visible = true;
            BookTypeTxb.Visible = true;
            BookTitleCodeLb.Visible = true;
            BookTitleCodeTxb.Visible = true;

            // Xét xem thao tác nào đang dc ng dùng chọn để hiển thị tương ứng
            if (CheckButton == 1)
            {
                AddedBookGB.Visible = true;
                AddedBookDG.Visible = true;
                BookStatisticGB.Visible = true;
                SaveButton.BackgroundImage = new Bitmap(@"..\Debug\ButtonAndFormImage\Save Button.jpg"); // Reset lại  hình ảnh của button trong trường hơp ng dùng vào phần xoá trc
            }

            else if (CheckButton == 2)
            {
                SaveButton.BackgroundImage = new Bitmap(@"..\Debug\ButtonAndFormImage\Save Button.jpg"); // Reset lại  hình ảnh của button trong trường hơp ng dùng vào phần xoá trc
                BookIDTxb.Enabled = false; // Disable textbox chứa khoá chính để ng dùng ko thể sửa khoá chính

                CreateControl(); // Gọi hàm khổi tạo control dùng cho phần sửa
            }

            SaveButton.Visible = true;

            if (CheckButton == 3)
            {
                CreateControl(); // Gọi hàm khổi tạo control dùng cho phần sửa

                // disble các ô textbox để tránh ng dùng sửa thông tin sách
                BookIDTxb.Enabled = false;
                BookNameTxb.Enabled = false;
                BookAuthorNameTxb.Enabled = false;
                BookTranslatorNameTxb.Enabled = false;
                BookPublishDateDTP.Enabled = false;
                BookRepublishedTimeNum.Enabled = false;
                BookPriceNum.Enabled = false;
                BookTypeTxb.Enabled = false;
                BookTitleCodeTxb.Enabled = false;

                SaveButton.BackgroundImage = new Bitmap(@"..\Debug\ButtonAndFormImage\DeleteBook.png");
            }

            if (CheckButton == 4)
            {
                // Biến để lưu lại vị trí cũ của 2 control chứa mã tựa sách để sử dụng đổi chỗ sử dụng cho phần tìm kiếm
                Point OldBookTitleCodeLabelLoca = new Point(BookTitleCodeLb.Location.X, BookTitleCodeLb.Location.Y);
                Point OldBookTitleCodeTxbLoca = new Point(BookTitleCodeTxb.Location.X, BookTitleCodeTxb.Location.Y);

                CreateControl(); // Gọi hàm để tạo control dùng cho việc tìm kiếm

                BookStatisticGB.Visible = false;
                AddedBookGB.Visible = false;

                SaveButton.Visible = false;
                BackButton.Location = SaveButton.Location;

                BookIDTxb.Enabled = false;
                BookTitleCodeTxb.Enabled = false;
                BookNameTxb.Enabled = false;
                BookAuthorNameTxb.Enabled = false;
                BookTranslatorNameTxb.Enabled = false;
                BookPublishDateDTP.Enabled = false;
                BookRepublishedTimeNum.Enabled = false;
                BookPriceNum.Enabled = false;
                BookTypeTxb.Enabled = false;

                // Visible control để ng dùng nhập filter
                BookIDFilterTxb.Visible = true;
                BookIDFilterLb.Visible = true;

                BookTitleCodeLb.Location = BookRepublishedTimeLb.Location;
                BookTitleCodeTxb.Location = BookRepublishedTimeNum.Location;

                BookRepublishedTimeLb.Location = OldBookTitleCodeLabelLoca;
                BookRepublishedTimeNum.Location = OldBookTitleCodeTxbLoca;
            }

            BackButton.Visible = true;
        }

        // Sự kiện khi người dùng ấn nút để thêm sách
        private void AddBookButton_Click_1(object sender, EventArgs e)
        {
            CheckButton = 1; // Gán biến check nút để biết là thao tác thêm sách đang dc chọn

            // Gọi hàm để visible các control trong phần thêm sách
            VisibleControl();
        }

        // Hàm để reset lại ErrorProvider để set lỗi ở vị trí gần nhất
        private void ResetErrorProvider()
        {
            ErrorPlace.SetError(BookIDTxb, "");
            ErrorPlace.SetError(BookNameTxb, "");
            ErrorPlace.SetError(BookAuthorNameTxb, "");
            ErrorPlace.SetError(BookTranslatorNameTxb, "");
            ErrorPlace.SetError(BookPriceNum, "");
            ErrorPlace.SetError(BookTypeTxb, "");
            ErrorPlace.SetError(BookTitleCodeTxb, "");
        }

        BookManage_BUS bookManage = new BookManage_BUS(); // Khai báo đối tượng thuộc lớp BUS để tương tác với phần thêm sách trên giao diện

        // Hàm để check thông tin của sách xem đã dc nhập đầy đủ hay chưa
        private bool CheckBookInfo()
        {
            ResetErrorProvider(); // Gọi hàm reset lại ErrorProvider để set lỗi ở vị trí gần nhất

            // Xét xem thông tin phần nào bị thiếu và xuất ra thông báo lỗi
            if (string.IsNullOrEmpty(BookIDTxb.Text) == true || string.IsNullOrWhiteSpace(BookIDTxb.Text) == true)
            {
                ErrorPlace.SetError(BookIDTxb, "Vui lòng nhập mã sách");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookIDTxb, "");
            }

            // Kiểm tra xem mã sách nhập vào đã tồn tại hay chưa
            if (bookManage.CheckBookID(BookIDTxb.Text) == false && CheckButton == 1)
            {
                ErrorPlace.SetError(BookIDTxb, "Mã sách đã tồn tại! Vui lòng kiểm tra lại!");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookIDTxb, "");
            }

            if (string.IsNullOrEmpty(BookNameTxb.Text) == true || string.IsNullOrWhiteSpace(BookNameTxb.Text) == true)
            {
                ErrorPlace.SetError(BookNameTxb, "Vui lòng nhập tên sách");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookNameTxb, "");
            }

            if (string.IsNullOrEmpty(BookAuthorNameTxb.Text) == true || string.IsNullOrWhiteSpace(BookAuthorNameTxb.Text) == true)
            {
                ErrorPlace.SetError(BookAuthorNameTxb, "Vui lòng nhập tên tác giả");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookAuthorNameTxb, "");
            }

            if (string.IsNullOrEmpty(BookTranslatorNameTxb.Text) == true || string.IsNullOrWhiteSpace(BookTranslatorNameTxb.Text) == true)
            {
                ErrorPlace.SetError(BookTranslatorNameTxb, "Vui lòng nhập tên dịch giả, Nếu không có thì vui lòng nhập 'không có' ");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookTranslatorNameTxb, "");
            }

            if (BookPriceNum.Value == 0)
            {
                ErrorPlace.SetError(BookPriceNum, "Vui lòng nhập giá sản phẩm");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookPriceNum, "");
            }

            if (string.IsNullOrEmpty(BookTypeTxb.Text) == true || string.IsNullOrWhiteSpace(BookTypeTxb.Text) == true)
            {
                ErrorPlace.SetError(BookTypeTxb, "Vui lòng nhập thể loại sách");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookTypeTxb, "");
            }

            if (string.IsNullOrEmpty(BookTitleCodeTxb.Text) == true || string.IsNullOrWhiteSpace(BookTitleCodeTxb.Text) == true)
            {
                ErrorPlace.SetError(BookTitleCodeTxb, "Vui lòng nhập mã loại sách");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookTitleCodeTxb, "");
            }

            if (bookManage.CheckBookTitleCode(BookTitleCodeTxb.Text) == false)
            {
                ErrorPlace.SetError(BookTitleCodeTxb, "Mã loại sách không tồn tại! Vui lòng kiểm tra lại!");

                return false;
            }

            else // Nếu ko còn lỗi
            {
                ErrorPlace.SetError(BookTitleCodeTxb, "");
            }

            return true;
        }

        // Hàm để thêm sách vừa mới nhập vào hàng mới
        private void AddNewBookRow()
        {
            // Khai báo 1 hàng mới cho datagridview và thêm thông tin cho hàng đó
            DataGridViewRow newBook = (DataGridViewRow)AddedBookDG.Rows[AddedBookDG.RowCount - 1].Clone();

            newBook.Cells[0].Value = BookIDTxb.Text;
            newBook.Cells[1].Value = BookNameTxb.Text;
            newBook.Cells[2].Value = BookAuthorNameTxb.Text;
            newBook.Cells[3].Value = BookTranslatorNameTxb.Text;
            newBook.Cells[4].Value = BookPublishDateDTP.Value;
            newBook.Cells[5].Value = BookRepublishedTimeNum.Value;
            newBook.Cells[6].Value = BookPriceNum.Value;
            newBook.Cells[7].Value = BookTypeTxb.Text;
            newBook.Cells[8].Value = BookTitleCodeTxb.Text;

            // Sau khi thêm thì add hàng đó vào datagridview
            AddedBookDG.Rows.Add(newBook);
        }

        // Hàm để rest lại các control sau khi nhập sách thành công
        private void ResetControl()
        {
            // Reset lại giá trị mặc định của các control
            BookIDTxb.Text = "";
            BookNameTxb.Text = "";
            BookAuthorNameTxb.Text = "";
            BookTranslatorNameTxb.Text = "";
            BookPublishDateDTP.Value = DateTime.Today;
            BookRepublishedTimeNum.Value = 0;
            BookPriceNum.Value = 0;
            BookTypeTxb.Text = "";
            BookTitleCodeTxb.Text = "";
        }

        bool CheckAddBook = false; // Biến để check xem sách đã dc thêm vào thành công hay chưa
        List<string> BookTitleCodeAdded = new List<string>(); // Danh sách các mã sách hiện có thống kê để hiển thị lên datagridview
        bool CheckNew = false; // Biến để check xem các mã sách mới nhập có trùng với mã đã add hay ko
        bool CheckExist = false; // // Biến để check xem các mã sách đã có có trùng với mã sách mới nhập hay ko (trong TH đã tồn tại)
        int rowIndex; // Biến đễ lưu lại dòng có mã tựa sách trùng

        // Hàm để thống kê theo từng số lượng mã sách mà người dùng đã nhập
        private void BookTitleCodeStatistic()
        {
            if (CheckAddBook == true)
            {
                // Nếu chưa có mã sách nào dc add
                if (BookStatisticDG.RowCount == 1)
                {
                    DataGridViewRow newBookTitleCode = (DataGridViewRow)BookStatisticDG.Rows[BookStatisticDG.RowCount - 1].Clone(); // Tạo ra 1 hàng mới để add vào datagridview

                    newBookTitleCode.Cells[0].Value = BookTitleCodeTxb.Text;
                    newBookTitleCode.Cells[1].Value = 1;

                    BookStatisticDG.Rows.Add(newBookTitleCode); // Add mã sách mới vào datagridview

                    BookTitleCodeAdded.Add(BookTitleCodeTxb.Text); // Thêm mã sách mới vào danh sách

                    return; // Kết thúc hàm để tránh trường hợp lặp lại với CheckNew
                }


                // Vòng lặp để xét mã sách mới nhập với các mã sách đã lưu trc đó
                for (int i = 0; i < BookTitleCodeAdded.Count; i++)
                {
                    if (string.Equals(BookTitleCodeTxb.Text.ToLower(), BookTitleCodeAdded[i].ToLower()) == false)
                    {
                        CheckNew = true;
                    }

                    else if (string.Equals(BookTitleCodeTxb.Text.ToLower(), BookTitleCodeAdded[i].ToLower()) == true)
                    {
                        CheckExist = true;
                        rowIndex = i;
                        break;
                    }
                }
            }
        }

        // Hàm để đếm sách theo từng mã tựa sách
        private void BookCount()
        {
            int Total;

            // Nếu có mã sách mới thì thêm vào bảng
            if (CheckNew == true)
            {
                DataGridViewRow newBookTitleCode = (DataGridViewRow)BookStatisticDG.Rows[BookStatisticDG.RowCount - 1].Clone(); // Tạo ra 1 hàng mới để add vào datagridview

                newBookTitleCode.Cells[0].Value = BookTitleCodeTxb.Text; // Lấy mã sách mới gán vào hàng trong bảng và gán gi1 trị ban đầu
                newBookTitleCode.Cells[1].Value = 1;

                BookStatisticDG.Rows.Add(newBookTitleCode); // Thêm hàng mới vào bảng

                BookTitleCodeAdded.Add(BookTitleCodeTxb.Text); // Thêm mã mới vào danh sách

                CheckNew = false;
            }

            // Xét xem sách đã add thành công hay chưa
            if (CheckAddBook == true)
            {
                if (CheckExist == true) // Nếu mã sách đó đã tồn tại
                {
                    Total = Convert.ToInt32(BookStatisticDG.Rows[rowIndex].Cells[1].Value) + 1; // Nếu có thì chuyển đổi số lượng về int để tăng

                    BookStatisticDG.Rows[rowIndex].Cells[1].Value = Total;

                    CheckExist = false;
                }

            }

            CheckAddBook = false; // Reset lại biến để check sách đã dc add hay chưa
        }

        // Sự kiện khi người dùng ấn nút để save thông tin sách đã nhập
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            // Xét xem người dùng ấn nút lưu khi đang chọn thao tác nào (Thêm, sửa hoặc xoá)
            if (CheckButton == 1)
            {
                if (CheckBookInfo() == true) // Gọi hàm để check xem thông tin sách đã dc nhập đúng hay chưa
                {
                    string insertQuery = "insert into SACH values(@BookID, @BookName, @BookAuthor, @BookTranslator, @BookPublishDay, @BookRepublishedTime, @BookPrice, @BookType, @BookTitleCode)";

                    // Gọi hàm để insert sahch1 vào database
                    bookManage.InsertBook(insertQuery, BookIDTxb.Text, BookNameTxb.Text, BookAuthorNameTxb.Text, BookTranslatorNameTxb.Text, BookPublishDateDTP.Value, Convert.ToInt32(BookRepublishedTimeNum.Value), Convert.ToInt32(BookPriceNum.Value), BookTypeTxb.Text, BookTitleCodeTxb.Text);

                    CheckAddBook = true; // Gán biến xác định là đã add sách để có thể xác định thống kê mã sách

                    // Hiện thông báo đã thêm thành công
                    MessageBox.Show("Add successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BookTitleCodeStatistic(); // Gọi hàm để thống kê mã tựa sách để add vào bảng
                    BookCount(); // Gọi hàm để đếm số lượng của từng mã sách đã nhập

                    AddNewBookRow(); // Gọi hàm để thêm thông tin cuốn sách vừa add vào datagridview

                    ResetControl(); // Gọi hàm để reset giá trị mặc định lại cho các control
                }
            }

            else if (CheckButton == 2) // Nếu người dùng chọn nút sửa sách
            {
                if (CheckBookInfo() == true)
                {
                    string updateQuery = "update SACH set TENSACH = @BookName, TENTG = @BookAuthor, DICHGIA = @BookTranslator, NGAYXB = @BookPublishDay, LANTAIBAN = @BookRepublishedTime, GIA = @BookPrice, THELOAI = @BookType, MATUASAcH = @BookTitleCode where MASACH = @BookID";

                    bookManage.UpdateBook(updateQuery, BookIDTxb.Text, BookNameTxb.Text, BookAuthorNameTxb.Text, BookTranslatorNameTxb.Text, BookPublishDateDTP.Value, Convert.ToInt32(BookRepublishedTimeNum.Value), Convert.ToInt32(BookPriceNum.Value), BookTypeTxb.Text, BookTitleCodeTxb.Text); // Gọi hàm để update sách vào database

                    // Hiện thông báo đã thêm thành công
                    MessageBox.Show("Update successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    AddBookDataToDG(); // Gọi lại hàm để đọc lại database và đưa vào bảng
                }
            }

            else // Nếu ng dùng chọn nút xoá sách
            {
                string deleteQuery = "delete from SACH where MASACH = @BookID";

                bookManage.DeleteBook(deleteQuery, BookIDTxb.Text);

                // Hiện thông báo đã thêm thành công
                MessageBox.Show("Delete successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                AddBookDataToDG(); // Gọi lại hàm để đọc lại database và đưa vào bảng
            }
        }

        // Hàm để reset lại các textbox để thành textbox rỗng (dùng khi ng dùng ấn nút back)
        private void CleanTextBoxText()
        {
            BookIDTxb.Text = "";
            BookNameTxb.Text = "";
            BookAuthorNameTxb.Text = "";
            BookTranslatorNameTxb.Text = "";
            BookPublishDateDTP.Value = DateTime.Today;
            BookRepublishedTimeNum.Value = 0;
            BookPriceNum.Value = 0;
            BookTypeTxb.Text = "";
            BookTitleCodeTxb.Text = "";
            BookIDFilterTxb.Text = "";
        }

        // Hàm để disable các textbox, label,... khi người dùng ấn nút back
        private void InvisibleControl()
        {
            // Disable 3 nút chức năng để tránh việc ng dùng ấn nhầm
            EditBookButton.Enabled = true;
            DeleteBookButton.Enabled = true;
            AddBookButton.Enabled = true;
            SearchButton.Enabled = true;

            // Visible các label, textbox,... để người dùng nhập thông tin sách
            BookIDLb.Visible = false;
            BookIDTxb.Visible = false;
            BookNameLb.Visible = false;
            BookNameTxb.Visible = false;
            BookAuthorNameLb.Visible = false;
            BookAuthorNameTxb.Visible = false;
            BookTranslatorNameLb.Visible = false;
            BookTranslatorNameTxb.Visible = false;
            BookPublishDateLb.Visible = false;
            BookPublishDateDTP.Visible = false;
            BookRepublishedTimeLb.Visible = false;
            BookRepublishedTimeNum.Visible = false;
            BookPriceLb.Visible = false;
            BookPriceNum.Visible = false;
            BookTypeLb.Visible = false;
            BookTypeTxb.Visible = false;
            BookTitleCodeLb.Visible = false;
            BookTitleCodeTxb.Visible = false;
            AddedBookGB.Visible = false;
            BookStatisticGB.Visible = false;
            ExistBookGB.Visible = false;
            SaveButton.Visible = false;
            BackButton.Visible = false;
            BookIDFilterLb.Visible = false;
            BookIDFilterTxb.Visible = false;
        }

        // Sự kiện khi người dùng ấn nút Back để quay lại
        private void BackButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xét nếu chức năng đang chọn là thêm sách
                if (CheckButton == 1)
                {
                    // Clear các dòng đang hiển thị trong bảng datagridview
                    if (AddedBookDG.Rows.Count != 0)
                    {
                        AddedBookDG.Rows.Clear();
                    }

                    if (BookStatisticDG.Rows.Count != 0)
                    {
                        BookStatisticDG.Rows.Clear();
                    }

                    CleanTextBoxText(); // Reset lại các textbox để thành TextBox rỗng
                    InvisibleControl(); // Enable lại các nút chọn thao tác và disable các label, textbox,...
                }

                // Xét nếu chức năng đang chọn là sửa sách
                else if (CheckButton == 2)
                {
                    // Clear các dòng đang hiển thị trong bảng datagridview
                    if (ExistBookDG.Rows.Count != 0)
                    {
                        ExistBookDG.DataSource = null; // Xoá dữ liệu đang có trong bảng
                    }

                    CleanTextBoxText(); // Reset lại các textbox để thành TextBox rỗng
                    InvisibleControl(); // Enable lại các nút chọn thao tác và disable các label, textbox,...
                    BookIDTxb.Enabled = true; // Reset lại trạng thái của textbox chứa mã sách
                }

                else if (CheckButton == 3 || CheckButton == 4)
                {
                    // Clear các dòng đang hiển thị trong bảng datagridview
                    if (ExistBookDG.Rows.Count != 0)
                    {
                        ExistBookDG.DataSource = null; // Xoá dữ liệu đang có trong bảng
                    }

                    CleanTextBoxText(); // Reset lại các textbox để thành TextBox rỗng
                    InvisibleControl(); // Enable lại các nút chọn thao tác và disable các label, textbox,...

                    BookIDTxb.Enabled = true; // Reset lại trạng thái của textbox chứa mã sách
                    BookIDTxb.Text = "";

                    BookNameTxb.Enabled = true;
                    BookAuthorNameTxb.Enabled = true;
                    BookTranslatorNameTxb.Enabled = true;
                    BookPublishDateDTP.Enabled = true;
                    BookRepublishedTimeNum.Enabled = true;
                    BookPriceNum.Enabled = true;
                    BookTypeTxb.Enabled = true;
                    BookTitleCodeTxb.Enabled = true;
                }
            }

            ResetErrorProvider(); // Gọi hàm reset lại error provider trong TH ng dùng bị lỗi trc đó và muốn quay lại
        }
        // Sự kiện khi người dùng đã nhập xong tên sách và tên sách sẽ dc chỉnh thành chuỗi cho đúng chuẩn
        private void BookNameTxb_Validated_1(object sender, EventArgs e)
        {
            // Sửa chuỗi thành chuỗi chuẩn
            BookNameTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BookNameTxb.Text.ToLower());
        }

        // Sự kiện khi người dùng đã nhập xong tên tác giả và tên tác giả sẽ dc chỉnh thành chuỗi cho đúng chuẩn
        private void BookAuthorNameTxb_Validated_1(object sender, EventArgs e)
        {
            // Sửa chuỗi thành chuỗi chuẩn
            BookAuthorNameTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BookAuthorNameTxb.Text.ToLower());
        }

        // Sự kiện khi người dùng đã nhập xong tên dịch giả và tên dịch giả sẽ dc chỉnh thành chuỗi cho đúng chuẩn
        private void BookTranslatorNameTxb_Validated_1(object sender, EventArgs e)
        {
            // Sửa chuỗi thành chuỗi chuẩn
            BookTranslatorNameTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BookTranslatorNameTxb.Text.ToLower());
        }

        // Sự kiện khi người dùng đã nhập xong thể loại của sách và thể loại sách sẽ dc chỉnh thành chuỗi cho đúng chuẩn

        private void BookTypeTxb_Validated(object sender, EventArgs e)
        {
            // Sửa chuỗi thành chuỗi chuẩn
            BookTypeTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BookTypeTxb.Text.ToLower());
        }

    //------------------------------------------------------------------------------------------------------------------------------//

    //--------------------------------------------------------Phần của nút thêm-----------------------------------------------------//

    GroupBox ExistBookGB = new GroupBox(); //GruopBox chứa bảng datagridview các cuốn sách hiện đang có trong database
        DataGridView ExistBookDG = new DataGridView(); // Bảng datagridview chứa các cuốn sách hiện đang có trong database

        // Sự kiện khi người dùng ấn vào nút để sửa sách
        private void EditBookButton_Click_1(object sender, EventArgs e)
        {
            CheckButton = 2; // Gán biến check nút để biết là thao tác thêm sách đang dc chọn

            VisibleControl(); // Gọi hàm để hiển thị các control cần thiết

            AddBookDataToDG(); // Gọi hàm đọc dữ liệu để gán vào bảng

            SetHeaderText(); // Gọi hàm để chỉnh lại các header text của các cột trong datagridview
        }

        BookManage_BUS readBookData = new BookManage_BUS(); // Đối tượng để gọi hàm đọc thông tin sách
        // Hàm để add data sách vào datagridview
        private void AddBookDataToDG()
        {
            ExistBookDG.DataSource = readBookData.ReadBookFromDatabase().Tables[0];

            if(ExistBookDG.DataSource == null)
            {
                ExistBookDG = new DataGridView();

                return;
            }
        }

        private void SetHeaderText() // Hàm để sửa header text của các column khi đọc dữ liệu từ database
        {
            ExistBookDG.Columns[0].HeaderText = "Mã sách";
            ExistBookDG.Columns[1].HeaderText = "Tên sách";
            ExistBookDG.Columns[2].HeaderText = "Tên tác giả";
            ExistBookDG.Columns[3].HeaderText = "Dịch giả";
            ExistBookDG.Columns[4].HeaderText = "Ngày xuất bản";
            ExistBookDG.Columns[5].HeaderText = "Lần tái bản";
            ExistBookDG.Columns[6].HeaderText = "Giá";
            ExistBookDG.Columns[7].HeaderText = "Thể loại";
            ExistBookDG.Columns[8].HeaderText = "Mã tựa sách";
        }

        private void CreateControl() // Hàm để khởi tạo các control cho phần sửa
        {
            // Khởi tạo cho datagridview mới và groupbox mới để chứa thông tin của các cuốn sách có trong database
            ExistBookGB.Location = new Point(AddedBookGB.Location.X, 400);
            ExistBookGB.Size = new Size(AddedBookGB.Size.Width, 400);
            ExistBookGB.Text = "Dữ liệu sách đang có trong nhà sách";
            ExistBookGB.Visible = true;
            ExistBookGB.Font = AddedBookDG.Font;

            ExistBookDG.Location = new Point(AddedBookDG.Location.X, 50);
            ExistBookDG.Size = AddedBookDG.Size;
            ExistBookDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExistBookDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ExistBookDG.AllowUserToAddRows = false;
            ExistBookDG.ReadOnly = true;
            ExistBookDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExistBookDG.MultiSelect = false;
            ExistBookDG.RowEnter += ExistBookDG_RowEnter;
            ExistBookGB.Controls.Add(ExistBookDG);
            this.Controls.Add(ExistBookGB);
        }

        // Sự kiện khi người dùng ấn chọn 1 dòng bất kì trong datagridview
        private void ExistBookDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Gán các giá trị tương ứng vào cho các control
            BookIDTxb.Text = ExistBookDG.Rows[e.RowIndex].Cells[0].Value.ToString();
            BookNameTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ExistBookDG.Rows[e.RowIndex].Cells[1].Value.ToString().ToLower());
            BookAuthorNameTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ExistBookDG.Rows[e.RowIndex].Cells[2].Value.ToString().ToLower());
            BookTranslatorNameTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ExistBookDG.Rows[e.RowIndex].Cells[3].Value.ToString().ToLower());
            BookPublishDateDTP.Value = Convert.ToDateTime(ExistBookDG.Rows[e.RowIndex].Cells[4].Value.ToString());
            BookRepublishedTimeNum.Value = Convert.ToInt32(ExistBookDG.Rows[e.RowIndex].Cells[5].Value.ToString());
            BookPriceNum.Value = Convert.ToInt32(ExistBookDG.Rows[e.RowIndex].Cells[6].Value.ToString());
            BookTypeTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ExistBookDG.Rows[e.RowIndex].Cells[7].Value.ToString().ToLower());
            BookTitleCodeTxb.Text = ExistBookDG.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        //------------------------------------------------------------------------------------------------------------------------------//

        //-----------------------------------------------------Phần của nút xoá----------------------------------------------//

        private void DeleteBookButton_Click_1(object sender, EventArgs e)
        {
        CheckButton = 3; // Gán phần nút check là đang thao tác với nút xoá

            VisibleControl(); // Gọi hàm để hiển thị các control cần thiết

            AddBookDataToDG(); // Gọi hàm đọc dữ liệu để gán vào bảng

            SetHeaderText(); // Gọi hàm để chỉnh lại các header text của các cột trong datagridview
        }

        //-----------------------------------------------------Phần của nút tìm kiếm----------------------------------------------//

        // Sự kiện nếu người dùng ấn nút tìm kiếm
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            CheckButton = 4; // Gán phần nút check là đang thao tác với nút xoá

            VisibleControl(); // Gọi hàm để hiển thị các control cần thiết

            AddBookDataToDG(); // Gọi hàm đọc dữ liệu để gán vào bảng

            SetHeaderText(); // Gọi hàm để chỉnh lại các header text của các cột trong datagridview
        }

        // Sự kiện khi người dùng thay đổi textbox để tìm kiếm thông tin mã sách
        private void BookIDFilterTxb_TextChanged_1(object sender, EventArgs e)
        {
            // Nếu ng dùng đã nhập filter
            if (CheckButton == 4 && string.IsNullOrEmpty(BookIDFilterTxb.Text) == false && string.IsNullOrWhiteSpace(BookIDFilterTxb.Text) == false && BookIDFilterTxb.Focused == true)
            {
                (ExistBookDG.DataSource as DataTable).DefaultView.RowFilter = string.Format("MASACH LIKE '%{0}%'", BookIDFilterTxb.Text);
            }

            // Ngược lại
            else if (CheckButton == 4 && string.IsNullOrEmpty(BookIDFilterTxb.Text) == true && string.IsNullOrWhiteSpace(BookIDFilterTxb.Text) == true)
            {
                AddBookDataToDG(); // Gọi lại hàm để đọc dữ liệu có trong database
            }
        }

        private void UC_BookManage_Load(object sender, EventArgs e)
        {

        }
    }
}
