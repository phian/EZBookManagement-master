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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace BookstoreManagementApp_Final_
{
    public partial class UC_RevenueReport : UserControl
    {
        public UC_RevenueReport()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy
        }
        // Biến để tương tác với các sự kiện từ UI và gọi hàm tương ứng
        RevenueReportManage_BUS revenueReportManage = new RevenueReportManage_BUS();

        // Hàm để visible các control cần thiết dùng cho việc viết báo cáo
        private void VisibleControl()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true); // Set để khi chạy form thì hình sẽ không bị nháy

            // Disable các nút chức năng 
            WeeklyReportButton.Enabled = false;
            MonthlyReportButton.Enabled = false;
            AnnualReportButton.Enabled = false;

            // Visible các control dùng để nhập dữ liệu
            TotalInvoiceLb.Visible = true;
            TotalInvoiceNum.Visible = true;
            AverageInvoiceValueLb.Visible = true;
            AverageInvoiceValueNum.Visible = true;
            TotalRevenueLb.Visible = true;
            TotalRevenueNum.Visible = true;
            ReportMakerLb.Visible = true;
            ReportMakerTxb.Visible = true;
            StaffIDLb.Visible = true;
            StaffIDTxb.Visible = true;
            InvoiceDataGB.Visible = true;

            BackButton.Visible = true;
            PrintButton.Visible = true;
        }

        // Hàm để khi ng dùng ấn nút back thì reset lại hiển thị của các control
        private void InvisibleControl()
        {
            // Disable các nút chức năng 
            WeeklyReportButton.Enabled = true;
            MonthlyReportButton.Enabled = true;
            AnnualReportButton.Enabled = true;

            // Visible các control dùng để nhập dữ liệu
            TotalInvoiceLb.Visible = false;
            TotalInvoiceNum.Visible = false;
            AverageInvoiceValueLb.Visible = false;
            AverageInvoiceValueNum.Visible = false;
            TotalRevenueLb.Visible = false;
            TotalRevenueNum.Visible = false;
            InvoiceDataGB.Visible = false;
            ReportMakerLb.Visible = false;
            ReportMakerTxb.Visible = false;
            StaffIDLb.Visible = false;
            StaffIDTxb.Visible = false;

            BackButton.Visible = false;
            PrintButton.Visible = false;
        }

        // Hàm để reset lại giá trị trong các numeric để ng dùng nhập dữ liệu
        private void ResetControlValue()
        {
            ReportMakerTxb.Text = "";
            StaffIDTxb.Text = "";
            TotalInvoiceNum.Value = 0;
            TotalRevenueNum.Value = 0;
            AverageInvoiceValueNum.Value = 0;

            StaffInfoCheckingEP.SetError(ReportMakerTxb, "");
        }

        string InvoiceQuery = ""; // Biến để lưu các query hoá đơn

        // Hàm để add dữ liệu query hoá đơn bán hàng vào datagridview
        private void AddInvoiceDataToDG()
        {
            InvoiceDataDG.DataSource = revenueReportManage.GetSalesInvoiceByCategories(InvoiceQuery).Tables[0];
        }

        // Hàm để chỉnh các hiển thị của Header test của DG
        private void SetHeaderTest()
        {
            InvoiceDataDG.Columns[0].HeaderText = "Mã hoá đơn";
            InvoiceDataDG.Columns[1].HeaderText = "Thành tiền";
            InvoiceDataDG.Columns[2].HeaderText = "Tiền thừa";
            InvoiceDataDG.Columns[3].HeaderText = "Ngày lập hoá đơn";
        }

        // Hàm để check các thông tin của nhân viên khi nhập thông tin báo cáo
        private bool CheckStaffInfo()
        {
            if (string.IsNullOrEmpty(ReportMakerTxb.Text) == true || string.IsNullOrWhiteSpace(ReportMakerTxb.Text) == true)
            {
                StaffInfoCheckingEP.SetError(ReportMakerTxb, "Vui lòng nhập tên nhân viên lập báo cáo");

                return false;
            }

            else
            {
                StaffInfoCheckingEP.SetError(ReportMakerTxb, "");
            }

            if (string.IsNullOrEmpty(StaffIDTxb.Text) == true || string.IsNullOrWhiteSpace(StaffIDTxb.Text) == true)
            {
                StaffInfoCheckingEP.SetError(StaffIDTxb, "Vui lòng nhập mã nhân viên báo cáo");

                return false;
            }

            else
            {
                StaffInfoCheckingEP.SetError(StaffIDTxb, "");
            }

            if (revenueReportManage.CheckStaffInfo(ReportMakerTxb.Text.Trim(), StaffIDTxb.Text.Trim()) == false)
            {
                StaffInfoCheckingEP.SetError(ReportMakerTxb, "Tên người dùng hoặc mã nhân viên không hợp lệ! Vui lòng kiểm tra lại!");

                return false;
            }

            else
            {
                StaffInfoCheckingEP.SetError(ReportMakerTxb, "");
            }

            return true;
        }

        // Sự kiện khi người dùng ấn nút để chọn báo cáo theo tuần
        private void WeeklyReportButton_Click_1(object sender, EventArgs e)
        {
            InvoiceQuery = "Select * from HOADONBANHANG where NGAYLAPHOADON BETWEEN DATEADD(dd, -7, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";

            VisibleControl(); // Gọi hàm để visible các control cần thiết

            AddInvoiceDataToDG(); // Add dữ liệu cần thiết vào datagridview để ng dùng có dữ liệu để thống kê

            SetHeaderTest(); // Gọi hàm để chỉnh lại hiển thị của các header test trong DG
        }

        // Sự kiện khi người dùng ấn nút để chọn báo cáo theo tháng
        private void MonthlyReportButton_Click_1(object sender, EventArgs e)
        {
            // Xét thời gian để có lệnh query trừ thời gian tương ứng
            if (DateTime.Now.Month - 1 == 1 || DateTime.Now.Month - 1 == 3 || DateTime.Now.Month - 1 == 5 || DateTime.Now.Month - 1 == 7 || DateTime.Now.Month - 1 == 8 || DateTime.Now.Month - 1 == 10 || DateTime.Now.Month - 1 == 12)
            {
                InvoiceQuery = "Select * from HOADONBANHANG  where NGAYLAPHOADON BETWEEN DATEADD(dd, -31, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";
            }

            else if (DateTime.Now.Month - 1 == 4 || DateTime.Now.Month - 1 == 6 || DateTime.Now.Month - 1 == 9 || DateTime.Now.Month - 1 == 11)
            {
                InvoiceQuery = "Select * from HOADONBANHANG  where NGAYLAPHOADON BETWEEN DATEADD(dd, -30, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";
            }

            else if (DateTime.Now.Month - 1 == 2 && (DateTime.Now.Year) % 4 == 0)
            {
                InvoiceQuery = "Select * from HOADONBANHANG  where NGAYLAPHOADON BETWEEN DATEADD(dd, -29, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";
            }

            else if (DateTime.Now.Month - 1 == 2 && (DateTime.Now.Year) % 4 != 0)
            {
                InvoiceQuery = "Select * from HOADONBANHANG  where NGAYLAPHOADON BETWEEN DATEADD(dd, -28, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";
            }

            VisibleControl(); // Gọi hàm để visible các control cần thiết

            AddInvoiceDataToDG(); // Add dữ liệu cần thiết vào datagridview để ng dùng có dữ liệu để thống kê

            SetHeaderTest(); // Gọi hàm để chỉnh lại hiển thị của các header test trong DG
        }

        // Sự kiện khi người dùng ấn nút để chọn báo cáo theo năm
        private void AnnualReportButton_Click_1(object sender, EventArgs e)
        {
            // Xét thời gian để có lệnh query trừ thời gian tương ứng
            if ((DateTime.Now.Year - 1) % 4 == 0)
            {
                InvoiceQuery = "Select * from HOADONBANHANG  where NGAYLAPHOADON BETWEEN DATEADD(dd, -366, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";
            }

            else if ((DateTime.Now.Year - 1) % 4 != 0)
            {
                InvoiceQuery = "Select * from HOADONBANHANG  where NGAYLAPHOADON BETWEEN DATEADD(dd, -365, CONVERT(date, GETDATE())) AND CONVERT(date, GETDATE())";
            }

            VisibleControl(); // Gọi hàm để visible các control cần thiết

            AddInvoiceDataToDG(); // Add dữ liệu cần thiết vào datagridview để ng dùng có dữ liệu để thống kê

            SetHeaderTest(); // Gọi hàm để chỉnh lại hiển thị của các header test trong DG
        }

        // Sự kiện khi người dùng back về lại form ban đầu
        private void BackButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the form", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetControlValue(); // Gọi hàm reset lại dữ liệu mặc định cho các control
                InvisibleControl(); // Gọi hàm để disable các control và quay lại form ban đầu
            }

            else
            {
                return;
            }
        }

        // Hàm để chuyển file pdf báo cáo sang thư mục ng dùng lưu trữ file báo cáo
        private void CheckDirectory()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                MessageBox.Show(drive.Name);

                if (drive.DriveType == DriveType.Fixed && string.Equals(drive.Name.ToLower(), @"C:\".ToLower()) == false)
                {
                    if (!Directory.Exists(drive.Name + @"Folder báo cáo\"))
                    {
                        Directory.CreateDirectory(drive.Name + @"Folder báo cáo\");

                        break;
                    }
                }
            }
        }

        // Sự kiện khi người dùng ấn nút submit tính toán để in ra file pdf
        private void PrintButton_Click_1(object sender, EventArgs e)
        {
            if (CheckStaffInfo() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn với số liệu đã tính toán hay chưa", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Khai báo file pdf
                    PdfDocument newReportFile = new PdfDocument();
                    PdfPage newReportPage = newReportFile.AddPage();
                    XGraphics graph = XGraphics.FromPdfPage(newReportPage);
                    XFont pageFont = new XFont("Arial", 25, XFontStyle.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode));

                    // Vẽ các thông tin cần thiết vào file pdf báo cáo
                    graph.DrawString("Ngày lập báo cáo: " + DateTime.Today.ToShortDateString(), pageFont, XBrushes.Black, new XRect(0, 0, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("", pageFont, XBrushes.Black, new XRect(0, 30, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Người lập báo cáo", pageFont, XBrushes.Black, new XRect(0, 60, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Tên nhân viên lập báo cáo: " + ReportMakerTxb.Text, pageFont, XBrushes.Black, new XRect(0, 90, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Mã nhân viên: " + StaffIDTxb.Text, pageFont, XBrushes.Black, new XRect(0, 120, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("", pageFont, XBrushes.Black, new XRect(0, 150, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Tổng số lượng hoá đơn bán hàng: " + TotalInvoiceNum.Value.ToString(), pageFont, XBrushes.Black, new XRect(0, 180, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Giá trị trung bình trên hoá đơn: " + AverageInvoiceValueNum.Value.ToString(), pageFont, XBrushes.Black, new XRect(0, 210, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Tổng doanh thu: " + TotalRevenueNum.Value.ToString(), pageFont, XBrushes.Black, new XRect(0, 240, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopLeft);

                    string fileName = @"D:\Folder báo cáo\" + "Báo cáo ngày " + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + ".pdf";

                    CheckDirectory(); // Gọi hàm để check xem thư mục đã tồn tại hay chưa, nếu chưa thì ta tạo thư mục để lưu trữ

                    newReportFile.Save(fileName);

                    Process.Start(fileName);

                    ResetControlValue(); // Gọi hàm reset lại dữ liệu mặc định cho các control
                }

                else
                {
                    return;
                }
            }
        }
        // Sự kiện khi ng dùng nhập xong tên thì chuyển về dạng chuẩn
        private void ReportMakerTxb_TextChanged(object sender, EventArgs e)
        {
            ReportMakerTxb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ReportMakerTxb.Text.ToLower());
        }
    }
}

