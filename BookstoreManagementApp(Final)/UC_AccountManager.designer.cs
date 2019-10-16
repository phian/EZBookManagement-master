namespace BookstoreManagementApp_Final_
{
    partial class UC_AccountManager
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
            this.label4 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_account_list = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCESSLEVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_accesslevel = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.bt_change_password = new System.Windows.Forms.Button();
            this.lb_newpass = new System.Windows.Forms.Label();
            this.lb_confirm_newpass = new System.Windows.Forms.Label();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.tb_confirm_newpass = new System.Windows.Forms.TextBox();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.pn_change_pass = new System.Windows.Forms.Panel();
            this.tb_ch_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_username2 = new System.Windows.Forms.TextBox();
            this.lb_username2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_create = new System.Windows.Forms.Button();
            this.pn_crt_account = new System.Windows.Forms.Panel();
            this.tb_crt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_crt_username = new System.Windows.Forms.TextBox();
            this.cb_crt_aceslevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_crt_password = new System.Windows.Forms.TextBox();
            this.tb_crt_cf_pass = new System.Windows.Forms.TextBox();
            this.pn_promote = new System.Windows.Forms.Panel();
            this.tb_pro_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_username3 = new System.Windows.Forms.TextBox();
            this.bt3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_cf_promote = new System.Windows.Forms.Button();
            this.tb_pro_aclvl = new System.Windows.Forms.ComboBox();
            this.bt_promote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_delete_account = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account_list)).BeginInit();
            this.pn_change_pass.SuspendLayout();
            this.pn_crt_account.SuspendLayout();
            this.pn_promote.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(240, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 44);
            this.label4.TabIndex = 45;
            this.label4.Text = "QUẢN LÝ TÀI KHOẢN ĐĂNG NHẬP";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.lb_id.Location = new System.Drawing.Point(58, 106);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(112, 21);
            this.lb_id.TabIndex = 46;
            this.lb_id.Text = "Mã nhân viên:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.lb_name.Location = new System.Drawing.Point(58, 147);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(61, 21);
            this.lb_name.TabIndex = 47;
            this.lb_name.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(58, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cấp bậc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(58, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // dgv_account_list
            // 
            this.dgv_account_list.AllowUserToAddRows = false;
            this.dgv_account_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FULLNAME,
            this.USERNAME,
            this.ACCESSLEVEL});
            this.dgv_account_list.Location = new System.Drawing.Point(0, 29);
            this.dgv_account_list.Name = "dgv_account_list";
            this.dgv_account_list.Size = new System.Drawing.Size(982, 171);
            this.dgv_account_list.TabIndex = 50;
            this.dgv_account_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_list_CellClick);
            this.dgv_account_list.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_list_RowEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "FULLNAME";
            this.FULLNAME.HeaderText = "Họ tên";
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.ReadOnly = true;
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Tài khoản";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // ACCESSLEVEL
            // 
            this.ACCESSLEVEL.DataPropertyName = "ACCESSLEVEL";
            this.ACCESSLEVEL.HeaderText = "Cấp bậc";
            this.ACCESSLEVEL.Name = "ACCESSLEVEL";
            this.ACCESSLEVEL.ReadOnly = true;
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(188, 105);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(200, 22);
            this.tb_id.TabIndex = 51;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(188, 147);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(200, 22);
            this.tb_name.TabIndex = 52;
            // 
            // tb_accesslevel
            // 
            this.tb_accesslevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_accesslevel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_accesslevel.Location = new System.Drawing.Point(188, 191);
            this.tb_accesslevel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_accesslevel.Multiline = true;
            this.tb_accesslevel.Name = "tb_accesslevel";
            this.tb_accesslevel.ReadOnly = true;
            this.tb_accesslevel.Size = new System.Drawing.Size(200, 22);
            this.tb_accesslevel.TabIndex = 53;
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(188, 232);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(200, 22);
            this.tb_username.TabIndex = 54;
            // 
            // bt_change_password
            // 
            this.bt_change_password.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold);
            this.bt_change_password.Location = new System.Drawing.Point(256, 278);
            this.bt_change_password.Name = "bt_change_password";
            this.bt_change_password.Size = new System.Drawing.Size(149, 35);
            this.bt_change_password.TabIndex = 55;
            this.bt_change_password.Text = "Đổi mật khẩu";
            this.bt_change_password.UseVisualStyleBackColor = true;
            this.bt_change_password.Click += new System.EventHandler(this.bt_change_password_Click);
            // 
            // lb_newpass
            // 
            this.lb_newpass.AutoSize = true;
            this.lb_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newpass.Location = new System.Drawing.Point(3, 125);
            this.lb_newpass.Name = "lb_newpass";
            this.lb_newpass.Size = new System.Drawing.Size(121, 20);
            this.lb_newpass.TabIndex = 56;
            this.lb_newpass.Text = "Mật khẩu mới:";
            // 
            // lb_confirm_newpass
            // 
            this.lb_confirm_newpass.AutoSize = true;
            this.lb_confirm_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm_newpass.Location = new System.Drawing.Point(3, 167);
            this.lb_confirm_newpass.Name = "lb_confirm_newpass";
            this.lb_confirm_newpass.Size = new System.Drawing.Size(191, 20);
            this.lb_confirm_newpass.TabIndex = 57;
            this.lb_confirm_newpass.Text = "Nhập lại mật khẩu mới:";
            // 
            // tb_newpass
            // 
            this.tb_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_newpass.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newpass.Location = new System.Drawing.Point(203, 124);
            this.tb_newpass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(186, 24);
            this.tb_newpass.TabIndex = 58;
            this.tb_newpass.UseSystemPasswordChar = true;
            // 
            // tb_confirm_newpass
            // 
            this.tb_confirm_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirm_newpass.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirm_newpass.Location = new System.Drawing.Point(203, 165);
            this.tb_confirm_newpass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_confirm_newpass.Name = "tb_confirm_newpass";
            this.tb_confirm_newpass.Size = new System.Drawing.Size(186, 24);
            this.tb_confirm_newpass.TabIndex = 59;
            this.tb_confirm_newpass.UseSystemPasswordChar = true;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirm.Location = new System.Drawing.Point(45, 212);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(149, 35);
            this.bt_confirm.TabIndex = 60;
            this.bt_confirm.Text = "Xác nhận";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(225, 212);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(149, 35);
            this.bt_cancel.TabIndex = 61;
            this.bt_cancel.Text = "Huỷ";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // pn_change_pass
            // 
            this.pn_change_pass.Controls.Add(this.tb_ch_id);
            this.pn_change_pass.Controls.Add(this.label12);
            this.pn_change_pass.Controls.Add(this.tb_username2);
            this.pn_change_pass.Controls.Add(this.lb_username2);
            this.pn_change_pass.Controls.Add(this.lb_newpass);
            this.pn_change_pass.Controls.Add(this.bt_cancel);
            this.pn_change_pass.Controls.Add(this.lb_confirm_newpass);
            this.pn_change_pass.Controls.Add(this.bt_confirm);
            this.pn_change_pass.Controls.Add(this.tb_newpass);
            this.pn_change_pass.Controls.Add(this.tb_confirm_newpass);
            this.pn_change_pass.Location = new System.Drawing.Point(472, 70);
            this.pn_change_pass.Name = "pn_change_pass";
            this.pn_change_pass.Size = new System.Drawing.Size(411, 256);
            this.pn_change_pass.TabIndex = 62;
            // 
            // tb_ch_id
            // 
            this.tb_ch_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ch_id.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ch_id.Location = new System.Drawing.Point(203, 33);
            this.tb_ch_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ch_id.Multiline = true;
            this.tb_ch_id.Name = "tb_ch_id";
            this.tb_ch_id.ReadOnly = true;
            this.tb_ch_id.Size = new System.Drawing.Size(186, 21);
            this.tb_ch_id.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "ID:";
            // 
            // tb_username2
            // 
            this.tb_username2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username2.Location = new System.Drawing.Point(203, 82);
            this.tb_username2.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username2.Multiline = true;
            this.tb_username2.Name = "tb_username2";
            this.tb_username2.ReadOnly = true;
            this.tb_username2.Size = new System.Drawing.Size(186, 21);
            this.tb_username2.TabIndex = 63;
            // 
            // lb_username2
            // 
            this.lb_username2.AutoSize = true;
            this.lb_username2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username2.Location = new System.Drawing.Point(3, 82);
            this.lb_username2.Name = "lb_username2";
            this.lb_username2.Size = new System.Drawing.Size(134, 20);
            this.lb_username2.TabIndex = 62;
            this.lb_username2.Text = "Tên đăng nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cấp bậc mới:";
            // 
            // bt_create
            // 
            this.bt_create.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_create.Location = new System.Drawing.Point(62, 278);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(149, 35);
            this.bt_create.TabIndex = 63;
            this.bt_create.Text = "Tạo tài khoản mới";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // pn_crt_account
            // 
            this.pn_crt_account.Controls.Add(this.tb_crt_id);
            this.pn_crt_account.Controls.Add(this.label9);
            this.pn_crt_account.Controls.Add(this.tb_crt_username);
            this.pn_crt_account.Controls.Add(this.cb_crt_aceslevel);
            this.pn_crt_account.Controls.Add(this.label1);
            this.pn_crt_account.Controls.Add(this.label6);
            this.pn_crt_account.Controls.Add(this.label7);
            this.pn_crt_account.Controls.Add(this.button1);
            this.pn_crt_account.Controls.Add(this.label8);
            this.pn_crt_account.Controls.Add(this.button2);
            this.pn_crt_account.Controls.Add(this.tb_crt_password);
            this.pn_crt_account.Controls.Add(this.tb_crt_cf_pass);
            this.pn_crt_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.pn_crt_account.Location = new System.Drawing.Point(469, 67);
            this.pn_crt_account.Name = "pn_crt_account";
            this.pn_crt_account.Size = new System.Drawing.Size(411, 309);
            this.pn_crt_account.TabIndex = 67;
            // 
            // tb_crt_id
            // 
            this.tb_crt_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_crt_id.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_crt_id.Location = new System.Drawing.Point(201, 22);
            this.tb_crt_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_crt_id.Multiline = true;
            this.tb_crt_id.Name = "tb_crt_id";
            this.tb_crt_id.Size = new System.Drawing.Size(187, 29);
            this.tb_crt_id.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 67;
            this.label9.Text = "ID:";
            // 
            // tb_crt_username
            // 
            this.tb_crt_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_crt_username.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_crt_username.Location = new System.Drawing.Point(203, 68);
            this.tb_crt_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_crt_username.Multiline = true;
            this.tb_crt_username.Name = "tb_crt_username";
            this.tb_crt_username.Size = new System.Drawing.Size(187, 29);
            this.tb_crt_username.TabIndex = 63;
            // 
            // cb_crt_aceslevel
            // 
            this.cb_crt_aceslevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_crt_aceslevel.FormattingEnabled = true;
            this.cb_crt_aceslevel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cb_crt_aceslevel.Location = new System.Drawing.Point(203, 194);
            this.cb_crt_aceslevel.Name = "cb_crt_aceslevel";
            this.cb_crt_aceslevel.Size = new System.Drawing.Size(62, 21);
            this.cb_crt_aceslevel.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 65;
            this.label7.Text = "Cấp bậc:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(225, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 61;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Nhập lại mật khẩu:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(45, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 35);
            this.button2.TabIndex = 60;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt_crt_new_Click);
            // 
            // tb_crt_password
            // 
            this.tb_crt_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_crt_password.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_crt_password.Location = new System.Drawing.Point(203, 110);
            this.tb_crt_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_crt_password.Name = "tb_crt_password";
            this.tb_crt_password.Size = new System.Drawing.Size(187, 31);
            this.tb_crt_password.TabIndex = 58;
            this.tb_crt_password.UseSystemPasswordChar = true;
            // 
            // tb_crt_cf_pass
            // 
            this.tb_crt_cf_pass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_crt_cf_pass.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_crt_cf_pass.Location = new System.Drawing.Point(203, 151);
            this.tb_crt_cf_pass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_crt_cf_pass.Name = "tb_crt_cf_pass";
            this.tb_crt_cf_pass.Size = new System.Drawing.Size(187, 31);
            this.tb_crt_cf_pass.TabIndex = 59;
            this.tb_crt_cf_pass.UseSystemPasswordChar = true;
            // 
            // pn_promote
            // 
            this.pn_promote.Controls.Add(this.tb_pro_id);
            this.pn_promote.Controls.Add(this.label11);
            this.pn_promote.Controls.Add(this.tb_username3);
            this.pn_promote.Controls.Add(this.bt3);
            this.pn_promote.Controls.Add(this.label10);
            this.pn_promote.Controls.Add(this.label5);
            this.pn_promote.Controls.Add(this.bt_cf_promote);
            this.pn_promote.Controls.Add(this.tb_pro_aclvl);
            this.pn_promote.Location = new System.Drawing.Point(472, 70);
            this.pn_promote.Name = "pn_promote";
            this.pn_promote.Size = new System.Drawing.Size(422, 233);
            this.pn_promote.TabIndex = 68;
            // 
            // tb_pro_id
            // 
            this.tb_pro_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pro_id.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pro_id.Location = new System.Drawing.Point(202, 39);
            this.tb_pro_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pro_id.Multiline = true;
            this.tb_pro_id.Name = "tb_pro_id";
            this.tb_pro_id.ReadOnly = true;
            this.tb_pro_id.Size = new System.Drawing.Size(186, 21);
            this.tb_pro_id.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "ID:";
            // 
            // tb_username3
            // 
            this.tb_username3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username3.Location = new System.Drawing.Point(202, 80);
            this.tb_username3.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username3.Multiline = true;
            this.tb_username3.Name = "tb_username3";
            this.tb_username3.ReadOnly = true;
            this.tb_username3.Size = new System.Drawing.Size(186, 21);
            this.tb_username3.TabIndex = 65;
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(206, 164);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(149, 35);
            this.bt3.TabIndex = 65;
            this.bt3.Text = "Huỷ";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "Tên đăng nhập:";
            // 
            // bt_cf_promote
            // 
            this.bt_cf_promote.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cf_promote.Location = new System.Drawing.Point(26, 164);
            this.bt_cf_promote.Name = "bt_cf_promote";
            this.bt_cf_promote.Size = new System.Drawing.Size(149, 35);
            this.bt_cf_promote.TabIndex = 64;
            this.bt_cf_promote.Text = "Xác nhận";
            this.bt_cf_promote.UseVisualStyleBackColor = true;
            this.bt_cf_promote.Click += new System.EventHandler(this.bt_cf_promote_Click);
            // 
            // tb_pro_aclvl
            // 
            this.tb_pro_aclvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_pro_aclvl.FormattingEnabled = true;
            this.tb_pro_aclvl.Items.AddRange(new object[] {
            "0",
            "1"});
            this.tb_pro_aclvl.Location = new System.Drawing.Point(202, 123);
            this.tb_pro_aclvl.Name = "tb_pro_aclvl";
            this.tb_pro_aclvl.Size = new System.Drawing.Size(62, 21);
            this.tb_pro_aclvl.TabIndex = 66;
            // 
            // bt_promote
            // 
            this.bt_promote.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold);
            this.bt_promote.Location = new System.Drawing.Point(256, 318);
            this.bt_promote.Name = "bt_promote";
            this.bt_promote.Size = new System.Drawing.Size(149, 35);
            this.bt_promote.TabIndex = 69;
            this.bt_promote.Text = "Thăng cấp";
            this.bt_promote.UseVisualStyleBackColor = true;
            this.bt_promote.Click += new System.EventHandler(this.bt_promote_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_account_list);
            this.groupBox1.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 200);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH TÀI KHOẢN ĐĂNG NHẬP PHẦN MỀM";
            // 
            // bt_delete_account
            // 
            this.bt_delete_account.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete_account.Location = new System.Drawing.Point(62, 318);
            this.bt_delete_account.Name = "bt_delete_account";
            this.bt_delete_account.Size = new System.Drawing.Size(149, 35);
            this.bt_delete_account.TabIndex = 71;
            this.bt_delete_account.Text = "Xoá tài khoản này";
            this.bt_delete_account.UseVisualStyleBackColor = true;
            this.bt_delete_account.Click += new System.EventHandler(this.bt_delete_account_Click);
            // 
            // UC_AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_crt_account);
            this.Controls.Add(this.pn_promote);
            this.Controls.Add(this.bt_delete_account);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_promote);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.bt_change_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_accesslevel);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pn_change_pass);
            this.Name = "UC_AccountManager";
            this.Size = new System.Drawing.Size(991, 647);
            this.Load += new System.EventHandler(this.UC_AccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account_list)).EndInit();
            this.pn_change_pass.ResumeLayout(false);
            this.pn_change_pass.PerformLayout();
            this.pn_crt_account.ResumeLayout(false);
            this.pn_crt_account.PerformLayout();
            this.pn_promote.ResumeLayout(false);
            this.pn_promote.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_account_list;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_accesslevel;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button bt_change_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCESSLEVEL;
        private System.Windows.Forms.Label lb_newpass;
        private System.Windows.Forms.Label lb_confirm_newpass;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.TextBox tb_confirm_newpass;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Panel pn_change_pass;
        private System.Windows.Forms.TextBox tb_username2;
        private System.Windows.Forms.Label lb_username2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Panel pn_crt_account;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_crt_username;
        private System.Windows.Forms.ComboBox cb_crt_aceslevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_crt_password;
        private System.Windows.Forms.TextBox tb_crt_cf_pass;
        private System.Windows.Forms.Panel pn_promote;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt_cf_promote;
        private System.Windows.Forms.Button bt_promote;
        private System.Windows.Forms.TextBox tb_username3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_pro_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_delete_account;
        private System.Windows.Forms.ComboBox tb_pro_aclvl;
        private System.Windows.Forms.TextBox tb_crt_id;
        private System.Windows.Forms.TextBox tb_ch_id;
    }
}
