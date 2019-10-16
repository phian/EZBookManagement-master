namespace BookstoreManagementApp_Final_
{
    partial class UC_RevenueReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnnualReportButton = new System.Windows.Forms.Button();
            this.MonthlyReportButton = new System.Windows.Forms.Button();
            this.WeeklyReportButton = new System.Windows.Forms.Button();
            this.StaffIDTxb = new System.Windows.Forms.TextBox();
            this.ReportMakerTxb = new System.Windows.Forms.TextBox();
            this.StaffIDLb = new System.Windows.Forms.Label();
            this.ReportMakerLb = new System.Windows.Forms.Label();
            this.InvoiceDataGB = new System.Windows.Forms.GroupBox();
            this.InvoiceDataDG = new System.Windows.Forms.DataGridView();
            this.AverageInvoiceValueNum = new System.Windows.Forms.NumericUpDown();
            this.TotalRevenueNum = new System.Windows.Forms.NumericUpDown();
            this.TotalInvoiceNum = new System.Windows.Forms.NumericUpDown();
            this.TotalRevenueLb = new System.Windows.Forms.Label();
            this.AverageInvoiceValueLb = new System.Windows.Forms.Label();
            this.TotalInvoiceLb = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.StaffInfoCheckingEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.InvoiceDataGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageInvoiceValueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalRevenueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalInvoiceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffInfoCheckingEP)).BeginInit();
            this.SuspendLayout();
            // 
            // AnnualReportButton
            // 
            this.AnnualReportButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.AnnualReportButton.Location = new System.Drawing.Point(32, 425);
            this.AnnualReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnnualReportButton.Name = "AnnualReportButton";
            this.AnnualReportButton.Size = new System.Drawing.Size(117, 94);
            this.AnnualReportButton.TabIndex = 5;
            this.AnnualReportButton.Text = "BÁO CÁO DOANH THU NĂM";
            this.AnnualReportButton.UseVisualStyleBackColor = true;
            this.AnnualReportButton.Click += new System.EventHandler(this.AnnualReportButton_Click_1);
            // 
            // MonthlyReportButton
            // 
            this.MonthlyReportButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.MonthlyReportButton.Location = new System.Drawing.Point(32, 280);
            this.MonthlyReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthlyReportButton.Name = "MonthlyReportButton";
            this.MonthlyReportButton.Size = new System.Drawing.Size(117, 94);
            this.MonthlyReportButton.TabIndex = 4;
            this.MonthlyReportButton.Text = "BÁO CÁO DOANH THU THÁNG";
            this.MonthlyReportButton.UseVisualStyleBackColor = true;
            this.MonthlyReportButton.Click += new System.EventHandler(this.MonthlyReportButton_Click_1);
            // 
            // WeeklyReportButton
            // 
            this.WeeklyReportButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.WeeklyReportButton.Location = new System.Drawing.Point(32, 125);
            this.WeeklyReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeeklyReportButton.Name = "WeeklyReportButton";
            this.WeeklyReportButton.Size = new System.Drawing.Size(117, 94);
            this.WeeklyReportButton.TabIndex = 3;
            this.WeeklyReportButton.Text = "BÁO CÁO DOANH THU TUẦN";
            this.WeeklyReportButton.UseVisualStyleBackColor = true;
            this.WeeklyReportButton.Click += new System.EventHandler(this.WeeklyReportButton_Click_1);
            // 
            // StaffIDTxb
            // 
            this.StaffIDTxb.Font = new System.Drawing.Font("UTM Avo", 9.5F);
            this.StaffIDTxb.Location = new System.Drawing.Point(566, 158);
            this.StaffIDTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaffIDTxb.Name = "StaffIDTxb";
            this.StaffIDTxb.Size = new System.Drawing.Size(320, 29);
            this.StaffIDTxb.TabIndex = 29;
            this.StaffIDTxb.Visible = false;
            // 
            // ReportMakerTxb
            // 
            this.ReportMakerTxb.Font = new System.Drawing.Font("UTM Avo", 9.5F);
            this.ReportMakerTxb.Location = new System.Drawing.Point(566, 109);
            this.ReportMakerTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportMakerTxb.Name = "ReportMakerTxb";
            this.ReportMakerTxb.Size = new System.Drawing.Size(320, 29);
            this.ReportMakerTxb.TabIndex = 28;
            this.ReportMakerTxb.Visible = false;
            this.ReportMakerTxb.TextChanged += new System.EventHandler(this.ReportMakerTxb_TextChanged);
            // 
            // StaffIDLb
            // 
            this.StaffIDLb.AutoSize = true;
            this.StaffIDLb.BackColor = System.Drawing.Color.Transparent;
            this.StaffIDLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.StaffIDLb.Location = new System.Drawing.Point(221, 160);
            this.StaffIDLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffIDLb.Name = "StaffIDLb";
            this.StaffIDLb.Size = new System.Drawing.Size(135, 24);
            this.StaffIDLb.TabIndex = 27;
            this.StaffIDLb.Text = "Mã nhân viên:";
            this.StaffIDLb.Visible = false;
            // 
            // ReportMakerLb
            // 
            this.ReportMakerLb.AutoSize = true;
            this.ReportMakerLb.BackColor = System.Drawing.Color.Transparent;
            this.ReportMakerLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.ReportMakerLb.Location = new System.Drawing.Point(221, 110);
            this.ReportMakerLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportMakerLb.Name = "ReportMakerLb";
            this.ReportMakerLb.Size = new System.Drawing.Size(250, 24);
            this.ReportMakerLb.TabIndex = 26;
            this.ReportMakerLb.Text = "Tên nhân viên lập báo cáo:";
            this.ReportMakerLb.Visible = false;
            // 
            // InvoiceDataGB
            // 
            this.InvoiceDataGB.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceDataGB.Controls.Add(this.InvoiceDataDG);
            this.InvoiceDataGB.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.InvoiceDataGB.Location = new System.Drawing.Point(211, 382);
            this.InvoiceDataGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvoiceDataGB.Name = "InvoiceDataGB";
            this.InvoiceDataGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvoiceDataGB.Size = new System.Drawing.Size(1075, 394);
            this.InvoiceDataGB.TabIndex = 25;
            this.InvoiceDataGB.TabStop = false;
            this.InvoiceDataGB.Text = "Thông tin hoá đơn bán hàng";
            this.InvoiceDataGB.Visible = false;
            // 
            // InvoiceDataDG
            // 
            this.InvoiceDataDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDataDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataDG.Location = new System.Drawing.Point(8, 43);
            this.InvoiceDataDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvoiceDataDG.Name = "InvoiceDataDG";
            this.InvoiceDataDG.ReadOnly = true;
            this.InvoiceDataDG.Size = new System.Drawing.Size(1059, 343);
            this.InvoiceDataDG.TabIndex = 11;
            // 
            // AverageInvoiceValueNum
            // 
            this.AverageInvoiceValueNum.Location = new System.Drawing.Point(566, 268);
            this.AverageInvoiceValueNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AverageInvoiceValueNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.AverageInvoiceValueNum.Name = "AverageInvoiceValueNum";
            this.AverageInvoiceValueNum.Size = new System.Drawing.Size(322, 22);
            this.AverageInvoiceValueNum.TabIndex = 31;
            this.AverageInvoiceValueNum.Visible = false;
            // 
            // TotalRevenueNum
            // 
            this.TotalRevenueNum.Location = new System.Drawing.Point(566, 319);
            this.TotalRevenueNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalRevenueNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TotalRevenueNum.Name = "TotalRevenueNum";
            this.TotalRevenueNum.Size = new System.Drawing.Size(322, 22);
            this.TotalRevenueNum.TabIndex = 32;
            this.TotalRevenueNum.Visible = false;
            // 
            // TotalInvoiceNum
            // 
            this.TotalInvoiceNum.Location = new System.Drawing.Point(566, 215);
            this.TotalInvoiceNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalInvoiceNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TotalInvoiceNum.Name = "TotalInvoiceNum";
            this.TotalInvoiceNum.Size = new System.Drawing.Size(322, 22);
            this.TotalInvoiceNum.TabIndex = 30;
            this.TotalInvoiceNum.Visible = false;
            // 
            // TotalRevenueLb
            // 
            this.TotalRevenueLb.AutoSize = true;
            this.TotalRevenueLb.BackColor = System.Drawing.Color.Transparent;
            this.TotalRevenueLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.TotalRevenueLb.Location = new System.Drawing.Point(221, 319);
            this.TotalRevenueLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalRevenueLb.Name = "TotalRevenueLb";
            this.TotalRevenueLb.Size = new System.Drawing.Size(152, 24);
            this.TotalRevenueLb.TabIndex = 24;
            this.TotalRevenueLb.Text = "Tổng doanh thu:";
            this.TotalRevenueLb.Visible = false;
            // 
            // AverageInvoiceValueLb
            // 
            this.AverageInvoiceValueLb.AutoSize = true;
            this.AverageInvoiceValueLb.BackColor = System.Drawing.Color.Transparent;
            this.AverageInvoiceValueLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.AverageInvoiceValueLb.Location = new System.Drawing.Point(221, 266);
            this.AverageInvoiceValueLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverageInvoiceValueLb.Name = "AverageInvoiceValueLb";
            this.AverageInvoiceValueLb.Size = new System.Drawing.Size(281, 24);
            this.AverageInvoiceValueLb.TabIndex = 23;
            this.AverageInvoiceValueLb.Text = "Giá trị trung bình trên hoá đơn:";
            this.AverageInvoiceValueLb.Visible = false;
            // 
            // TotalInvoiceLb
            // 
            this.TotalInvoiceLb.AutoSize = true;
            this.TotalInvoiceLb.BackColor = System.Drawing.Color.Transparent;
            this.TotalInvoiceLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.TotalInvoiceLb.Location = new System.Drawing.Point(221, 212);
            this.TotalInvoiceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalInvoiceLb.Name = "TotalInvoiceLb";
            this.TotalInvoiceLb.Size = new System.Drawing.Size(305, 24);
            this.TotalInvoiceLb.TabIndex = 22;
            this.TotalInvoiceLb.Text = "Tổng số lượng hoá đơn bán hàng:\r\n";
            this.TotalInvoiceLb.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(1022, 25);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(115, 66);
            this.BackButton.TabIndex = 34;
            this.BackButton.Text = "QUAY LẠI";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // PrintButton
            // 
            this.PrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.PrintButton.Location = new System.Drawing.Point(1157, 25);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(116, 66);
            this.PrintButton.TabIndex = 33;
            this.PrintButton.Text = "IN BÁO CÁO";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Visible = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click_1);
            // 
            // StaffInfoCheckingEP
            // 
            this.StaffInfoCheckingEP.ContainerControl = this;
            // 
            // UC_RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StaffIDTxb);
            this.Controls.Add(this.ReportMakerTxb);
            this.Controls.Add(this.StaffIDLb);
            this.Controls.Add(this.ReportMakerLb);
            this.Controls.Add(this.InvoiceDataGB);
            this.Controls.Add(this.AverageInvoiceValueNum);
            this.Controls.Add(this.TotalRevenueNum);
            this.Controls.Add(this.TotalInvoiceNum);
            this.Controls.Add(this.TotalRevenueLb);
            this.Controls.Add(this.AverageInvoiceValueLb);
            this.Controls.Add(this.TotalInvoiceLb);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AnnualReportButton);
            this.Controls.Add(this.MonthlyReportButton);
            this.Controls.Add(this.WeeklyReportButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_RevenueReport";
            this.Size = new System.Drawing.Size(1321, 796);
            this.InvoiceDataGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageInvoiceValueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalRevenueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalInvoiceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffInfoCheckingEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnualReportButton;
        private System.Windows.Forms.Button MonthlyReportButton;
        private System.Windows.Forms.Button WeeklyReportButton;
        private System.Windows.Forms.TextBox StaffIDTxb;
        private System.Windows.Forms.TextBox ReportMakerTxb;
        private System.Windows.Forms.Label StaffIDLb;
        private System.Windows.Forms.Label ReportMakerLb;
        private System.Windows.Forms.GroupBox InvoiceDataGB;
        private System.Windows.Forms.DataGridView InvoiceDataDG;
        private System.Windows.Forms.NumericUpDown AverageInvoiceValueNum;
        private System.Windows.Forms.NumericUpDown TotalRevenueNum;
        private System.Windows.Forms.NumericUpDown TotalInvoiceNum;
        private System.Windows.Forms.Label TotalRevenueLb;
        private System.Windows.Forms.Label AverageInvoiceValueLb;
        private System.Windows.Forms.Label TotalInvoiceLb;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ErrorProvider StaffInfoCheckingEP;
    }
}
