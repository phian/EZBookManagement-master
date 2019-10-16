namespace BookstoreManagementApp_Final_
{
    partial class UC_BookManage
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.BookIDFilterTxb = new System.Windows.Forms.TextBox();
            this.BookIDFilterLb = new System.Windows.Forms.Label();
            this.BookPriceNum = new System.Windows.Forms.NumericUpDown();
            this.BookRepublishedTimeNum = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BookPublishDateDTP = new System.Windows.Forms.DateTimePicker();
            this.BookStatisticGB = new System.Windows.Forms.GroupBox();
            this.BookStatisticDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedBookGB = new System.Windows.Forms.GroupBox();
            this.AddedBookDG = new System.Windows.Forms.DataGridView();
            this.BookIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthorNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTranslatorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublishedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookRepublisedTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleCodeTxb = new System.Windows.Forms.TextBox();
            this.BookTitleCodeLb = new System.Windows.Forms.Label();
            this.BookTypeTxb = new System.Windows.Forms.TextBox();
            this.BookTypeLb = new System.Windows.Forms.Label();
            this.BookPriceLb = new System.Windows.Forms.Label();
            this.BookRepublishedTimeLb = new System.Windows.Forms.Label();
            this.BookPublishDateLb = new System.Windows.Forms.Label();
            this.BookTranslatorNameTxb = new System.Windows.Forms.TextBox();
            this.BookTranslatorNameLb = new System.Windows.Forms.Label();
            this.BookAuthorNameTxb = new System.Windows.Forms.TextBox();
            this.BookAuthorNameLb = new System.Windows.Forms.Label();
            this.BookNameTxb = new System.Windows.Forms.TextBox();
            this.BookNameLb = new System.Windows.Forms.Label();
            this.BookIDTxb = new System.Windows.Forms.TextBox();
            this.BookIDLb = new System.Windows.Forms.Label();
            this.ErrorPlace = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BookPriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookRepublishedTimeNum)).BeginInit();
            this.BookStatisticGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookStatisticDG)).BeginInit();
            this.AddedBookGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddedBookDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.SearchButton.Location = new System.Drawing.Point(19, 350);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 41);
            this.SearchButton.TabIndex = 52;
            this.SearchButton.Text = "TÌM KIẾM";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBookButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.DeleteBookButton.Location = new System.Drawing.Point(19, 274);
            this.DeleteBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(107, 41);
            this.DeleteBookButton.TabIndex = 51;
            this.DeleteBookButton.Text = "XÓA";
            this.DeleteBookButton.UseVisualStyleBackColor = false;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click_1);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.AddBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBookButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.AddBookButton.Location = new System.Drawing.Point(19, 116);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(107, 41);
            this.AddBookButton.TabIndex = 50;
            this.AddBookButton.Text = "THÊM";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click_1);
            // 
            // EditBookButton
            // 
            this.EditBookButton.BackColor = System.Drawing.Color.Transparent;
            this.EditBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBookButton.Font = new System.Drawing.Font("UTM Avo", 8.5F, System.Drawing.FontStyle.Bold);
            this.EditBookButton.Location = new System.Drawing.Point(19, 196);
            this.EditBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(107, 41);
            this.EditBookButton.TabIndex = 49;
            this.EditBookButton.Text = "SỬA";
            this.EditBookButton.UseVisualStyleBackColor = false;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click_1);
            // 
            // BookIDFilterTxb
            // 
            this.BookIDFilterTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.BookIDFilterTxb.Location = new System.Drawing.Point(849, 297);
            this.BookIDFilterTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookIDFilterTxb.Name = "BookIDFilterTxb";
            this.BookIDFilterTxb.Size = new System.Drawing.Size(305, 31);
            this.BookIDFilterTxb.TabIndex = 76;
            this.BookIDFilterTxb.Visible = false;
            this.BookIDFilterTxb.TextChanged += new System.EventHandler(this.BookIDFilterTxb_TextChanged_1);
            // 
            // BookIDFilterLb
            // 
            this.BookIDFilterLb.AutoSize = true;
            this.BookIDFilterLb.BackColor = System.Drawing.Color.Transparent;
            this.BookIDFilterLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookIDFilterLb.Location = new System.Drawing.Point(654, 302);
            this.BookIDFilterLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookIDFilterLb.Name = "BookIDFilterLb";
            this.BookIDFilterLb.Size = new System.Drawing.Size(179, 28);
            this.BookIDFilterLb.TabIndex = 75;
            this.BookIDFilterLb.Text = "Mã sách cần tìm:";
            this.BookIDFilterLb.Visible = false;
            // 
            // BookPriceNum
            // 
            this.BookPriceNum.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.BookPriceNum.Location = new System.Drawing.Point(849, 162);
            this.BookPriceNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookPriceNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.BookPriceNum.Name = "BookPriceNum";
            this.BookPriceNum.Size = new System.Drawing.Size(306, 31);
            this.BookPriceNum.TabIndex = 68;
            this.BookPriceNum.Visible = false;
            // 
            // BookRepublishedTimeNum
            // 
            this.BookRepublishedTimeNum.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.BookRepublishedTimeNum.Location = new System.Drawing.Point(849, 116);
            this.BookRepublishedTimeNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookRepublishedTimeNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.BookRepublishedTimeNum.Name = "BookRepublishedTimeNum";
            this.BookRepublishedTimeNum.Size = new System.Drawing.Size(144, 31);
            this.BookRepublishedTimeNum.TabIndex = 66;
            this.BookRepublishedTimeNum.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(1035, 41);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 47);
            this.SaveButton.TabIndex = 74;
            this.SaveButton.Text = "LƯU";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(891, 41);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 47);
            this.BackButton.TabIndex = 73;
            this.BackButton.Text = "QUAY LẠI";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // BookPublishDateDTP
            // 
            this.BookPublishDateDTP.CustomFormat = "dd/MM/yyyy";
            this.BookPublishDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BookPublishDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BookPublishDateDTP.Location = new System.Drawing.Point(326, 300);
            this.BookPublishDateDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookPublishDateDTP.Name = "BookPublishDateDTP";
            this.BookPublishDateDTP.Size = new System.Drawing.Size(257, 26);
            this.BookPublishDateDTP.TabIndex = 61;
            this.BookPublishDateDTP.Visible = false;
            // 
            // BookStatisticGB
            // 
            this.BookStatisticGB.BackColor = System.Drawing.Color.Transparent;
            this.BookStatisticGB.Controls.Add(this.BookStatisticDG);
            this.BookStatisticGB.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.BookStatisticGB.Location = new System.Drawing.Point(144, 571);
            this.BookStatisticGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookStatisticGB.Name = "BookStatisticGB";
            this.BookStatisticGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookStatisticGB.Size = new System.Drawing.Size(1130, 223);
            this.BookStatisticGB.TabIndex = 72;
            this.BookStatisticGB.TabStop = false;
            this.BookStatisticGB.Text = "Số lượng sách theo từng mã tựa sách";
            this.BookStatisticGB.Visible = false;
            // 
            // BookStatisticDG
            // 
            this.BookStatisticDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookStatisticDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookStatisticDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.BookAmountCol});
            this.BookStatisticDG.Location = new System.Drawing.Point(8, 30);
            this.BookStatisticDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookStatisticDG.Name = "BookStatisticDG";
            this.BookStatisticDG.Size = new System.Drawing.Size(1114, 185);
            this.BookStatisticDG.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã tựa sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BookAmountCol
            // 
            this.BookAmountCol.HeaderText = "Số lượng";
            this.BookAmountCol.Name = "BookAmountCol";
            this.BookAmountCol.ReadOnly = true;
            // 
            // AddedBookGB
            // 
            this.AddedBookGB.BackColor = System.Drawing.Color.Transparent;
            this.AddedBookGB.Controls.Add(this.AddedBookDG);
            this.AddedBookGB.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.AddedBookGB.Location = new System.Drawing.Point(144, 341);
            this.AddedBookGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedBookGB.Name = "AddedBookGB";
            this.AddedBookGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedBookGB.Size = new System.Drawing.Size(1130, 223);
            this.AddedBookGB.TabIndex = 70;
            this.AddedBookGB.TabStop = false;
            this.AddedBookGB.Text = "Sách đã thêm";
            this.AddedBookGB.Visible = false;
            // 
            // AddedBookDG
            // 
            this.AddedBookDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddedBookDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddedBookDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIDCol,
            this.BookNameCol,
            this.BookAuthorNameCol,
            this.BookTranslatorCol,
            this.BookPublishedDateCol,
            this.BookRepublisedTimeCol,
            this.BookPriceCol,
            this.BookTypeCol,
            this.BookTitleCodeCol});
            this.AddedBookDG.Location = new System.Drawing.Point(8, 30);
            this.AddedBookDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedBookDG.MultiSelect = false;
            this.AddedBookDG.Name = "AddedBookDG";
            this.AddedBookDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddedBookDG.Size = new System.Drawing.Size(1114, 185);
            this.AddedBookDG.TabIndex = 40;
            // 
            // BookIDCol
            // 
            this.BookIDCol.HeaderText = "Mã sách";
            this.BookIDCol.Name = "BookIDCol";
            // 
            // BookNameCol
            // 
            this.BookNameCol.HeaderText = "Tên sách";
            this.BookNameCol.Name = "BookNameCol";
            // 
            // BookAuthorNameCol
            // 
            this.BookAuthorNameCol.HeaderText = "Tên tác giả";
            this.BookAuthorNameCol.Name = "BookAuthorNameCol";
            this.BookAuthorNameCol.ReadOnly = true;
            // 
            // BookTranslatorCol
            // 
            this.BookTranslatorCol.HeaderText = "Dịch giả";
            this.BookTranslatorCol.Name = "BookTranslatorCol";
            this.BookTranslatorCol.ReadOnly = true;
            // 
            // BookPublishedDateCol
            // 
            this.BookPublishedDateCol.HeaderText = "Ngày xuất bản";
            this.BookPublishedDateCol.Name = "BookPublishedDateCol";
            this.BookPublishedDateCol.ReadOnly = true;
            // 
            // BookRepublisedTimeCol
            // 
            this.BookRepublisedTimeCol.HeaderText = "Lần tái bản";
            this.BookRepublisedTimeCol.Name = "BookRepublisedTimeCol";
            this.BookRepublisedTimeCol.ReadOnly = true;
            // 
            // BookPriceCol
            // 
            this.BookPriceCol.HeaderText = "Giá";
            this.BookPriceCol.Name = "BookPriceCol";
            this.BookPriceCol.ReadOnly = true;
            // 
            // BookTypeCol
            // 
            this.BookTypeCol.HeaderText = "Thể loại";
            this.BookTypeCol.Name = "BookTypeCol";
            this.BookTypeCol.ReadOnly = true;
            // 
            // BookTitleCodeCol
            // 
            this.BookTitleCodeCol.HeaderText = "Mã tựa sách";
            this.BookTitleCodeCol.Name = "BookTitleCodeCol";
            this.BookTitleCodeCol.ReadOnly = true;
            // 
            // BookTitleCodeTxb
            // 
            this.BookTitleCodeTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.BookTitleCodeTxb.Location = new System.Drawing.Point(849, 250);
            this.BookTitleCodeTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookTitleCodeTxb.Name = "BookTitleCodeTxb";
            this.BookTitleCodeTxb.Size = new System.Drawing.Size(305, 31);
            this.BookTitleCodeTxb.TabIndex = 71;
            this.BookTitleCodeTxb.Visible = false;
            // 
            // BookTitleCodeLb
            // 
            this.BookTitleCodeLb.AutoSize = true;
            this.BookTitleCodeLb.BackColor = System.Drawing.Color.Transparent;
            this.BookTitleCodeLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookTitleCodeLb.Location = new System.Drawing.Point(652, 253);
            this.BookTitleCodeLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookTitleCodeLb.Name = "BookTitleCodeLb";
            this.BookTitleCodeLb.Size = new System.Drawing.Size(138, 28);
            this.BookTitleCodeLb.TabIndex = 67;
            this.BookTitleCodeLb.Text = "Mã tựa sách:";
            this.BookTitleCodeLb.Visible = false;
            // 
            // BookTypeTxb
            // 
            this.BookTypeTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.BookTypeTxb.Location = new System.Drawing.Point(849, 204);
            this.BookTypeTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookTypeTxb.Name = "BookTypeTxb";
            this.BookTypeTxb.Size = new System.Drawing.Size(305, 31);
            this.BookTypeTxb.TabIndex = 69;
            this.BookTypeTxb.Visible = false;
            this.BookTypeTxb.Validated += new System.EventHandler(this.BookTypeTxb_Validated);
            // 
            // BookTypeLb
            // 
            this.BookTypeLb.AutoSize = true;
            this.BookTypeLb.BackColor = System.Drawing.Color.Transparent;
            this.BookTypeLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookTypeLb.Location = new System.Drawing.Point(654, 206);
            this.BookTypeLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookTypeLb.Name = "BookTypeLb";
            this.BookTypeLb.Size = new System.Drawing.Size(93, 28);
            this.BookTypeLb.TabIndex = 65;
            this.BookTypeLb.Text = "Thể loại:";
            this.BookTypeLb.Visible = false;
            // 
            // BookPriceLb
            // 
            this.BookPriceLb.AutoSize = true;
            this.BookPriceLb.BackColor = System.Drawing.Color.Transparent;
            this.BookPriceLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookPriceLb.Location = new System.Drawing.Point(654, 161);
            this.BookPriceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookPriceLb.Name = "BookPriceLb";
            this.BookPriceLb.Size = new System.Drawing.Size(52, 28);
            this.BookPriceLb.TabIndex = 64;
            this.BookPriceLb.Text = "Giá:";
            this.BookPriceLb.Visible = false;
            // 
            // BookRepublishedTimeLb
            // 
            this.BookRepublishedTimeLb.AutoSize = true;
            this.BookRepublishedTimeLb.BackColor = System.Drawing.Color.Transparent;
            this.BookRepublishedTimeLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookRepublishedTimeLb.Location = new System.Drawing.Point(654, 113);
            this.BookRepublishedTimeLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookRepublishedTimeLb.Name = "BookRepublishedTimeLb";
            this.BookRepublishedTimeLb.Size = new System.Drawing.Size(127, 28);
            this.BookRepublishedTimeLb.TabIndex = 63;
            this.BookRepublishedTimeLb.Text = "Lần tái bản:";
            this.BookRepublishedTimeLb.Visible = false;
            // 
            // BookPublishDateLb
            // 
            this.BookPublishDateLb.AutoSize = true;
            this.BookPublishDateLb.BackColor = System.Drawing.Color.Transparent;
            this.BookPublishDateLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookPublishDateLb.Location = new System.Drawing.Point(151, 301);
            this.BookPublishDateLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookPublishDateLb.Name = "BookPublishDateLb";
            this.BookPublishDateLb.Size = new System.Drawing.Size(163, 28);
            this.BookPublishDateLb.TabIndex = 62;
            this.BookPublishDateLb.Text = "Ngày xuất bản:";
            this.BookPublishDateLb.Visible = false;
            // 
            // BookTranslatorNameTxb
            // 
            this.BookTranslatorNameTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTranslatorNameTxb.Location = new System.Drawing.Point(326, 254);
            this.BookTranslatorNameTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookTranslatorNameTxb.Name = "BookTranslatorNameTxb";
            this.BookTranslatorNameTxb.Size = new System.Drawing.Size(257, 31);
            this.BookTranslatorNameTxb.TabIndex = 60;
            this.BookTranslatorNameTxb.Visible = false;
            this.BookTranslatorNameTxb.Validated += new System.EventHandler(this.BookTranslatorNameTxb_Validated_1);
            // 
            // BookTranslatorNameLb
            // 
            this.BookTranslatorNameLb.AutoSize = true;
            this.BookTranslatorNameLb.BackColor = System.Drawing.Color.Transparent;
            this.BookTranslatorNameLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookTranslatorNameLb.Location = new System.Drawing.Point(153, 259);
            this.BookTranslatorNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookTranslatorNameLb.Name = "BookTranslatorNameLb";
            this.BookTranslatorNameLb.Size = new System.Drawing.Size(98, 28);
            this.BookTranslatorNameLb.TabIndex = 59;
            this.BookTranslatorNameLb.Text = "Dịch giả:";
            this.BookTranslatorNameLb.Visible = false;
            // 
            // BookAuthorNameTxb
            // 
            this.BookAuthorNameTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAuthorNameTxb.Location = new System.Drawing.Point(326, 208);
            this.BookAuthorNameTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookAuthorNameTxb.Name = "BookAuthorNameTxb";
            this.BookAuthorNameTxb.Size = new System.Drawing.Size(257, 31);
            this.BookAuthorNameTxb.TabIndex = 58;
            this.BookAuthorNameTxb.Visible = false;
            this.BookAuthorNameTxb.Validated += new System.EventHandler(this.BookAuthorNameTxb_Validated_1);
            // 
            // BookAuthorNameLb
            // 
            this.BookAuthorNameLb.AutoSize = true;
            this.BookAuthorNameLb.BackColor = System.Drawing.Color.Transparent;
            this.BookAuthorNameLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookAuthorNameLb.Location = new System.Drawing.Point(153, 215);
            this.BookAuthorNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookAuthorNameLb.Name = "BookAuthorNameLb";
            this.BookAuthorNameLb.Size = new System.Drawing.Size(126, 28);
            this.BookAuthorNameLb.TabIndex = 57;
            this.BookAuthorNameLb.Text = "Tên tác giả:";
            this.BookAuthorNameLb.Visible = false;
            // 
            // BookNameTxb
            // 
            this.BookNameTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameTxb.Location = new System.Drawing.Point(326, 163);
            this.BookNameTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookNameTxb.Name = "BookNameTxb";
            this.BookNameTxb.Size = new System.Drawing.Size(257, 31);
            this.BookNameTxb.TabIndex = 56;
            this.BookNameTxb.Visible = false;
            this.BookNameTxb.Validated += new System.EventHandler(this.BookNameTxb_Validated_1);
            // 
            // BookNameLb
            // 
            this.BookNameLb.AutoSize = true;
            this.BookNameLb.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookNameLb.Location = new System.Drawing.Point(153, 167);
            this.BookNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookNameLb.Name = "BookNameLb";
            this.BookNameLb.Size = new System.Drawing.Size(103, 28);
            this.BookNameLb.TabIndex = 55;
            this.BookNameLb.Text = "Tên sách:";
            this.BookNameLb.Visible = false;
            // 
            // BookIDTxb
            // 
            this.BookIDTxb.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDTxb.Location = new System.Drawing.Point(326, 116);
            this.BookIDTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookIDTxb.Name = "BookIDTxb";
            this.BookIDTxb.Size = new System.Drawing.Size(257, 31);
            this.BookIDTxb.TabIndex = 54;
            this.BookIDTxb.Visible = false;
            // 
            // BookIDLb
            // 
            this.BookIDLb.AutoSize = true;
            this.BookIDLb.BackColor = System.Drawing.Color.Transparent;
            this.BookIDLb.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.BookIDLb.Location = new System.Drawing.Point(153, 123);
            this.BookIDLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookIDLb.Name = "BookIDLb";
            this.BookIDLb.Size = new System.Drawing.Size(100, 28);
            this.BookIDLb.TabIndex = 53;
            this.BookIDLb.Text = "Mã sách:";
            this.BookIDLb.Visible = false;
            // 
            // ErrorPlace
            // 
            this.ErrorPlace.ContainerControl = this;
            // 
            // UC_BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BookIDFilterTxb);
            this.Controls.Add(this.BookIDFilterLb);
            this.Controls.Add(this.BookPriceNum);
            this.Controls.Add(this.BookRepublishedTimeNum);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BookPublishDateDTP);
            this.Controls.Add(this.BookStatisticGB);
            this.Controls.Add(this.AddedBookGB);
            this.Controls.Add(this.BookTitleCodeTxb);
            this.Controls.Add(this.BookTitleCodeLb);
            this.Controls.Add(this.BookTypeTxb);
            this.Controls.Add(this.BookTypeLb);
            this.Controls.Add(this.BookPriceLb);
            this.Controls.Add(this.BookRepublishedTimeLb);
            this.Controls.Add(this.BookPublishDateLb);
            this.Controls.Add(this.BookTranslatorNameTxb);
            this.Controls.Add(this.BookTranslatorNameLb);
            this.Controls.Add(this.BookAuthorNameTxb);
            this.Controls.Add(this.BookAuthorNameLb);
            this.Controls.Add(this.BookNameTxb);
            this.Controls.Add(this.BookNameLb);
            this.Controls.Add(this.BookIDTxb);
            this.Controls.Add(this.BookIDLb);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.EditBookButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_BookManage";
            this.Size = new System.Drawing.Size(1321, 796);
            this.Load += new System.EventHandler(this.UC_BookManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookRepublishedTimeNum)).EndInit();
            this.BookStatisticGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookStatisticDG)).EndInit();
            this.AddedBookGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddedBookDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.TextBox BookIDFilterTxb;
        private System.Windows.Forms.Label BookIDFilterLb;
        private System.Windows.Forms.NumericUpDown BookPriceNum;
        private System.Windows.Forms.NumericUpDown BookRepublishedTimeNum;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker BookPublishDateDTP;
        private System.Windows.Forms.GroupBox BookStatisticGB;
        private System.Windows.Forms.DataGridView BookStatisticDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAmountCol;
        private System.Windows.Forms.GroupBox AddedBookGB;
        private System.Windows.Forms.DataGridView AddedBookDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthorNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTranslatorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPublishedDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookRepublisedTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitleCodeCol;
        private System.Windows.Forms.TextBox BookTitleCodeTxb;
        private System.Windows.Forms.Label BookTitleCodeLb;
        private System.Windows.Forms.TextBox BookTypeTxb;
        private System.Windows.Forms.Label BookTypeLb;
        private System.Windows.Forms.Label BookPriceLb;
        private System.Windows.Forms.Label BookRepublishedTimeLb;
        private System.Windows.Forms.Label BookPublishDateLb;
        private System.Windows.Forms.TextBox BookTranslatorNameTxb;
        private System.Windows.Forms.Label BookTranslatorNameLb;
        private System.Windows.Forms.TextBox BookAuthorNameTxb;
        private System.Windows.Forms.Label BookAuthorNameLb;
        private System.Windows.Forms.TextBox BookNameTxb;
        private System.Windows.Forms.Label BookNameLb;
        private System.Windows.Forms.TextBox BookIDTxb;
        private System.Windows.Forms.Label BookIDLb;
        private System.Windows.Forms.ErrorProvider ErrorPlace;
    }
}
