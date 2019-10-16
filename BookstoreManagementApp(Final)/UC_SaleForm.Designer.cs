namespace BookstoreManagementApp_Final_
{
    partial class UC_SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SaleForm));
            this.PrntPreviewBtn = new System.Windows.Forms.Button();
            this.prntOderBtn = new System.Windows.Forms.Button();
            this.BookSaleButton = new System.Windows.Forms.Button();
            this.DiscountRateNum = new System.Windows.Forms.NumericUpDown();
            this.DiscountRateLb = new System.Windows.Forms.Label();
            this.GiveBackButton = new System.Windows.Forms.Button();
            this.CusPaymentAmountNum = new System.Windows.Forms.NumericUpDown();
            this.CusPaymentAmountLb = new System.Windows.Forms.Label();
            this.PaidProductGB = new System.Windows.Forms.GroupBox();
            this.PaidProductDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleCodeTxb = new System.Windows.Forms.TextBox();
            this.BookTitleCodeLb = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EnteredProductGB = new System.Windows.Forms.GroupBox();
            this.EnteredProductDG = new System.Windows.Forms.DataGridView();
            this.BookTitlleCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterimPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAfterDiscountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCodeTxb = new System.Windows.Forms.TextBox();
            this.BookCodeLb = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errorPlaceEP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountRateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusPaymentAmountNum)).BeginInit();
            this.PaidProductGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaidProductDG)).BeginInit();
            this.EnteredProductGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnteredProductDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPlaceEP)).BeginInit();
            this.SuspendLayout();
            // 
            // PrntPreviewBtn
            // 
            this.PrntPreviewBtn.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.PrntPreviewBtn.Location = new System.Drawing.Point(766, 23);
            this.PrntPreviewBtn.Name = "PrntPreviewBtn";
            this.PrntPreviewBtn.Size = new System.Drawing.Size(101, 42);
            this.PrntPreviewBtn.TabIndex = 54;
            this.PrntPreviewBtn.Text = "XEM TRƯỚC BẢN IN";
            this.PrntPreviewBtn.UseVisualStyleBackColor = true;
            this.PrntPreviewBtn.Click += new System.EventHandler(this.PrntPreviewBtn_Click_1);
            // 
            // prntOderBtn
            // 
            this.prntOderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prntOderBtn.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.prntOderBtn.Location = new System.Drawing.Point(664, 23);
            this.prntOderBtn.Name = "prntOderBtn";
            this.prntOderBtn.Size = new System.Drawing.Size(96, 42);
            this.prntOderBtn.TabIndex = 53;
            this.prntOderBtn.Text = "IN HÓA ĐƠN THANH TOÁN";
            this.prntOderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.prntOderBtn.UseVisualStyleBackColor = true;
            this.prntOderBtn.Click += new System.EventHandler(this.prntOderBtn_Click_1);
            // 
            // BookSaleButton
            // 
            this.BookSaleButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.BookSaleButton.Location = new System.Drawing.Point(874, 23);
            this.BookSaleButton.Name = "BookSaleButton";
            this.BookSaleButton.Size = new System.Drawing.Size(75, 42);
            this.BookSaleButton.TabIndex = 52;
            this.BookSaleButton.Text = "THANH TOÁN";
            this.BookSaleButton.UseVisualStyleBackColor = true;
            this.BookSaleButton.Visible = false;
            // 
            // DiscountRateNum
            // 
            this.DiscountRateNum.Enabled = false;
            this.DiscountRateNum.Location = new System.Drawing.Point(214, 132);
            this.DiscountRateNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DiscountRateNum.Name = "DiscountRateNum";
            this.DiscountRateNum.Size = new System.Drawing.Size(206, 20);
            this.DiscountRateNum.TabIndex = 51;
            this.DiscountRateNum.Visible = false;
            // 
            // DiscountRateLb
            // 
            this.DiscountRateLb.AutoSize = true;
            this.DiscountRateLb.BackColor = System.Drawing.Color.Transparent;
            this.DiscountRateLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.DiscountRateLb.Location = new System.Drawing.Point(42, 128);
            this.DiscountRateLb.Name = "DiscountRateLb";
            this.DiscountRateLb.Size = new System.Drawing.Size(125, 21);
            this.DiscountRateLb.TabIndex = 50;
            this.DiscountRateLb.Text = "Mức chiết khấu:";
            this.DiscountRateLb.Visible = false;
            // 
            // GiveBackButton
            // 
            this.GiveBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GiveBackButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.GiveBackButton.Location = new System.Drawing.Point(780, 139);
            this.GiveBackButton.Name = "GiveBackButton";
            this.GiveBackButton.Size = new System.Drawing.Size(82, 46);
            this.GiveBackButton.TabIndex = 49;
            this.GiveBackButton.Text = "Hoàn trả (Hoàn tác)";
            this.GiveBackButton.UseVisualStyleBackColor = true;
            this.GiveBackButton.Visible = false;
            this.GiveBackButton.Click += new System.EventHandler(this.GiveBackButton_Click_1);
            // 
            // CusPaymentAmountNum
            // 
            this.CusPaymentAmountNum.Enabled = false;
            this.CusPaymentAmountNum.Location = new System.Drawing.Point(214, 167);
            this.CusPaymentAmountNum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.CusPaymentAmountNum.Name = "CusPaymentAmountNum";
            this.CusPaymentAmountNum.Size = new System.Drawing.Size(206, 20);
            this.CusPaymentAmountNum.TabIndex = 48;
            this.CusPaymentAmountNum.Visible = false;
            // 
            // CusPaymentAmountLb
            // 
            this.CusPaymentAmountLb.AutoSize = true;
            this.CusPaymentAmountLb.BackColor = System.Drawing.Color.Transparent;
            this.CusPaymentAmountLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.CusPaymentAmountLb.Location = new System.Drawing.Point(42, 166);
            this.CusPaymentAmountLb.Name = "CusPaymentAmountLb";
            this.CusPaymentAmountLb.Size = new System.Drawing.Size(170, 21);
            this.CusPaymentAmountLb.TabIndex = 47;
            this.CusPaymentAmountLb.Text = "Số tiền KH thanh toán:";
            this.CusPaymentAmountLb.Visible = false;
            // 
            // PaidProductGB
            // 
            this.PaidProductGB.BackColor = System.Drawing.Color.Transparent;
            this.PaidProductGB.Controls.Add(this.PaidProductDG);
            this.PaidProductGB.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.PaidProductGB.Location = new System.Drawing.Point(38, 416);
            this.PaidProductGB.Name = "PaidProductGB";
            this.PaidProductGB.Size = new System.Drawing.Size(912, 214);
            this.PaidProductGB.TabIndex = 44;
            this.PaidProductGB.TabStop = false;
            this.PaidProductGB.Text = "Sản phẩm đã thanh toán";
            this.PaidProductGB.Visible = false;
            // 
            // PaidProductDG
            // 
            this.PaidProductDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaidProductDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaidProductDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DiscountCol});
            this.PaidProductDG.Location = new System.Drawing.Point(6, 25);
            this.PaidProductDG.Name = "PaidProductDG";
            this.PaidProductDG.ReadOnly = true;
            this.PaidProductDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaidProductDG.Size = new System.Drawing.Size(900, 182);
            this.PaidProductDG.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tổng sản phẩm khách hàng mua";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Số tiền khách hàng phải thanh toán";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tiến thừa của khách hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DiscountCol
            // 
            this.DiscountCol.HeaderText = "Chiết khấu";
            this.DiscountCol.Name = "DiscountCol";
            this.DiscountCol.ReadOnly = true;
            // 
            // BookTitleCodeTxb
            // 
            this.BookTitleCodeTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.BookTitleCodeTxb.Location = new System.Drawing.Point(732, 89);
            this.BookTitleCodeTxb.Name = "BookTitleCodeTxb";
            this.BookTitleCodeTxb.Size = new System.Drawing.Size(218, 22);
            this.BookTitleCodeTxb.TabIndex = 42;
            this.BookTitleCodeTxb.Visible = false;
            // 
            // BookTitleCodeLb
            // 
            this.BookTitleCodeLb.AutoSize = true;
            this.BookTitleCodeLb.BackColor = System.Drawing.Color.Transparent;
            this.BookTitleCodeLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.BookTitleCodeLb.Location = new System.Drawing.Point(460, 89);
            this.BookTitleCodeLb.Name = "BookTitleCodeLb";
            this.BookTitleCodeLb.Size = new System.Drawing.Size(254, 21);
            this.BookTitleCodeLb.TabIndex = 46;
            this.BookTitleCodeLb.Text = "Mã tựa sách (mã loại sản phẩm):";
            this.BookTitleCodeLb.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.Location = new System.Drawing.Point(867, 139);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 46);
            this.SubmitButton.TabIndex = 45;
            this.SubmitButton.Text = "Thêm vào giỏ hàng";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // EnteredProductGB
            // 
            this.EnteredProductGB.BackColor = System.Drawing.Color.Transparent;
            this.EnteredProductGB.Controls.Add(this.EnteredProductDG);
            this.EnteredProductGB.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.EnteredProductGB.Location = new System.Drawing.Point(38, 202);
            this.EnteredProductGB.Name = "EnteredProductGB";
            this.EnteredProductGB.Size = new System.Drawing.Size(912, 211);
            this.EnteredProductGB.TabIndex = 43;
            this.EnteredProductGB.TabStop = false;
            this.EnteredProductGB.Text = "Sản phẩm đã nhập để thanh toán";
            this.EnteredProductGB.Visible = false;
            // 
            // EnteredProductDG
            // 
            this.EnteredProductDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EnteredProductDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnteredProductDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookTitlleCodeCol,
            this.BookCodeCol,
            this.PaymentAmountCol,
            this.InterimPriceCol,
            this.AmountAfterDiscountCol});
            this.EnteredProductDG.Location = new System.Drawing.Point(6, 19);
            this.EnteredProductDG.Name = "EnteredProductDG";
            this.EnteredProductDG.ReadOnly = true;
            this.EnteredProductDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnteredProductDG.Size = new System.Drawing.Size(900, 182);
            this.EnteredProductDG.TabIndex = 0;
            this.EnteredProductDG.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnteredProductDG_RowEnter_1);
            // 
            // BookTitlleCodeCol
            // 
            this.BookTitlleCodeCol.HeaderText = "Mã tựa sách (mã loại sản phẩm)";
            this.BookTitlleCodeCol.Name = "BookTitlleCodeCol";
            this.BookTitlleCodeCol.ReadOnly = true;
            // 
            // BookCodeCol
            // 
            this.BookCodeCol.HeaderText = "Mã sản phẩm";
            this.BookCodeCol.Name = "BookCodeCol";
            this.BookCodeCol.ReadOnly = true;
            // 
            // PaymentAmountCol
            // 
            this.PaymentAmountCol.HeaderText = "Giá ";
            this.PaymentAmountCol.Name = "PaymentAmountCol";
            this.PaymentAmountCol.ReadOnly = true;
            // 
            // InterimPriceCol
            // 
            this.InterimPriceCol.HeaderText = "Giá tạm tính";
            this.InterimPriceCol.Name = "InterimPriceCol";
            this.InterimPriceCol.ReadOnly = true;
            // 
            // AmountAfterDiscountCol
            // 
            this.AmountAfterDiscountCol.HeaderText = "Thành tiền thanh toán sau chiết khấu";
            this.AmountAfterDiscountCol.Name = "AmountAfterDiscountCol";
            this.AmountAfterDiscountCol.ReadOnly = true;
            // 
            // BookCodeTxb
            // 
            this.BookCodeTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.BookCodeTxb.Location = new System.Drawing.Point(214, 91);
            this.BookCodeTxb.Name = "BookCodeTxb";
            this.BookCodeTxb.Size = new System.Drawing.Size(207, 22);
            this.BookCodeTxb.TabIndex = 41;
            this.BookCodeTxb.Visible = false;
            // 
            // BookCodeLb
            // 
            this.BookCodeLb.AutoSize = true;
            this.BookCodeLb.BackColor = System.Drawing.Color.Transparent;
            this.BookCodeLb.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.BookCodeLb.Location = new System.Drawing.Point(42, 92);
            this.BookCodeLb.Name = "BookCodeLb";
            this.BookCodeLb.Size = new System.Drawing.Size(114, 21);
            this.BookCodeLb.TabIndex = 40;
            this.BookCodeLb.Text = "Mã sản phẩm:";
            this.BookCodeLb.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // errorPlaceEP
            // 
            this.errorPlaceEP.ContainerControl = this;
            // 
            // UC_SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrntPreviewBtn);
            this.Controls.Add(this.prntOderBtn);
            this.Controls.Add(this.BookSaleButton);
            this.Controls.Add(this.DiscountRateNum);
            this.Controls.Add(this.DiscountRateLb);
            this.Controls.Add(this.GiveBackButton);
            this.Controls.Add(this.CusPaymentAmountNum);
            this.Controls.Add(this.CusPaymentAmountLb);
            this.Controls.Add(this.PaidProductGB);
            this.Controls.Add(this.BookTitleCodeTxb);
            this.Controls.Add(this.BookTitleCodeLb);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.EnteredProductGB);
            this.Controls.Add(this.BookCodeTxb);
            this.Controls.Add(this.BookCodeLb);
            this.Name = "UC_SaleForm";
            this.Size = new System.Drawing.Size(991, 647);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountRateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusPaymentAmountNum)).EndInit();
            this.PaidProductGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaidProductDG)).EndInit();
            this.EnteredProductGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnteredProductDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPlaceEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrntPreviewBtn;
        private System.Windows.Forms.Button prntOderBtn;
        private System.Windows.Forms.Button BookSaleButton;
        private System.Windows.Forms.NumericUpDown DiscountRateNum;
        private System.Windows.Forms.Label DiscountRateLb;
        private System.Windows.Forms.Button GiveBackButton;
        private System.Windows.Forms.NumericUpDown CusPaymentAmountNum;
        private System.Windows.Forms.Label CusPaymentAmountLb;
        private System.Windows.Forms.GroupBox PaidProductGB;
        private System.Windows.Forms.DataGridView PaidProductDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCol;
        private System.Windows.Forms.TextBox BookTitleCodeTxb;
        private System.Windows.Forms.Label BookTitleCodeLb;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox EnteredProductGB;
        private System.Windows.Forms.DataGridView EnteredProductDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitlleCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterimPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAfterDiscountCol;
        private System.Windows.Forms.TextBox BookCodeTxb;
        private System.Windows.Forms.Label BookCodeLb;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ErrorProvider errorPlaceEP;
    }
}
