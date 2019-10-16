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
    public partial class UC_SaleForm : UserControl
    {
        public UC_SaleForm()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy

            // Khởi tạo sự kiện cho 2 nút Back và thanh toán
            PaymentButton.Click += PaymentButton_Click;

            CreateButtonControl(); // Gọi hàm để visible các nút dùng cho việc bán sách

            VisibleControl(); // Gọi hàm để visible các control để dùng cho việc bán sách

            giveBackItemPosition = EnteredProductDG.RowCount - 1; // Set giá trị mặc định ban đầu để tránh việc ấn hoàn trả sớm có thể thực thi
            //VINH LÀM
            prntOderBtn.Visible = false;
            prntOderBtn.Enabled = false;
            PrntPreviewBtn.Enabled = false;
            PrntPreviewBtn.Visible = false;
            //
        }
        private AccessorySale_BUS AccessorySale = new AccessorySale_BUS();
        private BookSaleManage_BUS bookSaleManage = new BookSaleManage_BUS(); // Biến để sử dụng tương tác với các thao tác từ user
        int CheckButton = 0; // Biến để check xem thao tác nào đang dc chọn
        List<string> bookCodeList = new List<string>(); // List để lưu các mã sách đã bán để update vào database
        List<string> bookTitleCodeList = new List<string>(); // List để lưu các mã tựa sách đã bán để trừ số lượng vào kho sách
        //VINH LÀM
        List<string> AccessoryIDList = new List<string>(); //List để lưu các mã sản phẩm đã bán để update vào database
        List<string> AccessoryTypeIDList = new List<string>(); //List để lưu các mã tựa sách đã bán để trừ số lượng vào kho văn phòng phẩm
        List<ItemCart> GIOHANG = new List<ItemCart>(); //List để lưu lại các sản phẩm dc chọn trong giỏ hàng 
        //
        int giveBackItemPosition; // Biến để lưu lại vị trí của sản phẩm mà người dùng muốn hoàn trả

        private void VisibleControl()
        {
            // Disable các nút chọn thao tác để add các nút chức năng cần thiết


            BookCodeLb.Visible = true;
            BookCodeTxb.Visible = true;
            BookTitleCodeLb.Visible = true;
            BookTitleCodeTxb.Visible = true;
            SubmitButton.Visible = true;
            GiveBackButton.Visible = true;
            EnteredProductGB.Visible = true;
            PaidProductGB.Visible = true;
            CusPaymentAmountLb.Visible = true;
            CusPaymentAmountNum.Visible = true;
            DiscountRateLb.Visible = true;
            DiscountRateNum.Visible = true;

            if (CheckButton == 1)
            {
                PaymentButton.Visible = true;

            }
        }

        // Hàm để khởi tạo 2 nút Payment và back
        private void CreateButtonControl()
        {
            PaymentButton.Location = BookSaleButton.Location;
            PaymentButton.Size = BookSaleButton.Size;
            PaymentButton.BackgroundImage = new Bitmap(@"..\Debug\ButtonAndFormImage\PaymentButton.png");
            PaymentButton.BackgroundImageLayout = ImageLayout.Stretch;
            PaymentButton.Visible = true;
            PaymentButton.FlatStyle = FlatStyle.Popup;



            this.Controls.Add(PaymentButton);

        }

        // Hàm để disable các control khi ng dùng ấn nút back
        private void InvisibleControl()
        {
            // Disable các nút chọn thao tác để add các nút chức năng cần thiết
            BookSaleButton.Visible = true;

            BookCodeLb.Visible = false;
            BookCodeTxb.Visible = false;
            BookTitleCodeLb.Visible = false;
            BookTitleCodeTxb.Visible = false;
            SubmitButton.Visible = false;
            GiveBackButton.Visible = false;
            EnteredProductGB.Visible = false;
            PaidProductGB.Visible = false;
            CusPaymentAmountNum.Visible = true;
            PaymentButton.Visible = false;

            CusPaymentAmountNum.Visible = false;
            CusPaymentAmountNum.Enabled = false;
            CusPaymentAmountLb.Visible = false;
            DiscountRateNum.Visible = false;
            DiscountRateLb.Visible = false;
            BookCodeTxb.Enabled = false; // Reset lại mặc định cho 2 textbox để nhập mã sách và mã tựa sách
            BookTitleCodeTxb.Enabled = false;

            if (EnteredProductDG.RowCount != 0)
            {
                EnteredProductDG.Rows.Clear();
            }

            if (PaidProductDG.RowCount != 0)
            {
                PaidProductDG.Rows.Clear();
            }
        }

        // Hàm để check thông tin của sản phẫm bán ng dùng nhập có đúng hay không
        private bool CheckSaleInfo()
        {
            if (string.IsNullOrEmpty(BookCodeTxb.Text) == true || string.IsNullOrWhiteSpace(BookCodeTxb.Text) == true)
            {
                errorPlaceEP.SetError(BookCodeTxb, "Vui lòng nhập mã sách hoặc mã sản phẩm!");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(BookCodeTxb, "");
            }

            if (bookSaleManage.CheckBookCode(BookCodeTxb.Text) == false && AccessorySale.CheckAccessoryID(BookCodeTxb.Text) == false)
            {
                errorPlaceEP.SetError(BookCodeTxb, "Mã sách hoặc mã sản phẩm không tồn tại! Vui lòng kiểm tra lại!");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(BookCodeTxb, "");
            }

            if (CheckBookCodeInDG() == false)
            {
                errorPlaceEP.SetError(BookCodeTxb, " Mã sách hoặc mã sản phẩm đã được nhập! Vui lòng kiểm tra lại");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(BookCodeTxb, "");
            }

            if (string.IsNullOrEmpty(BookTitleCodeTxb.Text) == true || string.IsNullOrWhiteSpace(BookTitleCodeTxb.Text) == true)
            {
                errorPlaceEP.SetError(BookTitleCodeTxb, "Vui lòng nhập mã tựa sách hoặc mã loại sản phẩm!");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(BookTitleCodeTxb, "");
            }

            if (bookSaleManage.CheckBookTitleCode(BookTitleCodeTxb.Text) == false && AccessorySale.CheckAccessoryTypeID(BookTitleCodeTxb.Text) == false)
            {
                errorPlaceEP.SetError(BookTitleCodeTxb, "Mã tựa sách hoặc mã loại sản phẩm không tồn tại! Vui lòng kiểm tra lại");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(BookTitleCodeTxb, "");
            }

            if (bookSaleManage.CheckBookTitleCodeReferenceWithBookCode(BookTitleCodeTxb.Text, BookCodeTxb.Text) == false && AccessorySale.CheckAccessoryIDReferencesTypeID(BookTitleCodeTxb.Text, BookCodeTxb.Text) == false)
            {
                errorPlaceEP.SetError(BookTitleCodeTxb, "Mã tựa sách (mã loại sản phẩm) và mã sách (mã sản phẩm) không khớp! Vui lòng kiểm tra lại");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(BookTitleCodeTxb, "");
            }

            return true;
        }

        // Hàm để add dữ liệu của quyển sách mới dc nhập vào Datagridview
        private void AddNewEnteredItemRowToDG()
        {
            string bookQuery = "Select GIA from SACH where MASACH = @BookCode";
            ItemCart item = new ItemCart()
            {

                itemID = BookCodeTxb.Text,
                itemTypeId = BookTitleCodeTxb.Text,
                price = bookSaleManage.GetBookPriceFromDatabase(bookQuery, BookCodeTxb.Text)
            };
            GIOHANG.Add(item);
            DataGridViewRow enteredBook = (DataGridViewRow)EnteredProductDG.Rows[EnteredProductDG.RowCount - 1].Clone();

            enteredBook.Cells[0].Value = BookTitleCodeTxb.Text;
            enteredBook.Cells[1].Value = BookCodeTxb.Text;
            enteredBook.Cells[2].Value = bookSaleManage.GetBookPriceFromDatabase(bookQuery, BookCodeTxb.Text);
            EnteredProductDG.Rows.Add(enteredBook);
            int TotalAmount = AmountCustomerMustPay(); // Gọi hàm để tính tổng tiền khách hàng phải thanh toán
            EnteredProductDG.Rows[0].Cells[3].Value = TotalAmount;
        }

        //Hàm để add dữ liệu văn phòng phẩm mới dc nhập vào Datageridview
        private void AddNewEnteredAccessoryRowToDG()
        {
            string query = "Select GIA from VANPHONGPHAM where MASANPHAM = @masanpham";
            ItemCart item = new ItemCart()
            {

                itemID = BookCodeTxb.Text,
                itemTypeId = BookTitleCodeTxb.Text,
                price = (int)AccessorySale.GetAccessoryPriceFromDatabase(query, BookCodeTxb.Text)
            };
            GIOHANG.Add(item);
            DataGridViewRow enteredBook = (DataGridViewRow)EnteredProductDG.Rows[EnteredProductDG.RowCount - 1].Clone();
            enteredBook.Cells[0].Value = BookTitleCodeTxb.Text;
            enteredBook.Cells[1].Value = BookCodeTxb.Text;
            enteredBook.Cells[2].Value = AccessorySale.GetAccessoryPriceFromDatabase(query, BookCodeTxb.Text);
            EnteredProductDG.Rows.Add(enteredBook);
            int TotalAmount = AmountCustomerMustPay(); // Gọi hàm để tính tổng tiền khách hàng phải thanh toán
            EnteredProductDG.Rows[0].Cells[3].Value = TotalAmount;
        }
        // Sự kiện khi người dùng ấn nút để quay lại
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the form", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InvisibleControl();

                // Reset lại các control nếu lỡ ng dùng có ần thanh toán 1 lần rồi back lại
                CusPaymentAmountNum.Value = 0;
                CusPaymentAmountNum.Enabled = false;
                DiscountRateNum.Value = 0;
                DiscountRateNum.Enabled = false;
                BookCodeTxb.Enabled = true;
                BookTitleCodeTxb.Enabled = true;

                // Reset lại 4 list lưu trữ 
                bookCodeList = new List<string>();
                bookTitleCodeList = new List<string>();
                AccessoryIDList = new List<string>();
                AccessoryTypeIDList = new List<string>();
                return;
            }
        }

        // Hàm để tính tổng tiền thanh toán của khách hàng
        private int AmountCustomerMustPay()
        {
            int TotalAmount = 0;

            for (int i = 0; i < EnteredProductDG.RowCount - 1; i++)
            {
                TotalAmount += Convert.ToInt32(EnteredProductDG.Rows[i].Cells[2].Value);
            }

            return TotalAmount;
        }

        // Hàm để add thông tin sản phẩm mà khách hàng đã thanh toán vào Datagridview
        private void AddNewPaymentRowToDG()
        {
            DataGridViewRow newPayment = (DataGridViewRow)PaidProductDG.Rows[PaidProductDG.RowCount - 1].Clone();
            tempPayment = Convert.ToInt32(CusPaymentAmountNum.Value);
            newPayment.Cells[0].Value = EnteredProductDG.RowCount - 1;
            newPayment.Cells[3].Value = DiscountRateNum.Value.ToString() + "%";
            newPayment.Cells[1].Value = EnteredProductDG.Rows[0].Cells[4].Value;
            newPayment.Cells[2].Value = Convert.ToInt32(CusPaymentAmountNum.Value) - Convert.ToInt32(EnteredProductDG.Rows[0].Cells[4].Value);
            PaidProductDG.Rows.Add(newPayment);
        }

        // Hàm để check xem mã sản phẩm ng dùng nhập vào có bị trùng mã đã nhập trc đó hay không
        private bool CheckBookCodeInDG()
        {
            if (EnteredProductDG.RowCount > 1)
            {
                for (int i = 0; i < EnteredProductDG.RowCount - 1; i++)
                {
                    if (string.Equals(BookCodeTxb.Text.ToLower(), EnteredProductDG.Rows[i].Cells[1].Value.ToString().ToLower()) == true)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Hàm để check thông tin khi người dùng ấn nút để chốt sản phẩm thanh toán
        private bool CheckPaymentInfo()
        {
            // Nếu ng dùng chưa nhập số tiền khách hàng thanh toán
            if (CusPaymentAmountNum.Value == 0 && CusPaymentAmountNum.Enabled == true && DiscountRateNum.Enabled == false)
            {
                errorPlaceEP.SetError(CusPaymentAmountNum, "Vui lòng nhập số tiền khách hàng thanh toán!");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(CusPaymentAmountNum, "");
            }

            if (CusPaymentAmountNum.Value < Convert.ToInt32(EnteredProductDG.Rows[0].Cells[4].Value) && CusPaymentAmountNum.Enabled == true && DiscountRateNum.Enabled == false)
            {
                errorPlaceEP.SetError(CusPaymentAmountNum, "Giá trị nhập vào không đủ để thanh toán! Vui lòng kiểm tra lại!");

                return false;
            }

            else
            {
                errorPlaceEP.SetError(CusPaymentAmountNum, "");
            }

            return true;
        }

        // Hàm để reset lại error provider
        private void ResetErrorProvider()
        {
            errorPlaceEP.SetError(BookTitleCodeTxb, "");
            errorPlaceEP.SetError(BookCodeTxb, "");
        }

        // Hàm để reset lại các control sau khi đã thanh toán xong
        private void ResetControl()
        {
            CusPaymentAmountNum.Value = 0;
            CusPaymentAmountNum.Enabled = false;
            DiscountRateNum.Value = 0;
            DiscountRateNum.Enabled = false;
            BookCodeTxb.Enabled = true;
            BookTitleCodeTxb.Enabled = true;
            SubmitButton.Visible = true;

            if (EnteredProductDG.RowCount > 1)
            {
                EnteredProductDG.Rows.Clear();
            }
        }
        int tempPayment;
        int MAHOADON;
        // Hàm để trả về tất cả các mã sản phẩm mà người dùng mua
        private string ConnectAllBooksCode()
        {
            string AllBooksCode = "";

            for (int i = 0; i < EnteredProductDG.RowCount - 1; i++)
            {
                if (i == 0 && EnteredProductDG.RowCount > 2)
                {
                    AllBooksCode += EnteredProductDG.Rows[i].Cells[1].Value.ToString() + ", ";
                }

                if (i == 0 && EnteredProductDG.RowCount == 2)
                {
                    AllBooksCode += EnteredProductDG.Rows[i].Cells[1].Value.ToString();
                }

                else if (i > 0 && i != EnteredProductDG.RowCount - 2)
                {
                    AllBooksCode += EnteredProductDG.Rows[i].Cells[1].Value.ToString() + ", ";
                }

                else if (i == EnteredProductDG.RowCount - 2)
                {
                    AllBooksCode += EnteredProductDG.Rows[i].Cells[1].Value.ToString();
                }
            }

            return AllBooksCode;
        }

        // Sự kiện khi người dùng ấn nút để chốt thanh toán
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            ResetErrorProvider(); // Gọi hàm để xoá các đánh dấu lỗi trc đó

            if (EnteredProductDG.RowCount == 1)
            {
                MessageBox.Show("Vui lòng nhập thông tin sản phẩm trước khi thanh toán!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (DiscountRateNum.Enabled == false && BookCodeTxb.Enabled == true && BookTitleCodeTxb.Enabled == true)
            {
                // Xét nếu như ng dùng chưa import hết thông tin thanh toán vào datagridview
                if (string.IsNullOrEmpty(BookCodeTxb.Text) == false || string.IsNullOrWhiteSpace(BookCodeTxb.Text) == false || string.IsNullOrEmpty(BookTitleCodeTxb.Text) == false || string.IsNullOrWhiteSpace(BookTitleCodeTxb.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập hết thông tin của các vật phẩm cần thanh toán trước khi thực hiện tính toán giao dịch!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // ngược lại nếu dữ liệu đã dc import đầy đủ
                else if (string.IsNullOrEmpty(BookCodeTxb.Text) == true && string.IsNullOrWhiteSpace(BookCodeTxb.Text) == true && string.IsNullOrEmpty(BookTitleCodeTxb.Text) == true && string.IsNullOrWhiteSpace(BookTitleCodeTxb.Text) == true)
                {
                    DiscountRateNum.Enabled = true;

                    BookCodeTxb.Enabled = false;
                    BookTitleCodeTxb.Enabled = false;
                    CusPaymentAmountNum.Enabled = false;

                    SubmitButton.Visible = false;
                }
            }

            else if (CusPaymentAmountNum.Enabled == false && DiscountRateNum.Enabled == true)
            {
                EnteredProductDG.Rows[0].Cells[4].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - (Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) * (DiscountRateNum.Value / 100));

                CusPaymentAmountNum.Enabled = true;

                DiscountRateNum.Enabled = false;
                BookCodeTxb.Enabled = false;
                BookTitleCodeTxb.Enabled = false;
            }

            if (CusPaymentAmountNum.Enabled == true && DiscountRateNum.Enabled == false && CusPaymentAmountNum.Value != 0)
            {
                if (CheckPaymentInfo() == true)
                {
                    string AllBooksCode = ConnectAllBooksCode(); // Gọi hàm để lưu lại tất cả các mã sách đã bán
                    AddNewPaymentRowToDG(); // Gọi hàm để add các thông tin vào DG chứa thông tin khi chốt thanh toán 

                    bookSaleManage.DeleteSoldBook(bookCodeList); // Gọi hàm để xoá các mã sách đã bán
                    bookSaleManage.ReduceBookTotalNumberInDB(bookTitleCodeList);// Gọi hàm để giảm số lượng trong kho sách khi sách đã dc bán
                    AccessorySale.DeleteSoldAccessory(AccessoryIDList); // Tương tự với trường hợp văn phòng phẩm
                    AccessorySale.ReduceAccessoryTotalNumberInDB(AccessoryTypeIDList);

                    ResetControl(); // Gọi hàm để reset lại các control để ng dùng bán hàng

                    string insertNewInvoiceQuery = "insert into HOADONBANHANG values(@InvoiceCode ,@AmountCusMustPay, @ExcessMoney, @DateOfInvoicing)";
                    string insertNewInvoiceDetailsQuery = "insert into CTHD values(@InvoiceDetailsCode ,@BooksCode)";
                    string countInvoiceCode = "select Count(*) from HOADONBANHANG";
                    string countInvoiceDetailsCode = "select Count(*) from CTHD";
                    int totalInvoiceCode = bookSaleManage.CountInvoiceData(countInvoiceCode) + 1;
                    int totalInvoiceDetailsCode = bookSaleManage.CountInvoiceDetailsNumnber(countInvoiceDetailsCode) + 1;
                    MAHOADON = totalInvoiceDetailsCode;
                    bookSaleManage.AddNewInvoiceToDB(insertNewInvoiceQuery, "PX " + totalInvoiceCode.ToString(), Convert.ToInt32(PaidProductDG.Rows[PaidProductDG.RowCount - 2].Cells[1].Value), Convert.ToInt32(PaidProductDG.Rows[PaidProductDG.RowCount - 2].Cells[2].Value), DateTime.Today);
                    bookSaleManage.AddNewInvoiceDetailsToDB(insertNewInvoiceDetailsQuery, "PX " + totalInvoiceDetailsCode.ToString(), AllBooksCode);
                    prntOderBtn.Visible = true;
                    prntOderBtn.Enabled = true;
                    PrntPreviewBtn.Enabled = true;
                    PrntPreviewBtn.Visible = true;
                    MessageBox.Show("Payment successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
        }

        // 2 nút để thực hiện chức năng chốt thanh toán và quay lại
        Button PaymentButton = new Button();
        // Sự kiện khi người dùng ấn nút submit sản phẩm sau khi nhập xong
        private void SubmitButton_Click_1(object sender, EventArgs e)
        {

            if (CheckSaleInfo() == true)
            {
                try
                {
                    AddNewEnteredItemRowToDG();
                    bookCodeList.Add(BookCodeTxb.Text);
                    bookTitleCodeList.Add(BookTitleCodeTxb.Text);
                }
                catch (Exception)
                {
                    AddNewEnteredAccessoryRowToDG();
                    AccessoryIDList.Add(BookCodeTxb.Text);
                    AccessoryTypeIDList.Add(BookTitleCodeTxb.Text);
                }
                EnteredProductDG.ClearSelection();
                giveBackItemPosition = EnteredProductDG.RowCount - 1; // Reset biến check vị trí xoá luôn là ô rỗng cuối cùng để tránh việc trỏ đến các vị trí trên
                // Reset lại 2 textbox để nhập dữ liệu mới
                BookCodeTxb.Text = "";
                BookTitleCodeTxb.Text = "";
            }
        }

        // Sự kiện khi người dùng muốn chọn sản phẩm để ấn nút hoàn trả
        private void EnteredProductDG_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu ng dùng chọn dòng có dữ liệu
            if (e.RowIndex != EnteredProductDG.RowCount - 1)
            {
                giveBackItemPosition = e.RowIndex;
            }
        }

        // Sự kiện khi người dùng ấn nút hoàn trả 
        private void GiveBackButton_Click_1(object sender, EventArgs e)
        {
            // Xét nếu không còn sản phẩm trong datagridview
            if (EnteredProductDG.RowCount == 1 || EnteredProductDG.CurrentCell.RowIndex == EnteredProductDG.RowCount - 1 || giveBackItemPosition == EnteredProductDG.RowCount - 1)
            {
                MessageBox.Show("Không có sản phẩm để hoàn lại", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Nếu dòng dc chọn có dữ liệu
            if (EnteredProductDG.RowCount > 1 && giveBackItemPosition != EnteredProductDG.RowCount - 1)
            {
                // Xét nếu ng dùng trả lại sản phẩm đầu tiên thì dời giá tiền tạm tính và tiền thanh toán xuống dòng tiếp theo
                if (giveBackItemPosition == 0 && EnteredProductDG.RowCount >= 3)
                {
                    // Xét xem ng dùng đang ở bước nhập chiết khấu hay nhập tiền thanh toán hay đang nhập dữ liệu
                    if (BookCodeTxb.Enabled == true && BookTitleCodeTxb.Enabled == true)
                    {
                        EnteredProductDG.Rows[1].Cells[3].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - Convert.ToInt32(EnteredProductDG.Rows[0].Cells[2].Value);
                    }

                    else if (DiscountRateNum.Enabled == true && BookCodeTxb.Enabled == false && BookTitleCodeTxb.Enabled == false)
                    {
                        EnteredProductDG.Rows[1].Cells[3].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - Convert.ToInt32(EnteredProductDG.Rows[0].Cells[2].Value);
                    }

                    else if (DiscountRateNum.Enabled == false && BookCodeTxb.Enabled == false && BookTitleCodeTxb.Enabled == false)
                    {
                        EnteredProductDG.Rows[1].Cells[3].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - Convert.ToInt32(EnteredProductDG.Rows[0].Cells[2].Value);
                        EnteredProductDG.Rows[1].Cells[4].Value = Convert.ToInt32(EnteredProductDG.Rows[1].Cells[3].Value) - (Convert.ToInt32(EnteredProductDG.Rows[1].Cells[3].Value) * (DiscountRateNum.Value / 100));
                    }
                }

                // Nếu sản phẩm bị hoàn trả khác dòng đầu tiên
                else if (giveBackItemPosition != 0 && EnteredProductDG.RowCount >= 3)
                {
                    // Xét xem ng dùng đang ở bước nhập chiết khấu hay nhập tiền thanh toán
                    if (BookCodeTxb.Enabled == true && BookTitleCodeTxb.Enabled == true)
                    {
                        EnteredProductDG.Rows[0].Cells[3].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - Convert.ToInt32(EnteredProductDG.Rows[giveBackItemPosition].Cells[2].Value);
                    }

                    else if (DiscountRateNum.Enabled == true && BookCodeTxb.Enabled == false && BookTitleCodeTxb.Enabled == false)
                    {
                        EnteredProductDG.Rows[0].Cells[3].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - Convert.ToInt32(EnteredProductDG.Rows[giveBackItemPosition].Cells[2].Value);
                    }

                    else if (DiscountRateNum.Enabled == false && BookCodeTxb.Enabled == false && BookTitleCodeTxb.Enabled == false)
                    {
                        EnteredProductDG.Rows[0].Cells[3].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - Convert.ToInt32(EnteredProductDG.Rows[giveBackItemPosition].Cells[2].Value);
                        EnteredProductDG.Rows[0].Cells[4].Value = Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) - (Convert.ToInt32(EnteredProductDG.Rows[0].Cells[3].Value) * (DiscountRateNum.Value / 100));
                    }
                }
                GIOHANG.RemoveAt(giveBackItemPosition);
                EnteredProductDG.Rows.RemoveAt(giveBackItemPosition);
                EnteredProductDG.ClearSelection(); // Clear selection để ko có lựa chọn nào dc focus trc trên datagridview

                giveBackItemPosition = EnteredProductDG.RowCount - 1; // Reset biến check vị trí xoá luôn là ô rỗng cuối cùng để tránh việc trỏ đến các vị trí trên

                // Nếu như đã hoàn trả hết sản phẩm
                if (EnteredProductDG.RowCount == 1)
                {
                    BookTitleCodeTxb.Enabled = true;
                    BookCodeTxb.Enabled = true;
                    CusPaymentAmountNum.Enabled = false;
                    DiscountRateNum.Enabled = false;

                    DiscountRateNum.Value = 0;
                    CusPaymentAmountNum.Value = 0;

                    SubmitButton.Visible = true;

                    errorPlaceEP.SetError(CusPaymentAmountNum, ""); // Reset lại phần báo lỗi trong TH ng dùng có bị nhập lỗi trc đó
                }

                return;
            }
        }
        //Hàm nhấn vào sẽ xem trước bản in hóa đơn
        private void PrntPreviewBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Lỗi trong quá trình thiết lập máy in, mời kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void prntOderBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
                GIOHANG.Clear();
                prntOderBtn.Visible = false;
                prntOderBtn.Enabled = false;
                PrntPreviewBtn.Enabled = false;
                PrntPreviewBtn.Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi trong quá trình thiết lập máy in, mời kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //HÀM TẠO MẪU IN
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hóa đơn:PX " + MAHOADON.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("ITEM ID", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("ITEM TYPEID", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("GIÁ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;

            foreach (var i in GIOHANG)
            {
                e.Graphics.DrawString(i.itemID.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.itemTypeId.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                e.Graphics.DrawString(i.price.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));

                yPos += 30;
            }

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Thành tiền: " + Convert.ToInt32(PaidProductDG.Rows[PaidProductDG.RowCount - 2].Cells[1].Value) + "₫", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 30));
            e.Graphics.DrawString("Nhận của Khách:" + tempPayment + "₫", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 60));
            e.Graphics.DrawString("Tiền thừa:" + Convert.ToInt32(PaidProductDG.Rows[PaidProductDG.RowCount - 2].Cells[2].Value) + "₫", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 90));
        }
    }
}

